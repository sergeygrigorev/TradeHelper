using System;
using System.Collections.Generic;
using TradeHelper.Auth;

namespace TradeHelper.Data.Trade.Bazaar
{
	class TradeService : ITradeService
	{
		private Credentials creds;

		public TradeService(Credentials Creds)
		{
			creds = Creds;
		}

		public IEnumerable<TradeItem> GetTrades()
		{
			throw new Exception();
		}

		public IEnumerable<TradeItem> GetTradesToBump()
		{
			return GetTrades();
		}
	}
}
