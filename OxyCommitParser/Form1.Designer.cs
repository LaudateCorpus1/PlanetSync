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
			this.CommitDate = new System.Windows.Forms.Label();
			this.SysCommitDate = new System.Windows.Forms.Label();
			this.CommitAuthor = new System.Windows.Forms.Label();
			this.CommitText = new System.Windows.Forms.Label();
			this.SysCommitAuthorText = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.CurCommitDate = new System.Windows.Forms.Label();
			this.CurSysCommitDate = new System.Windows.Forms.Label();
			this.CurCommitAuthor = new System.Windows.Forms.Label();
			this.CurCommitMsg = new System.Windows.Forms.Label();
			this.CurSysCommitAuthorText = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.CurCommitDate);
			this.groupBox2.Controls.Add(this.CurSysCommitDate);
			this.groupBox2.Controls.Add(this.CurCommitAuthor);
			this.groupBox2.Controls.Add(this.CurCommitMsg);
			this.groupBox2.Controls.Add(this.CurSysCommitAuthorText);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox2.Location = new System.Drawing.Point(607, 117);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(400, 108);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Current ver  ";
			// 
			// CurCommitDate
			// 
			this.CurCommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CurCommitDate.AutoSize = true;
			this.CurCommitDate.BackColor = System.Drawing.Color.Transparent;
			this.CurCommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CurCommitDate.Location = new System.Drawing.Point(295, 92);
			this.CurCommitDate.Name = "CurCommitDate";
			this.CurCommitDate.Size = new System.Drawing.Size(35, 13);
			this.CurCommitDate.TabIndex = 4;
			this.CurCommitDate.Text = "label3";
			this.CurCommitDate.Visible = false;
			// 
			// CurSysCommitDate
			// 
			this.CurSysCommitDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CurSysCommitDate.AutoSize = true;
			this.CurSysCommitDate.BackColor = System.Drawing.Color.Transparent;
			this.CurSysCommitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CurSysCommitDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CurSysCommitDate.Location = new System.Drawing.Point(261, 92);
			this.CurSysCommitDate.Name = "CurSysCommitDate";
			this.CurSysCommitDate.Size = new System.Drawing.Size(38, 13);
			this.CurSysCommitDate.TabIndex = 3;
			this.CurSysCommitDate.Text = "Date:";
			this.CurSysCommitDate.Visible = false;
			// 
			// CurCommitAuthor
			// 
			this.CurCommitAuthor.AutoSize = true;
			this.CurCommitAuthor.BackColor = System.Drawing.Color.Transparent;
			this.CurCommitAuthor.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CurCommitAuthor.Location = new System.Drawing.Point(47, 92);
			this.CurCommitAuthor.Name = "CurCommitAuthor";
			this.CurCommitAuthor.Size = new System.Drawing.Size(35, 13);
			this.CurCommitAuthor.TabIndex = 2;
			this.CurCommitAuthor.Text = "label3";
			this.CurCommitAuthor.Visible = false;
			// 
			// CurCommitMsg
			// 
			this.CurCommitMsg.AutoSize = true;
			this.CurCommitMsg.BackColor = System.Drawing.Color.Transparent;
			this.CurCommitMsg.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.CurCommitMsg.Location = new System.Drawing.Point(6, 16);
			this.CurCommitMsg.Name = "CurCommitMsg";
			this.CurCommitMsg.Size = new System.Drawing.Size(41, 13);
			this.CurCommitMsg.TabIndex = 1;
			this.CurCommitMsg.Text = "No info";
			this.CurCommitMsg.Visible = false;
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
			this.CurSysCommitAuthorText.Visible = false;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(142, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Check";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1008, 511);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Form1";
			this.Text = "X-Ray Oxygen: Sync Planet";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label SysCommitAuthorText;
		private System.Windows.Forms.Label CommitText;
		private System.Windows.Forms.Label CommitAuthor;
		private System.Windows.Forms.Label CommitDate;
		private System.Windows.Forms.Label SysCommitDate;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label CurCommitDate;
		private System.Windows.Forms.Label CurSysCommitDate;
		private System.Windows.Forms.Label CurCommitAuthor;
		private System.Windows.Forms.Label CurCommitMsg;
		private System.Windows.Forms.Label CurSysCommitAuthorText;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}