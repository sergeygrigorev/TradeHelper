using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth.Bazaar
{
	class AuthService : IAuthService
	{
		private const string MainUrl = "http://bazaar.tf/";
		private const string LoginUrl = MainUrl + "users/login";

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
