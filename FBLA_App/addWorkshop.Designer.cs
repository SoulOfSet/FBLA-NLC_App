namespace FBLA_App
{
    partial class addWorkshop
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
            this.labelWkshpName = new System.Windows.Forms.Label();
            this.textWkshpName = new System.Windows.Forms.TextBox();
            this.labelWkshpDesc = new System.Windows.Forms.Label();
            this.textWkshpDesc = new System.Windows.Forms.TextBox();
            this.labelWkshpConf = new System.Windows.Forms.Label();
            this.comboWkshpConf = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textDateD = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.textDateM = new System.Windows.Forms.TextBox();
            this.labelM = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.textStartTime1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textStartTime2 = new System.Windows.Forms.TextBox();
            this.labelIntVal = new System.Windows.Forms.Label();
            this.comboAMPM = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWkshpName
            // 
            this.labelWkshpName.AutoSize = true;
            this.labelWkshpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWkshpName.Location = new System.Drawing.Point(40, 29);
            this.labelWkshpName.Name = "labelWkshpName";
            this.labelWkshpName.Size = new System.Drawing.Size(113, 17);
            this.labelWkshpName.TabIndex = 0;
            this.labelWkshpName.Text = "Workshop Name";
            // 
            // textWkshpName
            // 
            this.textWkshpName.Location = new System.Drawing.Point(43, 49);
            this.textWkshpName.Name = "textWkshpName";
            this.textWkshpName.Size = new System.Drawing.Size(125, 20);
            this.textWkshpName.TabIndex = 1;
            // 
            // labelWkshpDesc
            // 
            this.labelWkshpDesc.AutoSize = true;
            this.labelWkshpDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWkshpDesc.Location = new System.Drawing.Point(40, 82);
            this.labelWkshpDesc.Name = "labelWkshpDesc";
            this.labelWkshpDesc.Size = new System.Drawing.Size(147, 17);
            this.labelWkshpDesc.TabIndex = 2;
            this.labelWkshpDesc.Text = "Workshop Description";
            // 
            // textWkshpDesc
            // 
            this.textWkshpDesc.AcceptsReturn = true;
            this.textWkshpDesc.Location = new System.Drawing.Point(43, 102);
            this.textWkshpDesc.Multiline = true;
            this.textWkshpDesc.Name = "textWkshpDesc";
            this.textWkshpDesc.Size = new System.Drawing.Size(200, 100);
            this.textWkshpDesc.TabIndex = 3;
            // 
            // labelWkshpConf
            // 
            this.labelWkshpConf.AutoSize = true;
            this.labelWkshpConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWkshpConf.Location = new System.Drawing.Point(40, 215);
            this.labelWkshpConf.Name = "labelWkshpConf";
            this.labelWkshpConf.Size = new System.Drawing.Size(149, 17);
            this.labelWkshpConf.TabIndex = 4;
            this.labelWkshpConf.Text = "Workshop Conference";
            // 
            // comboWkshpConf
            // 
            this.comboWkshpConf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWkshpConf.FormattingEnabled = true;
            this.comboWkshpConf.Location = new System.Drawing.Point(43, 235);
            this.comboWkshpConf.MaxDropDownItems = 100;
            this.comboWkshpConf.Name = "comboWkshpConf";
            this.comboWkshpConf.Size = new System.Drawing.Size(125, 21);
            this.comboWkshpConf.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(40, 271);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(38, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date";
            // 
            // textDateD
            // 
            this.textDateD.Location = new System.Drawing.Point(70, 295);
            this.textDateD.MaxLength = 2;
            this.textDateD.Name = "textDateD";
            this.textDateD.Size = new System.Drawing.Size(35, 20);
            this.textDateD.TabIndex = 7;
            this.textDateD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDateD_KeyPress);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(40, 298);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(26, 13);
            this.labelD.TabIndex = 8;
            this.labelD.Text = "Day";
            // 
            // textDateM
            // 
            this.textDateM.Location = new System.Drawing.Point(154, 295);
            this.textDateM.MaxLength = 2;
            this.textDateM.Name = "textDateM";
            this.textDateM.Size = new System.Drawing.Size(35, 20);
            this.textDateM.TabIndex = 9;
            this.textDateM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textM_KeyPress);
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(111, 298);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(37, 13);
            this.labelM.TabIndex = 10;
            this.labelM.Text = "Month";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(40, 329);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(73, 17);
            this.labelStartTime.TabIndex = 11;
            this.labelStartTime.Text = "Start Time";
            // 
            // textStartTime1
            // 
            this.textStartTime1.Location = new System.Drawing.Point(43, 349);
            this.textStartTime1.MaxLength = 2;
            this.textStartTime1.Name = "textStartTime1";
            this.textStartTime1.Size = new System.Drawing.Size(35, 20);
            this.textStartTime1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = ":";
            // 
            // textStartTime2
            // 
            this.textStartTime2.Location = new System.Drawing.Point(104, 348);
            this.textStartTime2.MaxLength = 2;
            this.textStartTime2.Name = "textStartTime2";
            this.textStartTime2.Size = new System.Drawing.Size(35, 20);
            this.textStartTime2.TabIndex = 14;
            // 
            // labelIntVal
            // 
            this.labelIntVal.AutoSize = true;
            this.labelIntVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIntVal.Location = new System.Drawing.Point(111, 332);
            this.labelIntVal.Name = "labelIntVal";
            this.labelIntVal.Size = new System.Drawing.Size(96, 13);
            this.labelIntVal.TabIndex = 15;
            this.labelIntVal.Text = "Integer values only";
            // 
            // comboAMPM
            // 
            this.comboAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAMPM.FormattingEnabled = true;
            this.comboAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.comboAMPM.Location = new System.Drawing.Point(154, 346);
            this.comboAMPM.MaxDropDownItems = 2;
            this.comboAMPM.Name = "comboAMPM";
            this.comboAMPM.Size = new System.Drawing.Size(45, 21);
            this.comboAMPM.TabIndex = 16;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(242, 340);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(90, 30);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // addWorkshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 396);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboAMPM);
            this.Controls.Add(this.labelIntVal);
            this.Controls.Add(this.textStartTime2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStartTime1);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.textDateM);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.textDateD);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboWkshpConf);
            this.Controls.Add(this.labelWkshpConf);
            this.Controls.Add(this.textWkshpDesc);
            this.Controls.Add(this.labelWkshpDesc);
            this.Controls.Add(this.textWkshpName);
            this.Controls.Add(this.labelWkshpName);
            this.Name = "addWorkshop";
            this.Text = "Add Workshop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addWorkshop_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWkshpName;
        private System.Windows.Forms.TextBox textWkshpName;
        private System.Windows.Forms.Label labelWkshpDesc;
        private System.Windows.Forms.TextBox textWkshpDesc;
        private System.Windows.Forms.Label labelWkshpConf;
        private System.Windows.Forms.ComboBox comboWkshpConf;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textDateD;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.TextBox textDateM;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.TextBox textStartTime1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStartTime2;
        private System.Windows.Forms.Label labelIntVal;
        private System.Windows.Forms.ComboBox comboAMPM;
        private System.Windows.Forms.Button buttonAdd;
    }
}