namespace ChargerChecking
{
    partial class ChargerCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChargerCheck));
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_BatteryText = new Label();
            label1 = new Label();
            exitbtn = new Button();
            cancelbtn = new Button();
            chargerStatusbtn = new Button();
            menuStrip1 = new MenuStrip();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.69638F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.30362F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 171F));
            tableLayoutPanel1.Controls.Add(lbl_BatteryText, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(exitbtn, 2, 1);
            tableLayoutPanel1.Controls.Add(cancelbtn, 0, 1);
            tableLayoutPanel1.Controls.Add(chargerStatusbtn, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.No;
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(531, 69);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_BatteryText
            // 
            lbl_BatteryText.AutoSize = true;
            lbl_BatteryText.Dock = DockStyle.Fill;
            lbl_BatteryText.Location = new Point(362, 0);
            lbl_BatteryText.Name = "lbl_BatteryText";
            lbl_BatteryText.Size = new Size(166, 18);
            lbl_BatteryText.TabIndex = 4;
            lbl_BatteryText.Text = "Batter Percentage";
            lbl_BatteryText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(353, 18);
            label1.TabIndex = 2;
            label1.Text = "Batter Percentage";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitbtn
            // 
            exitbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exitbtn.AutoSize = true;
            exitbtn.Location = new Point(362, 21);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(166, 45);
            exitbtn.TabIndex = 0;
            exitbtn.Text = "Exit Application";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cancelbtn.Location = new Point(3, 21);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(176, 45);
            cancelbtn.TabIndex = 1;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // chargerStatusbtn
            // 
            chargerStatusbtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chargerStatusbtn.Location = new Point(185, 21);
            chargerStatusbtn.Name = "chargerStatusbtn";
            chargerStatusbtn.Size = new Size(171, 45);
            chargerStatusbtn.TabIndex = 5;
            chargerStatusbtn.Text = "Charger Status";
            chargerStatusbtn.UseVisualStyleBackColor = true;
            chargerStatusbtn.Click += chargerStatusbtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(531, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ChargerCheck
            // 
            AcceptButton = chargerStatusbtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelbtn;
            ClientSize = new Size(531, 97);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ChargerCheck";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Charger Checking";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button cancelbtn;
        private Label label1;
        private Label lbl_BatteryText;
        private Button exitbtn;
        private Button chargerStatusbtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}