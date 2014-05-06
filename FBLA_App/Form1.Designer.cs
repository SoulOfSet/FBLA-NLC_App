namespace FBLA_App
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.regPartButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.buttonAddWkshp = new System.Windows.Forms.Button();
            this.buttonViewHelp = new System.Windows.Forms.Button();
            this.tabViewPart = new System.Windows.Forms.TabPage();
            this.dataGridPart = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tapViewWkshp = new System.Windows.Forms.TabPage();
            this.treeViewWkshp = new System.Windows.Forms.TreeView();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.nameLabel = new System.Windows.Forms.Label();
            this.labelInfoClick = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabViewPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPart)).BeginInit();
            this.tapViewWkshp.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Papyrus", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(95, 25);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(386, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "FBLA Conference Registration Tool";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // regPartButton
            // 
            this.regPartButton.BackColor = System.Drawing.Color.LightCyan;
            this.regPartButton.Location = new System.Drawing.Point(200, 80);
            this.regPartButton.Name = "regPartButton";
            this.regPartButton.Size = new System.Drawing.Size(150, 50);
            this.regPartButton.TabIndex = 1;
            this.regPartButton.Text = "Register Participant";
            this.regPartButton.UseVisualStyleBackColor = false;
            this.regPartButton.Click += new System.EventHandler(this.regPartButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabViewPart);
            this.tabControl.Controls.Add(this.tapViewWkshp);
            this.tabControl.Controls.Add(this.tabAbout);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(583, 364);
            this.tabControl.TabIndex = 3;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.buttonAddWkshp);
            this.tabHome.Controls.Add(this.buttonViewHelp);
            this.tabHome.Controls.Add(this.regPartButton);
            this.tabHome.Controls.Add(this.titleLabel);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(575, 338);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // buttonAddWkshp
            // 
            this.buttonAddWkshp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonAddWkshp.Location = new System.Drawing.Point(200, 160);
            this.buttonAddWkshp.Name = "buttonAddWkshp";
            this.buttonAddWkshp.Size = new System.Drawing.Size(150, 50);
            this.buttonAddWkshp.TabIndex = 3;
            this.buttonAddWkshp.Text = "Add Workshop";
            this.buttonAddWkshp.UseVisualStyleBackColor = false;
            this.buttonAddWkshp.Click += new System.EventHandler(this.buttonAddWkshp_Click);
            // 
            // buttonViewHelp
            // 
            this.buttonViewHelp.BackColor = System.Drawing.Color.LightCyan;
            this.buttonViewHelp.Location = new System.Drawing.Point(200, 240);
            this.buttonViewHelp.Name = "buttonViewHelp";
            this.buttonViewHelp.Size = new System.Drawing.Size(150, 50);
            this.buttonViewHelp.TabIndex = 2;
            this.buttonViewHelp.Text = "Instructions";
            this.buttonViewHelp.UseVisualStyleBackColor = false;
            this.buttonViewHelp.Click += new System.EventHandler(this.buttonViewHelp_Click);
            // 
            // tabViewPart
            // 
            this.tabViewPart.Controls.Add(this.labelInfoClick);
            this.tabViewPart.Controls.Add(this.dataGridPart);
            this.tabViewPart.Location = new System.Drawing.Point(4, 22);
            this.tabViewPart.Name = "tabViewPart";
            this.tabViewPart.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewPart.Size = new System.Drawing.Size(575, 338);
            this.tabViewPart.TabIndex = 1;
            this.tabViewPart.Text = "View Participants";
            this.tabViewPart.UseVisualStyleBackColor = true;
            // 
            // dataGridPart
            // 
            this.dataGridPart.AllowUserToAddRows = false;
            this.dataGridPart.AllowUserToDeleteRows = false;
            this.dataGridPart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridPart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.Type,
            this.Conference,
            this.ChapterNumber});
            this.dataGridPart.Location = new System.Drawing.Point(-4, 3);
            this.dataGridPart.Name = "dataGridPart";
            this.dataGridPart.ReadOnly = true;
            this.dataGridPart.Size = new System.Drawing.Size(579, 315);
            this.dataGridPart.TabIndex = 0;
            this.dataGridPart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPart_CellClick);
            this.dataGridPart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPart_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Conference
            // 
            this.Conference.HeaderText = "Conference";
            this.Conference.Name = "Conference";
            this.Conference.ReadOnly = true;
            // 
            // ChapterNumber
            // 
            this.ChapterNumber.HeaderText = "District Number";
            this.ChapterNumber.Name = "ChapterNumber";
            this.ChapterNumber.ReadOnly = true;
            // 
            // tapViewWkshp
            // 
            this.tapViewWkshp.Controls.Add(this.treeViewWkshp);
            this.tapViewWkshp.Location = new System.Drawing.Point(4, 22);
            this.tapViewWkshp.Name = "tapViewWkshp";
            this.tapViewWkshp.Padding = new System.Windows.Forms.Padding(3);
            this.tapViewWkshp.Size = new System.Drawing.Size(575, 338);
            this.tapViewWkshp.TabIndex = 4;
            this.tapViewWkshp.Text = "Workshops";
            this.tapViewWkshp.UseVisualStyleBackColor = true;
            // 
            // treeViewWkshp
            // 
            this.treeViewWkshp.Location = new System.Drawing.Point(3, 0);
            this.treeViewWkshp.Name = "treeViewWkshp";
            this.treeViewWkshp.Size = new System.Drawing.Size(576, 338);
            this.treeViewWkshp.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.nameLabel);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(575, 338);
            this.tabAbout.TabIndex = 3;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(88, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(390, 225);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Programmed by Jacob Sabella (SoulOfSet)\r\n\r\nDesktop Publishing Competetive Event\r\n" +
                "\r\n2014\r\n\r\nElsberry Chapter\r\nDistrict 7\r\nAdviser: Judy Gomel";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfoClick
            // 
            this.labelInfoClick.AutoSize = true;
            this.labelInfoClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoClick.Location = new System.Drawing.Point(6, 321);
            this.labelInfoClick.Name = "labelInfoClick";
            this.labelInfoClick.Size = new System.Drawing.Size(362, 13);
            this.labelInfoClick.TabIndex = 1;
            this.labelInfoClick.Text = "*Double click in a row to generate a conference schedule for that individual";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl);
            this.Name = "mainForm";
            this.Text = "FBLA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabViewPart.ResumeLayout(false);
            this.tabViewPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPart)).EndInit();
            this.tapViewWkshp.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button regPartButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabViewPart;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView dataGridPart;
        private System.Windows.Forms.Button buttonViewHelp;
        private System.Windows.Forms.Button buttonAddWkshp;
        private System.Windows.Forms.TabPage tapViewWkshp;
        private System.Windows.Forms.TreeView treeViewWkshp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conference;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterNumber;
        private System.Windows.Forms.Label labelInfoClick;
    }
}

