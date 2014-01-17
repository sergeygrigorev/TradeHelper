using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Data
{
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
