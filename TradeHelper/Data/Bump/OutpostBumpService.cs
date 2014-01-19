using System;
using System.Net;
using System.Timers;
using TradeHelper.Auth;
using TradeHelper.Data.Trade;

namespace TradeHelper.Data.Bump
{
	class OutpostBumpService : IBumpService
	{
		private const string BumpUrl = "http://www.tf2outpost.com/api/core";
		private const string RefererUrl = "http://www.tf2outpost.com/trades";
		private const string BumpParams = "action=trade.bump&hash={0}&tradeid={1}";
		private const string ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

		private const int timeout = 1000 * 5;
		private const int attempts = 5;

		private OutpostAuthService auth;
		private Timer timer;

		public OutpostBumpService()
		{
			auth = new OutpostAuthService();
		}

		public void BumpAll(object sender = null, EventArgs e = null)
		{
			OutpostTradeService ts = new OutpostTradeService();
			var trades = ts.GetTradesToBump();
			CookieSet cook = auth.Credentials.Get();
			string hash = cook["uhash"];
			MyWebClient web = new MyWebClient(timeout);
			web.Headers.Add("Referer", RefererUrl);
			web.Headers.Add("Cookie", cook.ToString());
			foreach (TradeItem t in trades)
			{
				web.Headers.Add("Content-Type", ContentType);
				string data = String.Format(BumpParams, hash, t.Id);
				int c = attempts;
				while (c > 0)
				{
					try
					{
						web.UploadString(BumpUrl, data);
						break;
					}
					catch (Exception ex)
					{
						c--;
					}
				}
			}
		}

		public void Bump(int tradeId)
		{
			throw new NotImplementedException();
		}

		public void Bump(TradeItem trade)
		{
			throw new NotImplementedException();
		}
	}
}
