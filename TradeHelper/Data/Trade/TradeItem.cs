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
		private int id;
		private DateTime lastBumped;

		public TradeItem(int Id, DateTime LastBumped)
		{
			id = Id;
			lastBumped = LastBumped;
		}

		public int Id
		{
			get { return id; }
		}

		public DateTime LastBumped
		{
			get { return lastBumped; }
		}
	}
}
