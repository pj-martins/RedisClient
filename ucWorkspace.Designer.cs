namespace PaJaMa.RedisClient
{
	partial class ucWorkspace
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGO = new System.Windows.Forms.Button();
			this.txtField = new System.Windows.Forms.TextBox();
			this.txtHash = new System.Windows.Forms.TextBox();
			this.cboCommand = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtConnectionString = new System.Windows.Forms.ComboBox();
			this.txtOutput = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnGO);
			this.panel1.Controls.Add(this.txtField);
			this.panel1.Controls.Add(this.txtHash);
			this.panel1.Controls.Add(this.cboCommand);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtConnectionString);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1025, 71);
			this.panel1.TabIndex = 0;
			// 
			// btnGO
			// 
			this.btnGO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGO.Location = new System.Drawing.Point(910, 35);
			this.btnGO.Name = "btnGO";
			this.btnGO.Size = new System.Drawing.Size(102, 23);
			this.btnGO.TabIndex = 11;
			this.btnGO.Text = "GO";
			this.btnGO.UseVisualStyleBackColor = true;
			this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
			// 
			// txtField
			// 
			this.txtField.Location = new System.Drawing.Point(481, 37);
			this.txtField.Name = "txtField";
			this.txtField.Size = new System.Drawing.Size(423, 20);
			this.txtField.TabIndex = 10;
			// 
			// txtHash
			// 
			this.txtHash.Location = new System.Drawing.Point(142, 37);
			this.txtHash.Name = "txtHash";
			this.txtHash.Size = new System.Drawing.Size(333, 20);
			this.txtHash.TabIndex = 9;
			// 
			// cboCommand
			// 
			this.cboCommand.FormattingEnabled = true;
			this.cboCommand.Items.AddRange(new object[] {
            "GET",
            "HGET",
            "SET",
            "HSET",
            "FLUSHALL"});
			this.cboCommand.Location = new System.Drawing.Point(15, 37);
			this.cboCommand.Name = "cboCommand";
			this.cboCommand.Size = new System.Drawing.Size(121, 21);
			this.cboCommand.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Connection";
			// 
			// txtConnectionString
			// 
			this.txtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConnectionString.Location = new System.Drawing.Point(79, 10);
			this.txtConnectionString.Name = "txtConnectionString";
			this.txtConnectionString.Size = new System.Drawing.Size(933, 21);
			this.txtConnectionString.TabIndex = 5;
			// 
			// txtOutput
			// 
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.Location = new System.Drawing.Point(0, 71);
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(1025, 532);
			this.txtOutput.TabIndex = 1;
			this.txtOutput.Text = "";
			// 
			// ucWorkspace
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.panel1);
			this.Name = "ucWorkspace";
			this.Size = new System.Drawing.Size(1025, 603);
			this.Load += new System.EventHandler(this.ucWorkspace_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox txtOutput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox txtConnectionString;
		private System.Windows.Forms.TextBox txtHash;
		private System.Windows.Forms.ComboBox cboCommand;
		private System.Windows.Forms.Button btnGO;
		private System.Windows.Forms.TextBox txtField;
	}
}
