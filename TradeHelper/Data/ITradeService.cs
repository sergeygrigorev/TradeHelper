using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeHelper.Auth;

namespace TradeHelper.Data
{
	interface ITradeService
	{
		IEnumerable<TradeItem> GetTrades();
		IEnumerable<TradeItem> GetTradesToBump();
	}
}
