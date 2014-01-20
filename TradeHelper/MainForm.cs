using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TradeHelper.Auth;
using TradeHelper.Bump;
using TradeHelper.Data.Trade;
using TradeHelper.Data.Bump;

namespace TradeHelper
{
	public partial class MainForm : Form
	{
		private BumpTimer timer;

		private bool forbidClose = true;

		public MainForm()
		{
			InitializeComponent();
			Init();
			timer = new BumpTimer();
		}

		protected override void OnLoad(EventArgs e)
		{
			MinimizeToTray();
			base.OnLoad(e);
		}

		private void MinimizeToTray()
		{
			Visible = false;
			ShowInTaskbar = false;
		}

		private void RestoreFromTray()
		{
			Visible = true;
			ShowInTaskbar = true;
		}

		private void Init()
		{
			NotifyIcon.ContextMenuStrip = ContextMenu;
			RestoreStripItem.Font = new Font(RestoreStripItem.Font, FontStyle.Bold);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			MinimizeToTray();
			e.Cancel = forbidClose;
			base.OnFormClosing(e);
		}

		private void OpClick(object sender, EventArgs e)
		{
			OutpostBumpService service = new OutpostBumpService();
			service.BumpAll();
		}

		private void BClick(object sender, EventArgs e)
		{
			BazaarBumpService b = new BazaarBumpService();
			b.BumpAll();
		}

		private void RestoreStripItemClick(object sender, EventArgs e)
		{
			RestoreFromTray();
		}

		private void ExitStripItemClick(object sender, EventArgs e)
		{
			forbidClose = false;
			Close();
		}

		private void NotifyIconDoubleClick(object sender, MouseEventArgs e)
		{
			RestoreStripItemClick(sender, e);
		}
	}
}
