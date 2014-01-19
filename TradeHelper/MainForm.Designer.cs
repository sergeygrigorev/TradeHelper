namespace TradeHelper
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
			this.Label = new System.Windows.Forms.Label();
			this.Outpost = new System.Windows.Forms.Button();
			this.Bazaar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Label
			// 
			this.Label.AutoSize = true;
			this.Label.Location = new System.Drawing.Point(194, 53);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(35, 13);
			this.Label.TabIndex = 0;
			this.Label.Text = "Label";
			// 
			// Outpost
			// 
			this.Outpost.Location = new System.Drawing.Point(197, 81);
			this.Outpost.Name = "Outpost";
			this.Outpost.Size = new System.Drawing.Size(75, 23);
			this.Outpost.TabIndex = 1;
			this.Outpost.Text = "Outpost";
			this.Outpost.UseVisualStyleBackColor = true;
			this.Outpost.Click += new System.EventHandler(this.OpClick);
			// 
			// Bazaar
			// 
			this.Bazaar.Location = new System.Drawing.Point(197, 123);
			this.Bazaar.Name = "Bazaar";
			this.Bazaar.Size = new System.Drawing.Size(75, 23);
			this.Bazaar.TabIndex = 1;
			this.Bazaar.Text = "Bazaar";
			this.Bazaar.UseVisualStyleBackColor = true;
			this.Bazaar.Click += new System.EventHandler(this.BClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 474);
			this.Controls.Add(this.Bazaar);
			this.Controls.Add(this.Outpost);
			this.Controls.Add(this.Label);
			this.MaximumSize = new System.Drawing.Size(512, 512);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Label;
		private System.Windows.Forms.Button Outpost;
		private System.Windows.Forms.Button Bazaar;

	}
}

