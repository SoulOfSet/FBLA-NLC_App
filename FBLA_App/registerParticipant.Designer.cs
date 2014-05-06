namespace FBLA_App
{
    partial class registerParticipant
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
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textLast = new System.Windows.Forms.Label();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.labelPart = new System.Windows.Forms.Label();
            this.labelConference = new System.Windows.Forms.Label();
            this.comboConference = new System.Windows.Forms.ComboBox();
            this.labelChapNum = new System.Windows.Forms.Label();
            this.textChapNum = new System.Windows.Forms.TextBox();
            this.labelNumValOnly = new System.Windows.Forms.Label();
            this.checkBoxWkshpReg = new System.Windows.Forms.CheckBox();
            this.listWorkshops = new System.Windows.Forms.ListBox();
            this.labelInfoList = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(50, 75);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(125, 20);
            this.textFirstName.TabIndex = 0;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(50, 125);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(125, 20);
            this.textLastName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(47, 56);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // textLast
            // 
            this.textLast.AutoSize = true;
            this.textLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLast.Location = new System.Drawing.Point(47, 105);
            this.textLast.Name = "textLast";
            this.textLast.Size = new System.Drawing.Size(76, 17);
            this.textLast.TabIndex = 3;
            this.textLast.Text = "Last Name";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(50, 200);
            this.comboType.MaxDropDownItems = 100;
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(125, 21);
            this.comboType.TabIndex = 4;
            // 
            // labelPart
            // 
            this.labelPart.AutoSize = true;
            this.labelPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPart.Location = new System.Drawing.Point(47, 180);
            this.labelPart.Name = "labelPart";
            this.labelPart.Size = new System.Drawing.Size(111, 17);
            this.labelPart.TabIndex = 5;
            this.labelPart.Text = "Participant Type";
            // 
            // labelConference
            // 
            this.labelConference.AutoSize = true;
            this.labelConference.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConference.Location = new System.Drawing.Point(47, 235);
            this.labelConference.Name = "labelConference";
            this.labelConference.Size = new System.Drawing.Size(81, 17);
            this.labelConference.TabIndex = 6;
            this.labelConference.Text = "Conference";
            // 
            // comboConference
            // 
            this.comboConference.FormattingEnabled = true;
            this.comboConference.Location = new System.Drawing.Point(50, 255);
            this.comboConference.MaxDropDownItems = 100;
            this.comboConference.Name = "comboConference";
            this.comboConference.Size = new System.Drawing.Size(125, 21);
            this.comboConference.TabIndex = 7;
            this.comboConference.SelectedIndexChanged += new System.EventHandler(this.comboConference_SelectedIndexChanged);
            // 
            // labelChapNum
            // 
            this.labelChapNum.AutoSize = true;
            this.labelChapNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChapNum.Location = new System.Drawing.Point(50, 289);
            this.labelChapNum.Name = "labelChapNum";
            this.labelChapNum.Size = new System.Drawing.Size(105, 17);
            this.labelChapNum.TabIndex = 9;
            this.labelChapNum.Text = "District Number";
            // 
            // textChapNum
            // 
            this.textChapNum.Location = new System.Drawing.Point(53, 310);
            this.textChapNum.Name = "textChapNum";
            this.textChapNum.Size = new System.Drawing.Size(125, 20);
            this.textChapNum.TabIndex = 10;
            this.textChapNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textChapNum_KeyPress);
            // 
            // labelNumValOnly
            // 
            this.labelNumValOnly.AutoSize = true;
            this.labelNumValOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumValOnly.Location = new System.Drawing.Point(184, 317);
            this.labelNumValOnly.Name = "labelNumValOnly";
            this.labelNumValOnly.Size = new System.Drawing.Size(110, 13);
            this.labelNumValOnly.TabIndex = 11;
            this.labelNumValOnly.Text = "Numerical values only";
            // 
            // checkBoxWkshpReg
            // 
            this.checkBoxWkshpReg.AutoSize = true;
            this.checkBoxWkshpReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWkshpReg.Location = new System.Drawing.Point(209, 74);
            this.checkBoxWkshpReg.Name = "checkBoxWkshpReg";
            this.checkBoxWkshpReg.Size = new System.Drawing.Size(135, 21);
            this.checkBoxWkshpReg.TabIndex = 12;
            this.checkBoxWkshpReg.Text = "Add Workshops?";
            this.checkBoxWkshpReg.UseVisualStyleBackColor = true;
            this.checkBoxWkshpReg.CheckedChanged += new System.EventHandler(this.checkBoxWkshpReg_CheckedChanged);
            // 
            // listWorkshops
            // 
            this.listWorkshops.Enabled = false;
            this.listWorkshops.FormattingEnabled = true;
            this.listWorkshops.HorizontalScrollbar = true;
            this.listWorkshops.Location = new System.Drawing.Point(209, 105);
            this.listWorkshops.Name = "listWorkshops";
            this.listWorkshops.Size = new System.Drawing.Size(120, 186);
            this.listWorkshops.TabIndex = 13;
            // 
            // labelInfoList
            // 
            this.labelInfoList.AutoSize = true;
            this.labelInfoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoList.Location = new System.Drawing.Point(217, 294);
            this.labelInfoList.Name = "labelInfoList";
            this.labelInfoList.Size = new System.Drawing.Size(99, 13);
            this.labelInfoList.TabIndex = 14;
            this.labelInfoList.Text = "Select all that apply";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(220, 344);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(90, 30);
            this.buttonRegister.TabIndex = 15;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // registerParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 386);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelInfoList);
            this.Controls.Add(this.listWorkshops);
            this.Controls.Add(this.checkBoxWkshpReg);
            this.Controls.Add(this.labelNumValOnly);
            this.Controls.Add(this.textChapNum);
            this.Controls.Add(this.labelChapNum);
            this.Controls.Add(this.comboConference);
            this.Controls.Add(this.labelConference);
            this.Controls.Add(this.labelPart);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.textLast);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Name = "registerParticipant";
            this.Text = "Register Participant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.registerParticipant_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label textLast;
        private System.Windows.Forms.Label labelPart;
        private System.Windows.Forms.Label labelConference;
        private System.Windows.Forms.ComboBox comboConference;
        private System.Windows.Forms.Label labelChapNum;
        private System.Windows.Forms.TextBox textChapNum;
        private System.Windows.Forms.Label labelNumValOnly;
        private System.Windows.Forms.CheckBox checkBoxWkshpReg;
        private System.Windows.Forms.ListBox listWorkshops;
        public System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label labelInfoList;
        private System.Windows.Forms.Button buttonRegister;
    }
}