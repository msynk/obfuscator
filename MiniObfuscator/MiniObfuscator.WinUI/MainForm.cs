using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MiniObfuscator.Core;
using MiniObfuscator.Core.Enums;

namespace MiniObfuscator.WinUI
{
  public class MainForm : Form
  {
    private OptionsForm _optionsForm;

    #region MainForm

    public MainForm()
    {
      InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    #region Controls

    private TextBox txtAssembly;
    private Button btnObfuscateIt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private TextBox txtOutputPath;
    private System.Windows.Forms.Label label3;
    private TextBox txtStrongNameKeyFilePath;
    private Button btnBrowseAssembly;
    private Button btnBrowseOutputFolder;
    private Button btnBrowseStrongNameKeyFile;
    private RichTextBox rtbResults;
    private Button btnSetOptions;
    private Label label4;
    private TextBox txtStrongNameKeyFilePassword;
    private Container components;

    #endregion

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtAssembly = new System.Windows.Forms.TextBox();
      this.btnObfuscateIt = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtOutputPath = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtStrongNameKeyFilePath = new System.Windows.Forms.TextBox();
      this.btnBrowseAssembly = new System.Windows.Forms.Button();
      this.btnBrowseOutputFolder = new System.Windows.Forms.Button();
      this.btnBrowseStrongNameKeyFile = new System.Windows.Forms.Button();
      this.rtbResults = new System.Windows.Forms.RichTextBox();
      this.btnSetOptions = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.txtStrongNameKeyFilePassword = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtAssembly
      // 
      this.txtAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtAssembly.BackColor = System.Drawing.SystemColors.HighlightText;
      this.txtAssembly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtAssembly.Location = new System.Drawing.Point(127, 7);
      this.txtAssembly.Name = "txtAssembly";
      this.txtAssembly.Size = new System.Drawing.Size(397, 20);
      this.txtAssembly.TabIndex = 1;
      // 
      // btnObfuscateIt
      // 
      this.btnObfuscateIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnObfuscateIt.BackColor = System.Drawing.SystemColors.Control;
      this.btnObfuscateIt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnObfuscateIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
      this.btnObfuscateIt.Location = new System.Drawing.Point(565, 7);
      this.btnObfuscateIt.Name = "btnObfuscateIt";
      this.btnObfuscateIt.Size = new System.Drawing.Size(100, 75);
      this.btnObfuscateIt.TabIndex = 0;
      this.btnObfuscateIt.Text = "Obfuscate";
      this.btnObfuscateIt.UseVisualStyleBackColor = false;
      this.btnObfuscateIt.Click += new System.EventHandler(this.btnObfuscateIt_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(10, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "*Assembly:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(10, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "*Output folder:";
      // 
      // txtOutputPath
      // 
      this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtOutputPath.BackColor = System.Drawing.SystemColors.HighlightText;
      this.txtOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtOutputPath.Location = new System.Drawing.Point(127, 34);
      this.txtOutputPath.Name = "txtOutputPath";
      this.txtOutputPath.Size = new System.Drawing.Size(397, 20);
      this.txtOutputPath.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(10, 65);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(109, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Strong Name Key file:";
      // 
      // txtStrongNameKeyFilePath
      // 
      this.txtStrongNameKeyFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtStrongNameKeyFilePath.BackColor = System.Drawing.SystemColors.HighlightText;
      this.txtStrongNameKeyFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtStrongNameKeyFilePath.Location = new System.Drawing.Point(127, 61);
      this.txtStrongNameKeyFilePath.Name = "txtStrongNameKeyFilePath";
      this.txtStrongNameKeyFilePath.Size = new System.Drawing.Size(397, 20);
      this.txtStrongNameKeyFilePath.TabIndex = 3;
      // 
      // btnBrowseAssembly
      // 
      this.btnBrowseAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowseAssembly.BackColor = System.Drawing.SystemColors.Control;
      this.btnBrowseAssembly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBrowseAssembly.Location = new System.Drawing.Point(530, 7);
      this.btnBrowseAssembly.Name = "btnBrowseAssembly";
      this.btnBrowseAssembly.Size = new System.Drawing.Size(26, 21);
      this.btnBrowseAssembly.TabIndex = 8;
      this.btnBrowseAssembly.Text = "...";
      this.btnBrowseAssembly.UseVisualStyleBackColor = false;
      this.btnBrowseAssembly.Click += new System.EventHandler(this.btnBrowseAssembly_Click);
      // 
      // btnBrowseOutputFolder
      // 
      this.btnBrowseOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowseOutputFolder.BackColor = System.Drawing.SystemColors.Control;
      this.btnBrowseOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBrowseOutputFolder.Location = new System.Drawing.Point(530, 34);
      this.btnBrowseOutputFolder.Name = "btnBrowseOutputFolder";
      this.btnBrowseOutputFolder.Size = new System.Drawing.Size(26, 21);
      this.btnBrowseOutputFolder.TabIndex = 9;
      this.btnBrowseOutputFolder.Text = "...";
      this.btnBrowseOutputFolder.UseVisualStyleBackColor = false;
      this.btnBrowseOutputFolder.Click += new System.EventHandler(this.btnBrowseOutputFolder_Click);
      // 
      // btnBrowseStrongNameKeyFile
      // 
      this.btnBrowseStrongNameKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnBrowseStrongNameKeyFile.BackColor = System.Drawing.SystemColors.Control;
      this.btnBrowseStrongNameKeyFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBrowseStrongNameKeyFile.Location = new System.Drawing.Point(530, 61);
      this.btnBrowseStrongNameKeyFile.Name = "btnBrowseStrongNameKeyFile";
      this.btnBrowseStrongNameKeyFile.Size = new System.Drawing.Size(26, 21);
      this.btnBrowseStrongNameKeyFile.TabIndex = 10;
      this.btnBrowseStrongNameKeyFile.Text = "...";
      this.btnBrowseStrongNameKeyFile.UseVisualStyleBackColor = false;
      this.btnBrowseStrongNameKeyFile.Click += new System.EventHandler(this.btnBrowseStrongNameKeyFile_Click);
      // 
      // rtbResults
      // 
      this.rtbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtbResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.rtbResults.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.rtbResults.Location = new System.Drawing.Point(3, 113);
      this.rtbResults.Name = "rtbResults";
      this.rtbResults.Size = new System.Drawing.Size(731, 252);
      this.rtbResults.TabIndex = 11;
      this.rtbResults.Text = "";
      this.rtbResults.WordWrap = false;
      // 
      // btnSetOptions
      // 
      this.btnSetOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSetOptions.Location = new System.Drawing.Point(671, 7);
      this.btnSetOptions.Name = "btnSetOptions";
      this.btnSetOptions.Size = new System.Drawing.Size(63, 48);
      this.btnSetOptions.TabIndex = 12;
      this.btnSetOptions.Text = "Set Options";
      this.btnSetOptions.UseVisualStyleBackColor = false;
      this.btnSetOptions.Click += new System.EventHandler(this.btnSetOptions_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(10, 91);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(110, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "SN Key file password:";
      // 
      // txtStrongNameKeyFilePassword
      // 
      this.txtStrongNameKeyFilePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtStrongNameKeyFilePassword.BackColor = System.Drawing.SystemColors.HighlightText;
      this.txtStrongNameKeyFilePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtStrongNameKeyFilePassword.Location = new System.Drawing.Point(127, 87);
      this.txtStrongNameKeyFilePassword.Name = "txtStrongNameKeyFilePassword";
      this.txtStrongNameKeyFilePassword.Size = new System.Drawing.Size(397, 20);
      this.txtStrongNameKeyFilePassword.TabIndex = 14;
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(738, 366);
      this.Controls.Add(this.txtStrongNameKeyFilePassword);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnSetOptions);
      this.Controls.Add(this.rtbResults);
      this.Controls.Add(this.btnBrowseStrongNameKeyFile);
      this.Controls.Add(this.btnBrowseOutputFolder);
      this.Controls.Add(this.btnBrowseAssembly);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtStrongNameKeyFilePath);
      this.Controls.Add(this.txtOutputPath);
      this.Controls.Add(this.btnObfuscateIt);
      this.Controls.Add(this.txtAssembly);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MiniObfuscator";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    #endregion

    private void btnObfuscateIt_Click(object sender, EventArgs e)
    {
      try
      {
        Enabled = false;
        Application.DoEvents();

        Obfuscate();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
      finally
      {
        Enabled = true;
        Application.DoEvents();
      }
    }

    private void btnBrowseAssembly_Click(object sender, EventArgs e)
    {
      var ofd = new OpenFileDialog
      {
        Title = "Select assembly for obfuscation",
        Filter = "Executables(*.exe;*.dll)|*.exe;*.dll|All files (*.*)|*.*",
        FilterIndex = 1,
        InitialDirectory = Directory.GetCurrentDirectory()
      };
      txtAssembly.Text = (ofd.ShowDialog(this) == DialogResult.OK) ? ofd.FileName : string.Empty;
      if (txtAssembly.Text != string.Empty)
        txtOutputPath.Text = Path.Combine(Path.GetDirectoryName(txtAssembly.Text), "Obfuscated");
    }

    private void btnBrowseOutputFolder_Click(object sender, EventArgs e)
    {
      var bfd = new FolderBrowserDialog
      {
        Description = "Select the folder to save obfuscated assembly",
        SelectedPath = Directory.GetCurrentDirectory(),
        ShowNewFolderButton = true
      };
      txtOutputPath.Text = (bfd.ShowDialog(this) == DialogResult.OK) ? bfd.SelectedPath : string.Empty;
    }

    private void btnBrowseStrongNameKeyFile_Click(object sender, EventArgs e)
    {
      var ofd = new OpenFileDialog
      {
        Title = "Select strong name key file to resign assembly after obfuscation",
        Filter = "Strong name key files(*.snk)|*.snk|All files (*.*)|*.*",
        FilterIndex = 1,
        InitialDirectory = Directory.GetCurrentDirectory()
      };
      txtStrongNameKeyFilePath.Text = (ofd.ShowDialog(this) == DialogResult.OK) ? ofd.FileName : string.Empty;
    }

    private void btnSetOptions_Click(object sender, EventArgs e)
    {
      _optionsForm = new OptionsForm();
      _optionsForm.ShowDialog();
    }




    private void Obfuscate()
    {
      if (txtAssembly.Text != string.Empty && File.Exists(txtAssembly.Text))
      {
        var obfuscatorSettings = GenerateObfuscateSettings();
        var obfuscator = new Obfuscator(obfuscatorSettings);
        MessageBox.Show(obfuscator.Obfuscate() ? "Obfuscate succeded" : "Obfuscate failed", "Obfuscate results");
      }
      else
      {
        rtbResults.Text += "Select an assembly" + Environment.NewLine;
      }
    }

    private ObfuscatorSettings GenerateObfuscateSettings()
    {
      var obfuscatorSettings = new ObfuscatorSettings
      {
        CheckConsistencyBeforeObfuscation = false,
        VerifyAfterObfuscation = YesNoPrompt.No,
        OutputPath = txtOutputPath.Text,
        StripDebugInfo = true,
        StrongNameKeyFilePath = txtStrongNameKeyFilePath.Text,
        StrongNameKeyFilePassword = txtStrongNameKeyFilePassword.Text
      };
      obfuscatorSettings.AddAssembly(txtAssembly.Text);
      if (_optionsForm != null && _optionsForm.Options != null)
      {
        obfuscatorSettings.ObfuscateOptions = _optionsForm.Options;
      }
      obfuscatorSettings.ObfuscateLoggerSettings = GenerateLoggerSettings();
      return obfuscatorSettings;
    }

    private ObfuscateLoggerSettings GenerateLoggerSettings()
    {
      return new ObfuscateLoggerSettings
      {
        IsRtf = true,
        Clear = Clear,
        Add = Add,
        AddFormatted = AddFormatted,
        Font = rtbResults.Font
      };
    }

    private void Clear()
    {
      rtbResults.Text = string.Empty;
    }

    private void Add(string msg)
    {
      if (string.IsNullOrEmpty(msg)) return;
      rtbResults.Text += msg;
      Application.DoEvents();
    }

    private void AddFormatted(string text, Color textColor)
    {
      Add(text);
      rtbResults.Select(int.MaxValue, 0);
      rtbResults.SelectionColor = textColor;
      rtbResults.SelectedText = text;
      rtbResults.Select(int.MaxValue, 0);
      rtbResults.SelectionColor = rtbResults.ForeColor;
    }
  }
}
