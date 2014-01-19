using System;
using TradeHelper.Auth;
using TradeHelper.Data.Trade;

namespace TradeHelper.Data.Bump
{
	class BazaarBumpService : IBumpService
	{
		private BazaarAuthService auth;

		private const string url = "http://bazaar.tf/my";

		public BazaarBumpService()
		{
			auth = new BazaarAuthService();
		}

		public void BumpAll(object sender = null, EventArgs e = null)
		{
			Credentials creds = auth.Credentials;

			// That's enough, 'cause bump at this site is performed automatically,
			// when you load any page while singed in.
			// auth.Credentials performs chech of creds by loading page, so it
			// auto-bumps trades.
		}

		public void Bump(int tradeId)
		{
			BumpAll();
		}

		public void Bump(TradeItem trade)
		{
			BumpAll();
		}
	}
}
