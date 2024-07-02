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
            resultstxt = new TextBox();
            CallApi = new Button();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            Results = new Label();
            statusStrip.SuspendLayout();
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
            APIinput.Location = new Point(27, 100);
            APIinput.Name = "APIinput";
            APIinput.Size = new Size(69, 41);
            APIinput.TabIndex = 1;
            APIinput.Text = "API:";
            // 
            // ApiText
            // 
            ApiText.BorderStyle = BorderStyle.FixedSingle;
            ApiText.Location = new Point(102, 93);
            ApiText.Name = "ApiText";
            ApiText.Size = new Size(918, 47);
            ApiText.TabIndex = 2;
            // 
            // resultstxt
            // 
            resultstxt.BorderStyle = BorderStyle.FixedSingle;
            resultstxt.Location = new Point(27, 235);
            resultstxt.Multiline = true;
            resultstxt.Name = "resultstxt";
            resultstxt.ReadOnly = true;
            resultstxt.ScrollBars = ScrollBars.Both;
            resultstxt.Size = new Size(1100, 498);
            resultstxt.TabIndex = 3;
            resultstxt.TextChanged += resultstxt_TextChanged;
            // 
            // CallApi
            // 
            CallApi.BackColor = Color.DodgerBlue;
            CallApi.ForeColor = Color.SeaShell;
            CallApi.Location = new Point(1026, 93);
            CallApi.Name = "CallApi";
            CallApi.Size = new Size(101, 48);
            CallApi.TabIndex = 4;
            CallApi.Text = "Send";
            CallApi.UseVisualStyleBackColor = false;
            CallApi.Click += CallApi_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 757);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1628, 37);
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
            // Results
            // 
            Results.AutoSize = true;
            Results.Location = new Point(27, 191);
            Results.Name = "Results";
            Results.Size = new Size(146, 41);
            Results.TabIndex = 6;
            Results.Text = "Response";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1628, 794);
            Controls.Add(Results);
            Controls.Add(statusStrip);
            Controls.Add(CallApi);
            Controls.Add(resultstxt);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Header;
        private Label APIinput;
        private TextBox ApiText;
        private TextBox resultstxt;
        private Button CallApi;
        private StatusStrip statusStrip;
        private Label Results;
        private ToolStripStatusLabel systemStatus;
    }
}
