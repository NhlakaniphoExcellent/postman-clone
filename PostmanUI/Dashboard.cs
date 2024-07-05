using PostmanLibrary;

namespace PostmanUI;

public partial class Dashboard : Form
{
    private readonly ApiAccess apiAccess = new();
    public Dashboard()
    {
        InitializeComponent();
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
        try
        {
            systemStatus.Text = "Calling API...";

            resultstxt.Text = await apiAccess.CallApiAsync(ApiText.Text);
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
             resultstxt.Text = "Error " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
