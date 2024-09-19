namespace PostmanUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Header = new Label();
            APIinput = new Label();
            ApiText = new TextBox();
            CallApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            HttpVerbSelector = new ComboBox();
            CallData = new TabControl();
            BodyTab = new TabPage();
            bodyText = new TextBox();
            ResultsTab = new TabPage();
            resultstxt = new TextBox();
            statusStrip.SuspendLayout();
            CallData.SuspendLayout();
            BodyTab.SuspendLayout();
            ResultsTab.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Header.Location = new Point(27, 9);
            Header.Name = "Header";
            Header.Size = new Size(317, 60);
            Header.TabIndex = 0;
            Header.Text = "Postman Clone";
            // 
            // APIinput
            // 
            APIinput.AutoSize = true;
            APIinput.Location = new Point(27, 95);
            APIinput.Name = "APIinput";
            APIinput.Size = new Size(69, 41);
            APIinput.TabIndex = 1;
            APIinput.Text = "API:";
            // 
            // ApiText
            // 
            ApiText.BorderStyle = BorderStyle.FixedSingle;
            ApiText.Location = new Point(253, 95);
            ApiText.Name = "ApiText";
            ApiText.Size = new Size(858, 47);
            ApiText.TabIndex = 2;
            // 
            // CallApi
            // 
            CallApi.BackColor = Color.DodgerBlue;
            CallApi.ForeColor = Color.SeaShell;
            CallApi.Location = new Point(1135, 95);
            CallApi.Name = "CallApi";
            CallApi.Size = new Size(143, 48);
            CallApi.TabIndex = 4;
            CallApi.Text = "Send";
            CallApi.UseVisualStyleBackColor = false;
            CallApi.Click += CallApi_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 850);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1637, 37);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(76, 31);
            systemStatus.Text = "Ready";
            // 
            // HttpVerbSelector
            // 
            HttpVerbSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            HttpVerbSelector.FormattingEnabled = true;
            HttpVerbSelector.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "DELETE" });
            HttpVerbSelector.Location = new Point(102, 93);
            HttpVerbSelector.Name = "HttpVerbSelector";
            HttpVerbSelector.Size = new Size(145, 49);
            HttpVerbSelector.TabIndex = 7;
            HttpVerbSelector.SelectedIndexChanged += HttpVerbSelector_SelectedIndexChanged;
            // 
            // CallData
            // 
            CallData.Controls.Add(BodyTab);
            CallData.Controls.Add(ResultsTab);
            CallData.Location = new Point(39, 184);
            CallData.Name = "CallData";
            CallData.SelectedIndex = 0;
            CallData.Size = new Size(1256, 570);
            CallData.TabIndex = 8;
            // 
            // BodyTab
            // 
            BodyTab.Controls.Add(bodyText);
            BodyTab.Location = new Point(4, 50);
            BodyTab.Name = "BodyTab";
            BodyTab.Padding = new Padding(3);
            BodyTab.Size = new Size(1248, 516);
            BodyTab.TabIndex = 0;
            BodyTab.Text = "Body";
            BodyTab.UseVisualStyleBackColor = true;
            // 
            // bodyText
            // 
            bodyText.BorderStyle = BorderStyle.FixedSingle;
            bodyText.Dock = DockStyle.Fill;
            bodyText.Location = new Point(3, 3);
            bodyText.Multiline = true;
            bodyText.Name = "bodyText";
            bodyText.ScrollBars = ScrollBars.Both;
            bodyText.Size = new Size(1242, 510);
            bodyText.TabIndex = 4;
            // 
            // ResultsTab
            // 
            ResultsTab.Controls.Add(resultstxt);
            ResultsTab.Location = new Point(4, 29);
            ResultsTab.Name = "ResultsTab";
            ResultsTab.Padding = new Padding(3);
            ResultsTab.Size = new Size(1248, 537);
            ResultsTab.TabIndex = 1;
            ResultsTab.Text = "Results";
            ResultsTab.UseVisualStyleBackColor = true;
            // 
            // resultstxt
            // 
            resultstxt.BorderStyle = BorderStyle.FixedSingle;
            resultstxt.Dock = DockStyle.Fill;
            resultstxt.Location = new Point(3, 3);
            resultstxt.Multiline = true;
            resultstxt.Name = "resultstxt";
            resultstxt.ReadOnly = true;
            resultstxt.ScrollBars = ScrollBars.Both;
            resultstxt.Size = new Size(1242, 531);
            resultstxt.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1637, 887);
            Controls.Add(CallData);
            Controls.Add(HttpVerbSelector);
            Controls.Add(statusStrip);
            Controls.Add(CallApi);
            Controls.Add(ApiText);
            Controls.Add(APIinput);
            Controls.Add(Header);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Postman Clone";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            CallData.ResumeLayout(false);
            BodyTab.ResumeLayout(false);
            BodyTab.PerformLayout();
            ResultsTab.ResumeLayout(false);
            ResultsTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label APIinput;
        private TextBox ApiText;
        private Button CallApi;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private ComboBox HttpVerbSelector;
        private TabControl CallData;
        private TabPage BodyTab;
        private TabPage ResultsTab;
        private TextBox resultstxt;
        private TextBox bodyText;
    }
}
