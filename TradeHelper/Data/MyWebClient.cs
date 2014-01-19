using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Data
{
	class MyWebClient : WebClient
	{
		private int timeout;

		public MyWebClient(int timeout):base()
		{
			this.timeout = timeout;
		}

		protected override WebRequest GetWebRequest(Uri address)
		{
			WebRequest r = base.GetWebRequest(address);
			r.Timeout = timeout;
			return r;
		}
	}
}
