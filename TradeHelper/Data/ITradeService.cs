using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeHelper.Auth;

namespace TradeHelper.Data
{
	/* Iface for services that get trades from the website
	 * We can get all trades or bumpable trades only
	 * Bumpable trades are those ones which are last bumped %bump-interval% ago or earlier
	 */

	interface ITradeService
	{
		IEnumerable<TradeItem> GetTrades();
		IEnumerable<TradeItem> GetTradesToBump();
	}
}
