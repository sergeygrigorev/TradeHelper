using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	/* Represents credentials to access some host
	 * */

	class Credentials
	{
		public static string CredentialsPath = "Credentials.res";

		private CookieSet cookies;
		private readonly string host;

		public Credentials(string Host, string Creds):this(Host,new CookieSet(Creds))
		{
			
		}

		public Credentials(string Host, CookieSet Creds)
		{
			host = Host;
			cookies = Creds;
		}

		public CookieSet Get()
		{
			return cookies;
		}

		public string GetHost()
		{
			return host;
		}

		public override string ToString()
		{
			return cookies.ToString();
		}
	}
}
