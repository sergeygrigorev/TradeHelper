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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Label = new System.Windows.Forms.Label();
			this.Outpost = new System.Windows.Forms.Button();
			this.Bazaar = new System.Windows.Forms.Button();
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.RestoreStripItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitStripItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// Label
			// 
			this.Label.AutoSize = true;
			this.Label.Location = new System.Drawing.Point(194, 53);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(33, 13);
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
			// NotifyIcon
			// 
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "TradeHelper";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconDoubleClick);
			// 
			// ContextMenu
			// 
			this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RestoreStripItem,
            this.ExitStripItem});
			this.ContextMenu.Name = "ContextMenu";
			this.ContextMenu.Size = new System.Drawing.Size(114, 48);
			// 
			// RestoreStripItem
			// 
			this.RestoreStripItem.Name = "RestoreStripItem";
			this.RestoreStripItem.Size = new System.Drawing.Size(113, 22);
			this.RestoreStripItem.Text = "Restore";
			this.RestoreStripItem.Click += new System.EventHandler(this.RestoreStripItemClick);
			// 
			// ExitStripItem
			// 
			this.ExitStripItem.Name = "ExitStripItem";
			this.ExitStripItem.Size = new System.Drawing.Size(113, 22);
			this.ExitStripItem.Text = "Exit";
			this.ExitStripItem.Click += new System.EventHandler(this.ExitStripItemClick);
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
			this.ContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Label;
		private System.Windows.Forms.Button Outpost;
		private System.Windows.Forms.Button Bazaar;
		private System.Windows.Forms.NotifyIcon NotifyIcon;
		private System.Windows.Forms.ContextMenuStrip ContextMenu;
		private System.Windows.Forms.ToolStripMenuItem RestoreStripItem;
		private System.Windows.Forms.ToolStripMenuItem ExitStripItem;

	}
}

