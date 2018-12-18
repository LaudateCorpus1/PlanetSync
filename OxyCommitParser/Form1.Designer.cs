namespace OxyCommitParser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CommitAuthor = new System.Windows.Forms.Label();
			this.CommitText = new System.Windows.Forms.Label();
			this.SysCommitAuthorText = new System.Windows.Forms.Label();
			this.CommitDate = new System.Windows.Forms.Label();
			this.SysCommitDate = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.CommitDate);
			this.groupBox1.Controls.Add(this.SysCommitDate);
			this.groupBox1.Controls.Add(this.CommitAuthor);
			this.groupBox1.Controls.Add(this.CommitText);
			this.groupBox1.Controls.Add(this.SysCommitAuthorText);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Location = new System.Drawing.Point(607, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 108);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Last Update";
			// 
			// CommitAuthor
			// 
			this.CommitAuthor.AutoSize = true;
			this.CommitAuthor.BackColor = System.Drawing.Color.Transparent;
			this.CommitAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CommitAuthor.Location = new System.Drawing.Point(47, 92);
			this.CommitAuthor.Name = "CommitAuthor";
			this.CommitAuthor.Size = new System.Drawing.Size(35, 13);
			this.CommitAuthor.TabIndex = 2;
			this.CommitAuthor.Text = "label3";
			// 
			// CommitText
			// 
			this.CommitText.AutoSize = true;
			this.CommitText.BackColor = System.Drawing.Color.Transparent;
			this.CommitText.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CommitText.Location = new System.Drawing.Point(6, 16);
			this.CommitText.Name = "CommitText";
			this.CommitText.Size = new System.Drawing.Size(41, 13);
			this.CommitText.TabIndex = 1;
			this.CommitText.Text = "No info";
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
			// CommitDate
			// 
			this.CommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CommitDate.AutoSize = true;
			this.CommitDate.BackColor = System.Drawing.Color.Transparent;
			this.CommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CommitDate.Location = new System.Drawing.Point(295, 92);
			this.CommitDate.Name = "CommitDate";
			this.CommitDate.Size = new System.Drawing.Size(35, 13);
			this.CommitDate.TabIndex = 4;
			this.CommitDate.Text = "label3";
			// 
			// SysCommitDate
			// 
			this.SysCommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SysCommitDate.AutoSize = true;
			this.SysCommitDate.BackColor = System.Drawing.Color.Transparent;
			this.SysCommitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SysCommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.SysCommitDate.Location = new System.Drawing.Point(261, 92);
			this.SysCommitDate.Name = "SysCommitDate";
			this.SysCommitDate.Size = new System.Drawing.Size(38, 13);
			this.SysCommitDate.TabIndex = 3;
			this.SysCommitDate.Text = "Date:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1008, 511);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form1";
			this.Text = "X-Ray Oxygen: Sync Planet";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label SysCommitAuthorText;
		private System.Windows.Forms.Label CommitText;
		private System.Windows.Forms.Label CommitAuthor;
		private System.Windows.Forms.Label CommitDate;
		private System.Windows.Forms.Label SysCommitDate;
	}
}