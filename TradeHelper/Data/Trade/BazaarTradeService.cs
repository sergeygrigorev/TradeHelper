using System.Collections.Generic;
using TradeHelper.Auth;

namespace TradeHelper.Data.Trade
{
	class BazaarTradeService : ITradeService
	{
		private BazaarAuthService auth;
		
		public BazaarTradeService()
		{
			auth = new BazaarAuthService();
		}

		public IEnumerable<TradeItem> GetTrades()
		{
			return new List<TradeItem>();
		}

		public IEnumerable<TradeItem> GetTradesToBump()
		{
			return GetTrades();
		}
	}
}
