namespace MiniObfuscator.WinUI
{
    partial class OptionsForm
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
      this.clbAnonymizeOptions = new System.Windows.Forms.CheckedListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.clbMembers = new System.Windows.Forms.CheckedListBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.clbResourceProtectionMode = new System.Windows.Forms.CheckedListBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.lbNaming = new System.Windows.Forms.ListBox();
      this.lbNamespacesRestructuring = new System.Windows.Forms.ListBox();
      this.lbAntiILDASMOptions = new System.Windows.Forms.ListBox();
      this.lbStringEncryptionMode = new System.Windows.Forms.ListBox();
      this.txtDescription = new System.Windows.Forms.TextBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCustomDictionary = new System.Windows.Forms.TextBox();
      this.cbIncrementalObfuscation = new System.Windows.Forms.CheckBox();
      this.cbMixDictionary = new System.Windows.Forms.CheckBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtSoftwareWatermark = new System.Windows.Forms.TextBox();
      this.cbUniqueNames = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // clbAnonymizeOptions
      // 
      this.clbAnonymizeOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.clbAnonymizeOptions.CheckOnClick = true;
      this.clbAnonymizeOptions.FormattingEnabled = true;
      this.clbAnonymizeOptions.Location = new System.Drawing.Point(168, 266);
      this.clbAnonymizeOptions.Name = "clbAnonymizeOptions";
      this.clbAnonymizeOptions.Size = new System.Drawing.Size(150, 197);
      this.clbAnonymizeOptions.TabIndex = 0;
      this.clbAnonymizeOptions.SelectedIndexChanged += new System.EventHandler(this.clbAnonymizeOptions_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(165, 249);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Anonymize Options:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(165, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(107, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "AntiILDASM Options:";
      // 
      // clbMembers
      // 
      this.clbMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.clbMembers.CheckOnClick = true;
      this.clbMembers.FormattingEnabled = true;
      this.clbMembers.HorizontalScrollbar = true;
      this.clbMembers.Location = new System.Drawing.Point(12, 266);
      this.clbMembers.Name = "clbMembers";
      this.clbMembers.Size = new System.Drawing.Size(150, 197);
      this.clbMembers.TabIndex = 2;
      this.clbMembers.SelectedIndexChanged += new System.EventHandler(this.clbMembers_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 249);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Members:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(321, 8);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(138, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Namespaces Restructuring:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(9, 8);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(46, 13);
      this.label8.TabIndex = 3;
      this.label8.Text = "Naming:";
      // 
      // clbResourceProtectionMode
      // 
      this.clbResourceProtectionMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.clbResourceProtectionMode.CheckOnClick = true;
      this.clbResourceProtectionMode.FormattingEnabled = true;
      this.clbResourceProtectionMode.Location = new System.Drawing.Point(324, 266);
      this.clbResourceProtectionMode.Name = "clbResourceProtectionMode";
      this.clbResourceProtectionMode.Size = new System.Drawing.Size(150, 197);
      this.clbResourceProtectionMode.TabIndex = 2;
      this.clbResourceProtectionMode.SelectedIndexChanged += new System.EventHandler(this.clbResourceProtectionMode_SelectedIndexChanged);
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(321, 249);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(137, 13);
      this.label10.TabIndex = 3;
      this.label10.Text = "Resource Protection Mode:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(477, 8);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(120, 13);
      this.label11.TabIndex = 3;
      this.label11.Text = "String Encryption Mode:";
      // 
      // lbNaming
      // 
      this.lbNaming.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbNaming.FormattingEnabled = true;
      this.lbNaming.Location = new System.Drawing.Point(12, 24);
      this.lbNaming.Name = "lbNaming";
      this.lbNaming.Size = new System.Drawing.Size(150, 197);
      this.lbNaming.TabIndex = 4;
      this.lbNaming.SelectedIndexChanged += new System.EventHandler(this.lbNaming_SelectedIndexChanged);
      // 
      // lbNamespacesRestructuring
      // 
      this.lbNamespacesRestructuring.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbNamespacesRestructuring.FormattingEnabled = true;
      this.lbNamespacesRestructuring.Location = new System.Drawing.Point(324, 24);
      this.lbNamespacesRestructuring.Name = "lbNamespacesRestructuring";
      this.lbNamespacesRestructuring.Size = new System.Drawing.Size(150, 197);
      this.lbNamespacesRestructuring.TabIndex = 4;
      this.lbNamespacesRestructuring.SelectedIndexChanged += new System.EventHandler(this.lbNamespacesRestructuring_SelectedIndexChanged);
      // 
      // lbAntiILDASMOptions
      // 
      this.lbAntiILDASMOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbAntiILDASMOptions.FormattingEnabled = true;
      this.lbAntiILDASMOptions.Location = new System.Drawing.Point(168, 24);
      this.lbAntiILDASMOptions.Name = "lbAntiILDASMOptions";
      this.lbAntiILDASMOptions.Size = new System.Drawing.Size(150, 197);
      this.lbAntiILDASMOptions.TabIndex = 4;
      this.lbAntiILDASMOptions.SelectedIndexChanged += new System.EventHandler(this.lbAntiILDASMOptions_SelectedIndexChanged);
      // 
      // lbStringEncryptionMode
      // 
      this.lbStringEncryptionMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbStringEncryptionMode.FormattingEnabled = true;
      this.lbStringEncryptionMode.Location = new System.Drawing.Point(480, 24);
      this.lbStringEncryptionMode.Name = "lbStringEncryptionMode";
      this.lbStringEncryptionMode.Size = new System.Drawing.Size(150, 197);
      this.lbStringEncryptionMode.TabIndex = 4;
      this.lbStringEncryptionMode.SelectedIndexChanged += new System.EventHandler(this.lbStringEncryptionMode_SelectedIndexChanged);
      // 
      // txtDescription
      // 
      this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtDescription.Location = new System.Drawing.Point(12, 471);
      this.txtDescription.Multiline = true;
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.ReadOnly = true;
      this.txtDescription.Size = new System.Drawing.Size(621, 42);
      this.txtDescription.TabIndex = 5;
      // 
      // btnSave
      // 
      this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSave.Location = new System.Drawing.Point(533, 442);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(100, 23);
      this.btnSave.TabIndex = 6;
      this.btnSave.Text = "Save && Close";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(477, 266);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Custom Dictionary :";
      // 
      // txtCustomDictionary
      // 
      this.txtCustomDictionary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtCustomDictionary.Location = new System.Drawing.Point(480, 282);
      this.txtCustomDictionary.Name = "txtCustomDictionary";
      this.txtCustomDictionary.Size = new System.Drawing.Size(150, 20);
      this.txtCustomDictionary.TabIndex = 8;
      // 
      // cbIncrementalObfuscation
      // 
      this.cbIncrementalObfuscation.AutoSize = true;
      this.cbIncrementalObfuscation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbIncrementalObfuscation.Location = new System.Drawing.Point(480, 370);
      this.cbIncrementalObfuscation.Name = "cbIncrementalObfuscation";
      this.cbIncrementalObfuscation.Size = new System.Drawing.Size(138, 17);
      this.cbIncrementalObfuscation.TabIndex = 9;
      this.cbIncrementalObfuscation.Text = "Incremental Obfuscation";
      this.cbIncrementalObfuscation.UseVisualStyleBackColor = true;
      // 
      // cbMixDictionary
      // 
      this.cbMixDictionary.AutoSize = true;
      this.cbMixDictionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbMixDictionary.Location = new System.Drawing.Point(480, 393);
      this.cbMixDictionary.Name = "cbMixDictionary";
      this.cbMixDictionary.Size = new System.Drawing.Size(89, 17);
      this.cbMixDictionary.TabIndex = 9;
      this.cbMixDictionary.Text = "Mix Dictionary";
      this.cbMixDictionary.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(477, 316);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(110, 13);
      this.label5.TabIndex = 7;
      this.label5.Text = "Software Watermark :";
      // 
      // txtSoftwareWatermark
      // 
      this.txtSoftwareWatermark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtSoftwareWatermark.Location = new System.Drawing.Point(480, 332);
      this.txtSoftwareWatermark.Name = "txtSoftwareWatermark";
      this.txtSoftwareWatermark.Size = new System.Drawing.Size(150, 20);
      this.txtSoftwareWatermark.TabIndex = 8;
      // 
      // cbUniqueNames
      // 
      this.cbUniqueNames.AutoSize = true;
      this.cbUniqueNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbUniqueNames.Location = new System.Drawing.Point(480, 416);
      this.cbUniqueNames.Name = "cbUniqueNames";
      this.cbUniqueNames.Size = new System.Drawing.Size(93, 17);
      this.cbUniqueNames.TabIndex = 9;
      this.cbUniqueNames.Text = "Unique Names";
      this.cbUniqueNames.UseVisualStyleBackColor = true;
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(641, 525);
      this.Controls.Add(this.cbUniqueNames);
      this.Controls.Add(this.cbMixDictionary);
      this.Controls.Add(this.cbIncrementalObfuscation);
      this.Controls.Add(this.txtSoftwareWatermark);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCustomDictionary);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtDescription);
      this.Controls.Add(this.lbNamespacesRestructuring);
      this.Controls.Add(this.lbStringEncryptionMode);
      this.Controls.Add(this.lbAntiILDASMOptions);
      this.Controls.Add(this.lbNaming);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.clbResourceProtectionMode);
      this.Controls.Add(this.clbMembers);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.clbAnonymizeOptions);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "OptionsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Options";
      this.Load += new System.EventHandler(this.OptionsForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbAnonymizeOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbResourceProtectionMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbNaming;
        private System.Windows.Forms.ListBox lbNamespacesRestructuring;
        private System.Windows.Forms.ListBox lbAntiILDASMOptions;
        private System.Windows.Forms.ListBox lbStringEncryptionMode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomDictionary;
        private System.Windows.Forms.CheckBox cbIncrementalObfuscation;
        private System.Windows.Forms.CheckBox cbMixDictionary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoftwareWatermark;
        private System.Windows.Forms.CheckBox cbUniqueNames;

    }
}