using PostmanLibrary;

namespace PostmanUI;

public partial class Dashboard : Form
{
    private readonly IApiAccess apiAccess = new ApiAccess();
    public Dashboard()
    {
        InitializeComponent();
        HttpVerbSelector.SelectedItem = "GET";
    }

    private void resultstxt_TextChanged(object sender, EventArgs e)
    {

    }

    private void Dashboard_Load(object sender, EventArgs e)
    {

    }


    // clicking the GO button calls the api(s) and get a JSON value
    private async void CallApi_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultstxt.Text = "";

        if (apiAccess.ValidUrl(ApiText.Text) == false)
        {
            systemStatus.Text = "Invalid Url";
            return;
        }

        HttpAction action;
        if (Enum.TryParse(HttpVerbSelector.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP verb";
            return;
        }


        try
        {

            resultstxt.Text = await apiAccess.CallApiAsync(ApiText.Text, bodyText.Text, action);
            CallData.SelectedTab = ResultsTab;

            // this ensure that text from results tab is not highlighted
            ResultsTab.Focus();

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultstxt.Text = "Error " + ex.Message;
            systemStatus.Text = "Error";
        }
    }

    private void HttpVerbSelector_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
