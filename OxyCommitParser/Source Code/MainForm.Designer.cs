namespace OxyCommitParser
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.gbRemote = new System.Windows.Forms.GroupBox();
			this.LastReleaseName = new System.Windows.Forms.Label();
			this.SysLastReleaseName = new System.Windows.Forms.Label();
			this.rcommitAuthor = new System.Windows.Forms.Label();
			this.SysAuthor1 = new System.Windows.Forms.Label();
			this.rcommiteeAvatar = new System.Windows.Forms.PictureBox();
			this.rcommitDate = new System.Windows.Forms.Label();
			this.rcommitText = new System.Windows.Forms.Label();
			this.gbLocal = new System.Windows.Forms.GroupBox();
			this.lcommitAuthor = new System.Windows.Forms.Label();
			this.SysAuthor2 = new System.Windows.Forms.Label();
			this.lcommitText = new System.Windows.Forms.Label();
			this.lcommiteeAvatar = new System.Windows.Forms.PictureBox();
			this.lcommitDate = new System.Windows.Forms.Label();
			this.bCheck = new System.Windows.Forms.Button();
			this.searchCoreDialog = new System.Windows.Forms.OpenFileDialog();
			this.pbUpdate = new System.Windows.Forms.ProgressBar();
			this.gbSettings = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.cbRememberPath = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.exitLabel = new System.Windows.Forms.Label();
			this.minimazeLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.gbRemote.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rcommiteeAvatar)).BeginInit();
			this.gbLocal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lcommiteeAvatar)).BeginInit();
			this.gbSettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbRemote
			// 
			this.gbRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbRemote.BackColor = System.Drawing.Color.Transparent;
			this.gbRemote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRemote.BackgroundImage")));
			this.gbRemote.Controls.Add(this.LastReleaseName);
			this.gbRemote.Controls.Add(this.SysLastReleaseName);
			this.gbRemote.Controls.Add(this.rcommitAuthor);
			this.gbRemote.Controls.Add(this.SysAuthor1);
			this.gbRemote.Controls.Add(this.rcommiteeAvatar);
			this.gbRemote.Controls.Add(this.rcommitDate);
			this.gbRemote.Controls.Add(this.rcommitText);
			this.gbRemote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbRemote.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.gbRemote.Location = new System.Drawing.Point(607, 41);
			this.gbRemote.Name = "gbRemote";
			this.gbRemote.Size = new System.Drawing.Size(400, 108);
			this.gbRemote.TabIndex = 0;
			this.gbRemote.TabStop = false;
			this.gbRemote.Text = "Last release ";
			// 
			// LastReleaseName
			// 
			this.LastReleaseName.AutoSize = true;
			this.LastReleaseName.BackColor = System.Drawing.Color.Transparent;
			this.LastReleaseName.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.LastReleaseName.Location = new System.Drawing.Point(47, 79);
			this.LastReleaseName.Name = "LastReleaseName";
			this.LastReleaseName.Size = new System.Drawing.Size(50, 13);
			this.LastReleaseName.TabIndex = 14;
			this.LastReleaseName.Text = "No name";
			// 
			// SysLastReleaseName
			// 
			this.SysLastReleaseName.AutoSize = true;
			this.SysLastReleaseName.BackColor = System.Drawing.Color.Transparent;
			this.SysLastReleaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SysLastReleaseName.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.SysLastReleaseName.Location = new System.Drawing.Point(4, 79);
			this.SysLastReleaseName.Name = "SysLastReleaseName";
			this.SysLastReleaseName.Size = new System.Drawing.Size(43, 13);
			this.SysLastReleaseName.TabIndex = 13;
			this.SysLastReleaseName.Text = "Name:";
			// 
			// rcommitAuthor
			// 
			this.rcommitAuthor.AutoSize = true;
			this.rcommitAuthor.BackColor = System.Drawing.Color.Transparent;
			this.rcommitAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.rcommitAuthor.Location = new System.Drawing.Point(47, 92);
			this.rcommitAuthor.Name = "rcommitAuthor";
			this.rcommitAuthor.Size = new System.Drawing.Size(53, 13);
			this.rcommitAuthor.TabIndex = 12;
			this.rcommitAuthor.Text = "John Doe";
			// 
			// SysAuthor1
			// 
			this.SysAuthor1.AutoSize = true;
			this.SysAuthor1.BackColor = System.Drawing.Color.Transparent;
			this.SysAuthor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SysAuthor1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.SysAuthor1.Location = new System.Drawing.Point(4, 92);
			this.SysAuthor1.Name = "SysAuthor1";
			this.SysAuthor1.Size = new System.Drawing.Size(48, 13);
			this.SysAuthor1.TabIndex = 11;
			this.SysAuthor1.Text = "Author:";
			// 
			// rcommiteeAvatar
			// 
			this.rcommiteeAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rcommiteeAvatar.Location = new System.Drawing.Point(325, 16);
			this.rcommiteeAvatar.Name = "rcommiteeAvatar";
			this.rcommiteeAvatar.Size = new System.Drawing.Size(69, 69);
			this.rcommiteeAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.rcommiteeAvatar.TabIndex = 6;
			this.rcommiteeAvatar.TabStop = false;
			// 
			// rcommitDate
			// 
			this.rcommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rcommitDate.AutoSize = true;
			this.rcommitDate.BackColor = System.Drawing.Color.Transparent;
			this.rcommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.rcommitDate.Location = new System.Drawing.Point(275, 92);
			this.rcommitDate.Name = "rcommitDate";
			this.rcommitDate.Size = new System.Drawing.Size(125, 13);
			this.rcommitDate.TabIndex = 4;
			this.rcommitDate.Text = "08-22-2012 12:44:17 AM";
			// 
			// rcommitText
			// 
			this.rcommitText.BackColor = System.Drawing.Color.Transparent;
			this.rcommitText.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.rcommitText.Location = new System.Drawing.Point(6, 16);
			this.rcommitText.Name = "rcommitText";
			this.rcommitText.Size = new System.Drawing.Size(313, 55);
			this.rcommitText.TabIndex = 1;
			this.rcommitText.Text = "No info yet...";
			// 
			// gbLocal
			// 
			this.gbLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbLocal.BackColor = System.Drawing.Color.Transparent;
			this.gbLocal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbLocal.BackgroundImage")));
			this.gbLocal.Controls.Add(this.lcommitAuthor);
			this.gbLocal.Controls.Add(this.SysAuthor2);
			this.gbLocal.Controls.Add(this.lcommitText);
			this.gbLocal.Controls.Add(this.lcommiteeAvatar);
			this.gbLocal.Controls.Add(this.lcommitDate);
			this.gbLocal.Controls.Add(this.bCheck);
			this.gbLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbLocal.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.gbLocal.Location = new System.Drawing.Point(607, 155);
			this.gbLocal.Name = "gbLocal";
			this.gbLocal.Size = new System.Drawing.Size(400, 108);
			this.gbLocal.TabIndex = 5;
			this.gbLocal.TabStop = false;
			this.gbLocal.Text = "Local ver     ";
			// 
			// lcommitAuthor
			// 
			this.lcommitAuthor.AutoSize = true;
			this.lcommitAuthor.BackColor = System.Drawing.Color.Transparent;
			this.lcommitAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lcommitAuthor.Location = new System.Drawing.Point(47, 92);
			this.lcommitAuthor.Name = "lcommitAuthor";
			this.lcommitAuthor.Size = new System.Drawing.Size(53, 13);
			this.lcommitAuthor.TabIndex = 11;
			this.lcommitAuthor.Text = "John Doe";
			// 
			// SysAuthor2
			// 
			this.SysAuthor2.AutoSize = true;
			this.SysAuthor2.BackColor = System.Drawing.Color.Transparent;
			this.SysAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SysAuthor2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.SysAuthor2.Location = new System.Drawing.Point(4, 92);
			this.SysAuthor2.Name = "SysAuthor2";
			this.SysAuthor2.Size = new System.Drawing.Size(48, 13);
			this.SysAuthor2.TabIndex = 10;
			this.SysAuthor2.Text = "Author:";
			// 
			// lcommitText
			// 
			this.lcommitText.BackColor = System.Drawing.Color.Transparent;
			this.lcommitText.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lcommitText.Location = new System.Drawing.Point(6, 16);
			this.lcommitText.Name = "lcommitText";
			this.lcommitText.Size = new System.Drawing.Size(313, 69);
			this.lcommitText.TabIndex = 9;
			this.lcommitText.Text = "No info yet...";
			// 
			// lcommiteeAvatar
			// 
			this.lcommiteeAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lcommiteeAvatar.Location = new System.Drawing.Point(325, 16);
			this.lcommiteeAvatar.Name = "lcommiteeAvatar";
			this.lcommiteeAvatar.Size = new System.Drawing.Size(69, 69);
			this.lcommiteeAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.lcommiteeAvatar.TabIndex = 8;
			this.lcommiteeAvatar.TabStop = false;
			// 
			// lcommitDate
			// 
			this.lcommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lcommitDate.AutoSize = true;
			this.lcommitDate.BackColor = System.Drawing.Color.Transparent;
			this.lcommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lcommitDate.Location = new System.Drawing.Point(275, 92);
			this.lcommitDate.Name = "lcommitDate";
			this.lcommitDate.Size = new System.Drawing.Size(125, 13);
			this.lcommitDate.TabIndex = 7;
			this.lcommitDate.Text = "08-22-2012 12:44:17 AM";
			// 
			// bCheck
			// 
			this.bCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.bCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.bCheck.Location = new System.Drawing.Point(142, 43);
			this.bCheck.Name = "bCheck";
			this.bCheck.Size = new System.Drawing.Size(75, 23);
			this.bCheck.TabIndex = 5;
			this.bCheck.Text = "Check";
			this.bCheck.UseVisualStyleBackColor = true;
			// 
			// searchCoreDialog
			// 
			this.searchCoreDialog.FileName = "xrCore.dll";
			this.searchCoreDialog.Filter = "xrCore.dll|xrCore.dll|All files (*.*)|*.*";
			this.searchCoreDialog.Title = "Find xrCore.dll";
			// 
			// pbUpdate
			// 
			this.pbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbUpdate.BackColor = System.Drawing.Color.White;
			this.pbUpdate.ForeColor = System.Drawing.Color.SteelBlue;
			this.pbUpdate.Location = new System.Drawing.Point(607, 269);
			this.pbUpdate.MarqueeAnimationSpeed = 250;
			this.pbUpdate.Name = "pbUpdate";
			this.pbUpdate.Size = new System.Drawing.Size(400, 10);
			this.pbUpdate.Step = 1;
			this.pbUpdate.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.pbUpdate.TabIndex = 6;
			this.pbUpdate.Value = 42;
			this.pbUpdate.Visible = false;
			// 
			// gbSettings
			// 
			this.gbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbSettings.BackColor = System.Drawing.Color.Transparent;
			this.gbSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbSettings.BackgroundImage")));
			this.gbSettings.Controls.Add(this.button1);
			this.gbSettings.Controls.Add(this.cbRememberPath);
			this.gbSettings.Controls.Add(this.label1);
			this.gbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.gbSettings.Location = new System.Drawing.Point(607, 400);
			this.gbSettings.Name = "gbSettings";
			this.gbSettings.Size = new System.Drawing.Size(400, 108);
			this.gbSettings.TabIndex = 15;
			this.gbSettings.TabStop = false;
			this.gbSettings.Text = "Settings       ";
			this.gbSettings.Enter += new System.EventHandler(this.gbSettings_Enter);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(9, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Play";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbRememberPath
			// 
			this.cbRememberPath.AutoSize = true;
			this.cbRememberPath.Location = new System.Drawing.Point(374, 88);
			this.cbRememberPath.Name = "cbRememberPath";
			this.cbRememberPath.Size = new System.Drawing.Size(15, 14);
			this.cbRememberPath.TabIndex = 1;
			this.cbRememberPath.UseVisualStyleBackColor = true;
			this.cbRememberPath.CheckedChanged += new System.EventHandler(this.cbRememberPath_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(250, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Remember xrCore path:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.GrayText;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1008, 20);
			this.label2.TabIndex = 16;
			this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
			// 
			// exitLabel
			// 
			this.exitLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.exitLabel.Location = new System.Drawing.Point(991, 2);
			this.exitLabel.Name = "exitLabel";
			this.exitLabel.Size = new System.Drawing.Size(14, 14);
			this.exitLabel.TabIndex = 17;
			this.exitLabel.Text = "x";
			this.exitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.exitLabel.Click += new System.EventHandler(this.exitLabel_Click);
			this.exitLabel.MouseEnter += new System.EventHandler(this.exitLabel_MouseEnter);
			this.exitLabel.MouseLeave += new System.EventHandler(this.exitLabel_MouseLeave);
			// 
			// minimazeLabel
			// 
			this.minimazeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.minimazeLabel.Location = new System.Drawing.Point(971, 2);
			this.minimazeLabel.Name = "minimazeLabel";
			this.minimazeLabel.Size = new System.Drawing.Size(14, 14);
			this.minimazeLabel.TabIndex = 18;
			this.minimazeLabel.Text = "_";
			this.minimazeLabel.Click += new System.EventHandler(this.minimazeLabel_Click);
			this.minimazeLabel.MouseEnter += new System.EventHandler(this.minimazeLabel_MouseEnter);
			this.minimazeLabel.MouseLeave += new System.EventHandler(this.minimazeLabel_MouseLeave);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button2.Location = new System.Drawing.Point(913, 285);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Download last";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1008, 520);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.minimazeLabel);
			this.Controls.Add(this.exitLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gbSettings);
			this.Controls.Add(this.pbUpdate);
			this.Controls.Add(this.gbLocal);
			this.Controls.Add(this.gbRemote);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "X-Ray Oxygen: Sync Planet";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.gbRemote.ResumeLayout(false);
			this.gbRemote.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rcommiteeAvatar)).EndInit();
			this.gbLocal.ResumeLayout(false);
			this.gbLocal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.lcommiteeAvatar)).EndInit();
			this.gbSettings.ResumeLayout(false);
			this.gbSettings.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbRemote;
		private System.Windows.Forms.Label rcommitText;
		private System.Windows.Forms.Label rcommitDate;
		private System.Windows.Forms.GroupBox gbLocal;
		private System.Windows.Forms.Button bCheck;
		private System.Windows.Forms.OpenFileDialog searchCoreDialog;
        private System.Windows.Forms.PictureBox rcommiteeAvatar;
        private System.Windows.Forms.Label lcommitText;
        private System.Windows.Forms.PictureBox lcommiteeAvatar;
        private System.Windows.Forms.Label lcommitDate;
        private System.Windows.Forms.ProgressBar pbUpdate;
		private System.Windows.Forms.Label SysAuthor1;
		private System.Windows.Forms.Label SysAuthor2;
		private System.Windows.Forms.Label rcommitAuthor;
		private System.Windows.Forms.Label lcommitAuthor;
		private System.Windows.Forms.Label LastReleaseName;
		private System.Windows.Forms.Label SysLastReleaseName;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.CheckBox cbRememberPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label exitLabel;
        public System.Windows.Forms.Label minimazeLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}