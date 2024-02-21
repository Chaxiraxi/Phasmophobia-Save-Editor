namespace WindowsFormsApp4
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002488 File Offset: 0x00000688
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000024C0 File Offset: 0x000006C0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApp4.Form1));
			this.DecryptButton = new global::System.Windows.Forms.Button();
			this.EncryptButton = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.DecryptButton.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.DecryptButton.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.DecryptButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.DecryptButton.FlatAppearance.BorderSize = 0;
			this.DecryptButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(135, 50, 122);
			this.DecryptButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(92, 52, 86);
			this.DecryptButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.DecryptButton.Location = new global::System.Drawing.Point(74, 85);
			this.DecryptButton.Name = "DecryptButton";
			this.DecryptButton.Size = new global::System.Drawing.Size(219, 23);
			this.DecryptButton.TabIndex = 0;
			this.DecryptButton.Text = "Decrypt";
			this.DecryptButton.UseVisualStyleBackColor = false;
			this.DecryptButton.Click += new global::System.EventHandler(this.DecryptButton_Click);
			this.EncryptButton.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.EncryptButton.FlatAppearance.BorderColor = global::System.Drawing.Color.Black;
			this.EncryptButton.FlatAppearance.BorderSize = 0;
			this.EncryptButton.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(135, 50, 122);
			this.EncryptButton.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(92, 52, 86);
			this.EncryptButton.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.EncryptButton.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.EncryptButton.Location = new global::System.Drawing.Point(74, 124);
			this.EncryptButton.Name = "EncryptButton";
			this.EncryptButton.Size = new global::System.Drawing.Size(219, 23);
			this.EncryptButton.TabIndex = 1;
			this.EncryptButton.Text = "Encrypt";
			this.EncryptButton.UseVisualStyleBackColor = false;
			this.EncryptButton.Click += new global::System.EventHandler(this.EncryptButton_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
			this.label1.Location = new global::System.Drawing.Point(58, 29);
			this.label1.Name = "label1";
			this.label1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new global::System.Drawing.Size(252, 27);
			this.label1.TabIndex = 2;
			this.label1.Text = "Phasmophobia Save Editor";
			this.label1.UseCompatibleTextRendering = true;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 255);
			this.label2.Location = new global::System.Drawing.Point(260, 185);
			this.label2.Name = "label2";
			this.label2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new global::System.Drawing.Size(104, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Applebox was here";
			this.label2.UseCompatibleTextRendering = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			base.ClientSize = new global::System.Drawing.Size(376, 211);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.EncryptButton);
			base.Controls.Add(this.DecryptButton);
			this.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			this.Text = "Phasmophobia Save Editor";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button DecryptButton;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button EncryptButton;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label2;
	}
}
