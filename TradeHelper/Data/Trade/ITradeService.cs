using System.Collections.Generic;

namespace TradeHelper.Data.Trade
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
