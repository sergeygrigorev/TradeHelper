using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeHelper
{
	public delegate void AuthFormCallbackDelegate(string creds);

	public partial class AuthForm : Form
	{
		private AuthFormCallbackDelegate callBack;
		private string url;

		public AuthForm(string url, AuthFormCallbackDelegate callback)
		{
			InitializeComponent();
			Browser.ScriptErrorsSuppressed = true;
			Browser.Navigate(url);
			this.url = url;
			callBack = callback;
		}

		private void OnReadyClick(object sender, EventArgs e)
		{
			if (Browser.Document != null && Browser.Url.Host == (new Uri(url)).Host)
			{
				callBack(Browser.Document.Cookie);
				Close();
			}
			else MessageBox.Show("Wrong or no document loaded!");
		}
	}
}
