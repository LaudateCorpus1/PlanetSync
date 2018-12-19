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
            this.rcommiteeAvatar = new System.Windows.Forms.PictureBox();
            this.rcommitDate = new System.Windows.Forms.Label();
            this.SysCommitDate = new System.Windows.Forms.Label();
            this.rcommitAuthor = new System.Windows.Forms.Label();
            this.rcommitText = new System.Windows.Forms.Label();
            this.SysCommitAuthorText = new System.Windows.Forms.Label();
            this.gbLocal = new System.Windows.Forms.GroupBox();
            this.lcommitText = new System.Windows.Forms.Label();
            this.lcommiteeAvatar = new System.Windows.Forms.PictureBox();
            this.lcommitDate = new System.Windows.Forms.Label();
            this.lcommitAuthor = new System.Windows.Forms.Label();
            this.bCheck = new System.Windows.Forms.Button();
            this.CurSysCommitDate = new System.Windows.Forms.Label();
            this.CurSysCommitAuthorText = new System.Windows.Forms.Label();
            this.searchCoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbUpdate = new System.Windows.Forms.ProgressBar();
            this.gbRemote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcommiteeAvatar)).BeginInit();
            this.gbLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcommiteeAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRemote
            // 
            this.gbRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRemote.BackColor = System.Drawing.Color.Transparent;
            this.gbRemote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRemote.BackgroundImage")));
            this.gbRemote.Controls.Add(this.rcommiteeAvatar);
            this.gbRemote.Controls.Add(this.rcommitDate);
            this.gbRemote.Controls.Add(this.SysCommitDate);
            this.gbRemote.Controls.Add(this.rcommitAuthor);
            this.gbRemote.Controls.Add(this.rcommitText);
            this.gbRemote.Controls.Add(this.SysCommitAuthorText);
            this.gbRemote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbRemote.Location = new System.Drawing.Point(607, 3);
            this.gbRemote.Name = "gbRemote";
            this.gbRemote.Size = new System.Drawing.Size(400, 108);
            this.gbRemote.TabIndex = 0;
            this.gbRemote.TabStop = false;
            this.gbRemote.Text = "Last Update";
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
            this.rcommitDate.Location = new System.Drawing.Point(269, 92);
            this.rcommitDate.Name = "rcommitDate";
            this.rcommitDate.Size = new System.Drawing.Size(125, 13);
            this.rcommitDate.TabIndex = 4;
            this.rcommitDate.Text = "08-22-2012 12:44:17 AM";
            // 
            // SysCommitDate
            // 
            this.SysCommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SysCommitDate.AutoSize = true;
            this.SysCommitDate.BackColor = System.Drawing.Color.Transparent;
            this.SysCommitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SysCommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SysCommitDate.Location = new System.Drawing.Point(225, 92);
            this.SysCommitDate.Name = "SysCommitDate";
            this.SysCommitDate.Size = new System.Drawing.Size(38, 13);
            this.SysCommitDate.TabIndex = 3;
            this.SysCommitDate.Text = "Date:";
            // 
            // rcommitAuthor
            // 
            this.rcommitAuthor.AutoSize = true;
            this.rcommitAuthor.BackColor = System.Drawing.Color.Transparent;
            this.rcommitAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rcommitAuthor.Location = new System.Drawing.Point(47, 92);
            this.rcommitAuthor.Name = "rcommitAuthor";
            this.rcommitAuthor.Size = new System.Drawing.Size(53, 13);
            this.rcommitAuthor.TabIndex = 2;
            this.rcommitAuthor.Text = "John Doe";
            // 
            // rcommitText
            // 
            this.rcommitText.BackColor = System.Drawing.Color.Transparent;
            this.rcommitText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rcommitText.Location = new System.Drawing.Point(6, 16);
            this.rcommitText.Name = "rcommitText";
            this.rcommitText.Size = new System.Drawing.Size(313, 69);
            this.rcommitText.TabIndex = 1;
            this.rcommitText.Text = "No info yet...";
            // 
            // SysCommitAuthorText
            // 
            this.SysCommitAuthorText.AutoSize = true;
            this.SysCommitAuthorText.BackColor = System.Drawing.Color.Transparent;
            this.SysCommitAuthorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SysCommitAuthorText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SysCommitAuthorText.Location = new System.Drawing.Point(2, 92);
            this.SysCommitAuthorText.Name = "SysCommitAuthorText";
            this.SysCommitAuthorText.Size = new System.Drawing.Size(48, 13);
            this.SysCommitAuthorText.TabIndex = 0;
            this.SysCommitAuthorText.Text = "Author:";
            // 
            // gbLocal
            // 
            this.gbLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLocal.BackColor = System.Drawing.Color.Transparent;
            this.gbLocal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbLocal.BackgroundImage")));
            this.gbLocal.Controls.Add(this.CurSysCommitDate);
            this.gbLocal.Controls.Add(this.CurSysCommitAuthorText);
            this.gbLocal.Controls.Add(this.lcommitText);
            this.gbLocal.Controls.Add(this.lcommiteeAvatar);
            this.gbLocal.Controls.Add(this.lcommitDate);
            this.gbLocal.Controls.Add(this.lcommitAuthor);
            this.gbLocal.Controls.Add(this.bCheck);
            this.gbLocal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbLocal.Location = new System.Drawing.Point(607, 117);
            this.gbLocal.Name = "gbLocal";
            this.gbLocal.Size = new System.Drawing.Size(400, 108);
            this.gbLocal.TabIndex = 5;
            this.gbLocal.TabStop = false;
            this.gbLocal.Text = "Current";
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
            this.lcommitDate.Location = new System.Drawing.Point(269, 92);
            this.lcommitDate.Name = "lcommitDate";
            this.lcommitDate.Size = new System.Drawing.Size(125, 13);
            this.lcommitDate.TabIndex = 7;
            this.lcommitDate.Text = "08-22-2012 12:44:17 AM";
            // 
            // lcommitAuthor
            // 
            this.lcommitAuthor.AutoSize = true;
            this.lcommitAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lcommitAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lcommitAuthor.Location = new System.Drawing.Point(47, 92);
            this.lcommitAuthor.Name = "lcommitAuthor";
            this.lcommitAuthor.Size = new System.Drawing.Size(53, 13);
            this.lcommitAuthor.TabIndex = 6;
            this.lcommitAuthor.Text = "John Doe";
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
            // CurSysCommitDate
            // 
            this.CurSysCommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurSysCommitDate.AutoSize = true;
            this.CurSysCommitDate.BackColor = System.Drawing.Color.Transparent;
            this.CurSysCommitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurSysCommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CurSysCommitDate.Location = new System.Drawing.Point(225, 92);
            this.CurSysCommitDate.Name = "CurSysCommitDate";
            this.CurSysCommitDate.Size = new System.Drawing.Size(38, 13);
            this.CurSysCommitDate.TabIndex = 3;
            this.CurSysCommitDate.Text = "Date:";
            // 
            // CurSysCommitAuthorText
            // 
            this.CurSysCommitAuthorText.AutoSize = true;
            this.CurSysCommitAuthorText.BackColor = System.Drawing.Color.Transparent;
            this.CurSysCommitAuthorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurSysCommitAuthorText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CurSysCommitAuthorText.Location = new System.Drawing.Point(2, 92);
            this.CurSysCommitAuthorText.Name = "CurSysCommitAuthorText";
            this.CurSysCommitAuthorText.Size = new System.Drawing.Size(48, 13);
            this.CurSysCommitAuthorText.TabIndex = 0;
            this.CurSysCommitAuthorText.Text = "Author:";
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
            this.pbUpdate.Location = new System.Drawing.Point(607, 231);
            this.pbUpdate.MarqueeAnimationSpeed = 250;
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(400, 10);
            this.pbUpdate.Step = 1;
            this.pbUpdate.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbUpdate.TabIndex = 6;
            this.pbUpdate.Value = 42;
            this.pbUpdate.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 511);
            this.Controls.Add(this.pbUpdate);
            this.Controls.Add(this.gbLocal);
            this.Controls.Add(this.gbRemote);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "X-Ray Oxygen: Sync Planet";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.gbRemote.ResumeLayout(false);
            this.gbRemote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcommiteeAvatar)).EndInit();
            this.gbLocal.ResumeLayout(false);
            this.gbLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcommiteeAvatar)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbRemote;
		private System.Windows.Forms.Label SysCommitAuthorText;
		private System.Windows.Forms.Label rcommitText;
		private System.Windows.Forms.Label rcommitAuthor;
		private System.Windows.Forms.Label rcommitDate;
		private System.Windows.Forms.Label SysCommitDate;
		private System.Windows.Forms.GroupBox gbLocal;
		private System.Windows.Forms.Label CurSysCommitDate;
		private System.Windows.Forms.Label CurSysCommitAuthorText;
		private System.Windows.Forms.Button bCheck;
		private System.Windows.Forms.OpenFileDialog searchCoreDialog;
        private System.Windows.Forms.PictureBox rcommiteeAvatar;
        private System.Windows.Forms.Label lcommitText;
        private System.Windows.Forms.PictureBox lcommiteeAvatar;
        private System.Windows.Forms.Label lcommitDate;
        private System.Windows.Forms.Label lcommitAuthor;
        private System.Windows.Forms.ProgressBar pbUpdate;
    }
}