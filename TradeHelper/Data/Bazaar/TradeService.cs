using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeHelper.Auth;
using TradeHelper.Data;

namespace TradeHelper.Data.Bazaar
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
