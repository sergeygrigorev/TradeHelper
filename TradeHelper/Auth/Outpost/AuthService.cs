using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth.Outpost
{
	class AuthService : IAuthService
	{
		private const string MainUrl = "http://www.tf2outpost.com/";
		private const string LoginUrl = MainUrl + "login";

		public AuthService()
		{

		}

		public Credentials GetCreds()
		{
			throw new NotImplementedException();
		}

		public bool IsValid(Credentials Creds)
		{
			throw new NotImplementedException();
		}
	}
}
