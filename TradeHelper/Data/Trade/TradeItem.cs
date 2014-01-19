using System;

namespace TradeHelper.Data.Trade
{
	/* Represents one single trade on any site.
	 * Stores trade id and last bumped time.
	 * Other info is not required for now
	 * Can be extended if needed
	 */
	class TradeItem
	{
		public int Id { get; set; }
		public DateTime LastBumped { get; set; }
	}
}
