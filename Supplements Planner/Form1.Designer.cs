namespace supplements_planner
{
    partial class Form1
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
            this.prodInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.destListbox = new System.Windows.Forms.ListBox();
            this.sourceTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.destDropdown = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_DST = new System.Windows.Forms.Button();
            this.but_LEF = new System.Windows.Forms.Button();
            this.but_DRS = new System.Windows.Forms.Button();
            this.but_VSF = new System.Windows.Forms.Button();
            this.but_DHS = new System.Windows.Forms.Button();
            this.but_AAS = new System.Windows.Forms.Button();
            this.but_RAM = new System.Windows.Forms.Button();
            this.but_FRD = new System.Windows.Forms.Button();
            this.but_VAF = new System.Windows.Forms.Button();
            this.but_HOF = new System.Windows.Forms.Button();
            this.but_JVE = new System.Windows.Forms.Button();
            this.but_FAA = new System.Windows.Forms.Button();
            this.but_FST = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.sourceDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSupplements = new System.Windows.Forms.TabPage();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.downloadFilerTextBox = new System.Windows.Forms.TextBox();
            this.downloadTreeView = new System.Windows.Forms.TreeView();
            this.tabUpload = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSupplements.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // prodInput
            // 
            this.prodInput.Location = new System.Drawing.Point(9, 19);
            this.prodInput.Name = "prodInput";
            this.prodInput.Size = new System.Drawing.Size(50, 20);
            this.prodInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // zoneInput
            // 
            this.zoneInput.Location = new System.Drawing.Point(65, 19);
            this.zoneInput.Name = "zoneInput";
            this.zoneInput.Size = new System.Drawing.Size(45, 20);
            this.zoneInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Destinations";
            // 
            // destListbox
            // 
            this.destListbox.FormattingEnabled = true;
            this.destListbox.Location = new System.Drawing.Point(9, 124);
            this.destListbox.Name = "destListbox";
            this.destListbox.Size = new System.Drawing.Size(401, 290);
            this.destListbox.TabIndex = 6;
            this.destListbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.destListbox_KeyDown);
            // 
            // sourceTitle
            // 
            this.sourceTitle.Location = new System.Drawing.Point(201, 19);
            this.sourceTitle.Name = "sourceTitle";
            this.sourceTitle.Size = new System.Drawing.Size(209, 20);
            this.sourceTitle.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Title";
            // 
            // destDropdown
            // 
            this.destDropdown.FormattingEnabled = true;
            this.destDropdown.Location = new System.Drawing.Point(9, 68);
            this.destDropdown.Name = "destDropdown";
            this.destDropdown.Size = new System.Drawing.Size(401, 21);
            this.destDropdown.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(9, 95);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(335, 512);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_DST);
            this.groupBox1.Controls.Add(this.but_LEF);
            this.groupBox1.Controls.Add(this.but_DRS);
            this.groupBox1.Controls.Add(this.but_VSF);
            this.groupBox1.Controls.Add(this.but_DHS);
            this.groupBox1.Controls.Add(this.but_AAS);
            this.groupBox1.Controls.Add(this.but_RAM);
            this.groupBox1.Controls.Add(this.but_FRD);
            this.groupBox1.Controls.Add(this.but_VAF);
            this.groupBox1.Controls.Add(this.but_HOF);
            this.groupBox1.Controls.Add(this.but_JVE);
            this.groupBox1.Controls.Add(this.but_FAA);
            this.groupBox1.Controls.Add(this.but_FST);
            this.groupBox1.Location = new System.Drawing.Point(9, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination shortcuts";
            // 
            // but_DST
            // 
            this.but_DST.Location = new System.Drawing.Point(342, 45);
            this.but_DST.Name = "but_DST";
            this.but_DST.Size = new System.Drawing.Size(50, 20);
            this.but_DST.TabIndex = 12;
            this.but_DST.Text = "DST";
            this.but_DST.UseVisualStyleBackColor = true;
            this.but_DST.Click += new System.EventHandler(this.but_DST_Click);
            // 
            // but_LEF
            // 
            this.but_LEF.Location = new System.Drawing.Point(286, 45);
            this.but_LEF.Name = "but_LEF";
            this.but_LEF.Size = new System.Drawing.Size(50, 20);
            this.but_LEF.TabIndex = 11;
            this.but_LEF.Text = "LEF";
            this.but_LEF.UseVisualStyleBackColor = true;
            this.but_LEF.Click += new System.EventHandler(this.but_LEF_Click);
            // 
            // but_DRS
            // 
            this.but_DRS.Location = new System.Drawing.Point(230, 45);
            this.but_DRS.Name = "but_DRS";
            this.but_DRS.Size = new System.Drawing.Size(50, 20);
            this.but_DRS.TabIndex = 10;
            this.but_DRS.Text = "DRS";
            this.but_DRS.UseVisualStyleBackColor = true;
            this.but_DRS.Click += new System.EventHandler(this.but_DRS_Click);
            // 
            // but_VSF
            // 
            this.but_VSF.Location = new System.Drawing.Point(174, 45);
            this.but_VSF.Name = "but_VSF";
            this.but_VSF.Size = new System.Drawing.Size(50, 20);
            this.but_VSF.TabIndex = 9;
            this.but_VSF.Text = "VSF";
            this.but_VSF.UseVisualStyleBackColor = true;
            this.but_VSF.Click += new System.EventHandler(this.but_VSF_Click);
            // 
            // but_DHS
            // 
            this.but_DHS.Location = new System.Drawing.Point(118, 45);
            this.but_DHS.Name = "but_DHS";
            this.but_DHS.Size = new System.Drawing.Size(50, 20);
            this.but_DHS.TabIndex = 8;
            this.but_DHS.Text = "DHS";
            this.but_DHS.UseVisualStyleBackColor = true;
            this.but_DHS.Click += new System.EventHandler(this.but_DHS_Click);
            // 
            // but_AAS
            // 
            this.but_AAS.Location = new System.Drawing.Point(62, 45);
            this.but_AAS.Name = "but_AAS";
            this.but_AAS.Size = new System.Drawing.Size(50, 20);
            this.but_AAS.TabIndex = 7;
            this.but_AAS.Text = "AAS";
            this.but_AAS.UseVisualStyleBackColor = true;
            this.but_AAS.Click += new System.EventHandler(this.but_AAS_Click);
            // 
            // but_RAM
            // 
            this.but_RAM.Location = new System.Drawing.Point(6, 45);
            this.but_RAM.Name = "but_RAM";
            this.but_RAM.Size = new System.Drawing.Size(50, 20);
            this.but_RAM.TabIndex = 6;
            this.but_RAM.Text = "RAM";
            this.but_RAM.UseVisualStyleBackColor = true;
            this.but_RAM.Click += new System.EventHandler(this.but_RAM_Click);
            // 
            // but_FRD
            // 
            this.but_FRD.Location = new System.Drawing.Point(286, 19);
            this.but_FRD.Name = "but_FRD";
            this.but_FRD.Size = new System.Drawing.Size(50, 20);
            this.but_FRD.TabIndex = 5;
            this.but_FRD.Text = "FRD";
            this.but_FRD.UseVisualStyleBackColor = true;
            this.but_FRD.Click += new System.EventHandler(this.but_FRD_Click);
            // 
            // but_VAF
            // 
            this.but_VAF.Location = new System.Drawing.Point(230, 19);
            this.but_VAF.Name = "but_VAF";
            this.but_VAF.Size = new System.Drawing.Size(50, 20);
            this.but_VAF.TabIndex = 4;
            this.but_VAF.Text = "VAF";
            this.but_VAF.UseVisualStyleBackColor = true;
            this.but_VAF.Click += new System.EventHandler(this.but_VAF_Click);
            // 
            // but_HOF
            // 
            this.but_HOF.Location = new System.Drawing.Point(174, 19);
            this.but_HOF.Name = "but_HOF";
            this.but_HOF.Size = new System.Drawing.Size(50, 20);
            this.but_HOF.TabIndex = 3;
            this.but_HOF.Text = "HOF";
            this.but_HOF.UseVisualStyleBackColor = true;
            this.but_HOF.Click += new System.EventHandler(this.but_HOF_Click);
            // 
            // but_JVE
            // 
            this.but_JVE.Location = new System.Drawing.Point(118, 19);
            this.but_JVE.Name = "but_JVE";
            this.but_JVE.Size = new System.Drawing.Size(50, 20);
            this.but_JVE.TabIndex = 2;
            this.but_JVE.Text = "JVE";
            this.but_JVE.UseVisualStyleBackColor = true;
            this.but_JVE.Click += new System.EventHandler(this.but_JVE_Click);
            // 
            // but_FAA
            // 
            this.but_FAA.Location = new System.Drawing.Point(62, 19);
            this.but_FAA.Name = "but_FAA";
            this.but_FAA.Size = new System.Drawing.Size(50, 20);
            this.but_FAA.TabIndex = 1;
            this.but_FAA.Text = "FAA";
            this.but_FAA.UseVisualStyleBackColor = true;
            this.but_FAA.Click += new System.EventHandler(this.but_FAA_Click);
            // 
            // but_FST
            // 
            this.but_FST.Location = new System.Drawing.Point(6, 19);
            this.but_FST.Name = "but_FST";
            this.but_FST.Size = new System.Drawing.Size(50, 20);
            this.but_FST.TabIndex = 0;
            this.but_FST.Text = "FST";
            this.but_FST.UseVisualStyleBackColor = true;
            this.but_FST.Click += new System.EventHandler(this.but_FST_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(90, 95);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sourceDate
            // 
            this.sourceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sourceDate.Location = new System.Drawing.Point(116, 19);
            this.sourceDate.Name = "sourceDate";
            this.sourceDate.Size = new System.Drawing.Size(79, 20);
            this.sourceDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSupplements);
            this.tabControl1.Controls.Add(this.tabDownload);
            this.tabControl1.Controls.Add(this.tabUpload);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 574);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabSupplements
            // 
            this.tabSupplements.Controls.Add(this.label1);
            this.tabSupplements.Controls.Add(this.label5);
            this.tabSupplements.Controls.Add(this.prodInput);
            this.tabSupplements.Controls.Add(this.sourceDate);
            this.tabSupplements.Controls.Add(this.zoneInput);
            this.tabSupplements.Controls.Add(this.clearButton);
            this.tabSupplements.Controls.Add(this.label2);
            this.tabSupplements.Controls.Add(this.groupBox1);
            this.tabSupplements.Controls.Add(this.label3);
            this.tabSupplements.Controls.Add(this.sendButton);
            this.tabSupplements.Controls.Add(this.destListbox);
            this.tabSupplements.Controls.Add(this.addButton);
            this.tabSupplements.Controls.Add(this.sourceTitle);
            this.tabSupplements.Controls.Add(this.destDropdown);
            this.tabSupplements.Controls.Add(this.label4);
            this.tabSupplements.Location = new System.Drawing.Point(4, 22);
            this.tabSupplements.Name = "tabSupplements";
            this.tabSupplements.Padding = new System.Windows.Forms.Padding(3);
            this.tabSupplements.Size = new System.Drawing.Size(421, 548);
            this.tabSupplements.TabIndex = 0;
            this.tabSupplements.Text = "Supplements";
            this.tabSupplements.UseVisualStyleBackColor = true;
            // 
            // tabDownload
            // 
            this.tabDownload.Controls.Add(this.downloadButton);
            this.tabDownload.Controls.Add(this.label6);
            this.tabDownload.Controls.Add(this.downloadFilerTextBox);
            this.tabDownload.Controls.Add(this.downloadTreeView);
            this.tabDownload.Location = new System.Drawing.Point(4, 22);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownload.Size = new System.Drawing.Size(421, 548);
            this.tabDownload.TabIndex = 1;
            this.tabDownload.Text = "Download";
            this.tabDownload.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(340, 519);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filter";
            // 
            // downloadFilerTextBox
            // 
            this.downloadFilerTextBox.Location = new System.Drawing.Point(6, 522);
            this.downloadFilerTextBox.Name = "downloadFilerTextBox";
            this.downloadFilerTextBox.Size = new System.Drawing.Size(240, 20);
            this.downloadFilerTextBox.TabIndex = 1;
            // 
            // downloadTreeView
            // 
            this.downloadTreeView.Location = new System.Drawing.Point(6, 6);
            this.downloadTreeView.Name = "downloadTreeView";
            this.downloadTreeView.Size = new System.Drawing.Size(409, 477);
            this.downloadTreeView.TabIndex = 0;
            // 
            // tabUpload
            // 
            this.tabUpload.Location = new System.Drawing.Point(4, 22);
            this.tabUpload.Name = "tabUpload";
            this.tabUpload.Size = new System.Drawing.Size(421, 548);
            this.tabUpload.TabIndex = 2;
            this.tabUpload.Text = "Upload";
            this.tabUpload.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 592);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Supplements Planner";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSupplements.ResumeLayout(false);
            this.tabSupplements.PerformLayout();
            this.tabDownload.ResumeLayout(false);
            this.tabDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox prodInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zoneInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox destListbox;
        private System.Windows.Forms.TextBox sourceTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox destDropdown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_DST;
        private System.Windows.Forms.Button but_LEF;
        private System.Windows.Forms.Button but_DRS;
        private System.Windows.Forms.Button but_VSF;
        private System.Windows.Forms.Button but_DHS;
        private System.Windows.Forms.Button but_AAS;
        private System.Windows.Forms.Button but_RAM;
        private System.Windows.Forms.Button but_FRD;
        private System.Windows.Forms.Button but_VAF;
        private System.Windows.Forms.Button but_HOF;
        private System.Windows.Forms.Button but_JVE;
        private System.Windows.Forms.Button but_FAA;
        private System.Windows.Forms.Button but_FST;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DateTimePicker sourceDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSupplements;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.TabPage tabUpload;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox downloadFilerTextBox;
        private System.Windows.Forms.TreeView downloadTreeView;
    }
}

