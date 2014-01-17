using System;
using TradeHelper.Data.Trade;

namespace TradeHelper.Data.Bump
{
	/* Iface that represents service for bumping trades (all or by id/TradeItem instance)
	 */

	interface IBumpService
	{
		void BumpAll(object sender = null, EventArgs e = null);
		void Bump(int tradeId);
		void Bump(TradeItem trade);
	}
}
