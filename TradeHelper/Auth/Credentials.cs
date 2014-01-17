using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	class Credentials
	{
		private CookieSet cookies;
		private readonly string host;

		Credentials(string Host, string Creds):this(Host,new CookieSet(Creds))
		{
			
		}

		Credentials(string Host, CookieSet Creds)
		{
			host = Host;
			cookies = Creds;
		}

		public string Get()
		{
			return cookies.ToString();
		}

		public string GetHost()
		{
			return host;
		}
	}
}
