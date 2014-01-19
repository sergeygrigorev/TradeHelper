namespace TradeHelper
{
	partial class AuthForm
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
			this.Browser = new System.Windows.Forms.WebBrowser();
			this.Box = new System.Windows.Forms.TextBox();
			this.Ready = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Browser
			// 
			this.Browser.Location = new System.Drawing.Point(12, 12);
			this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
			this.Browser.Name = "Browser";
			this.Browser.Size = new System.Drawing.Size(750, 378);
			this.Browser.TabIndex = 0;
			// 
			// Box
			// 
			this.Box.Location = new System.Drawing.Point(768, 341);
			this.Box.Name = "Box";
			this.Box.Size = new System.Drawing.Size(75, 20);
			this.Box.TabIndex = 1;
			// 
			// Ready
			// 
			this.Ready.Location = new System.Drawing.Point(768, 367);
			this.Ready.Name = "Ready";
			this.Ready.Size = new System.Drawing.Size(75, 23);
			this.Ready.TabIndex = 2;
			this.Ready.Text = "Ready";
			this.Ready.UseVisualStyleBackColor = true;
			this.Ready.Click += new System.EventHandler(this.OnReadyClick);
			// 
			// AuthForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(855, 427);
			this.Controls.Add(this.Ready);
			this.Controls.Add(this.Box);
			this.Controls.Add(this.Browser);
			this.Name = "AuthForm";
			this.Text = "AuthForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser Browser;
		private System.Windows.Forms.TextBox Box;
		private System.Windows.Forms.Button Ready;
	}
}