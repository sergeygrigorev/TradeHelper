using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeHelper.Auth;
using TradeHelper.Auth.Bazaar;
using TradeHelper.Data;

namespace TradeHelper.Bump.Bazaar
{
	class BumpService : IBumpService
	{
		private Credentials creds;
		private AuthService auth;

		public BumpService()
		{
			auth = new AuthService();
			creds = auth.GetCreds();
		}

		public void BumpAll(object sender = null, EventArgs e = null)
		{
			throw new NotImplementedException();
		}

		public void Bump(int tradeId)
		{
			throw new NotImplementedException();
		}

		public void Bump(TradeItem trade)
		{
			throw new NotImplementedException();
		}
	}
}
