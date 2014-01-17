using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeHelper.Data;

namespace TradeHelper.Bump
{
	interface IBumpService
	{
		void BumpAll(object sender = null, EventArgs e = null);
		void Bump(int tradeId);
		void Bump(TradeItem trade);
	}
}
