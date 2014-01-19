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
using TradeHelper.Data.Trade;
using TradeHelper.Data.Bump;

namespace TradeHelper
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void OpClick(object sender, EventArgs e)
		{
			/*OutpostTradeService service = new OutpostTradeService();
			var trades = service.GetTradesToBump();
			Label.Text = "";
			foreach (TradeItem t in trades)
			{
				Label.Text += t.Id + " - " + String.Format("{0:yyyyMMddHHmm}", t.LastBumped) + "\n";
			}*/
			OutpostBumpService service = new OutpostBumpService();
			service.BumpAll();
		}

		private void BClick(object sender, EventArgs e)
		{
			BazaarBumpService b = new BazaarBumpService();
		}
	}
}
