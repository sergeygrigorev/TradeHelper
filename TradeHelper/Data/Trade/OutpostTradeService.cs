using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using TradeHelper.Auth;
using HtmlAgilityPack;

namespace TradeHelper.Data.Trade
{
	class OutpostTradeService : ITradeService
	{
		private OutpostAuthService auth;

		private const string TradesUrl = "http://www.tf2outpost.com/trades";
		private const string tradeContainerId = "modules";
		private const int bumpInterval = 60 * 31;

		public OutpostTradeService()
		{
			auth = new OutpostAuthService();
		}

		public IEnumerable<TradeItem> GetTrades()
		{
			WebClient web = new WebClient();
			web.Headers.Add("Cookie", auth.Get());
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(web.DownloadString(TradesUrl));
			var tradeList = doc.GetElementbyId(tradeContainerId).ChildNodes.
				Where(p => p.GetAttributeValue("class", "").Contains("trade") && !p.GetAttributeValue("class", "").Contains("fade")).
				Select(p => new TradeItem
							{
								Id = Int32.Parse(p.GetAttributeValue("data-tradeid", "")),
								LastBumped = getTradeBumpDate(p)
							}).ToList();
			return tradeList;
		}

		private DateTime getTradeBumpDate(HtmlNode p)
		{
			string s = p.InnerHtml;
			int begin = s.IndexOf("datetime");
			s = s.Substring(begin + 10, 19);
			return DateTime.ParseExact(s, "yyyy'-'MM'-'dd'T'HH':'mm':'ss", new DateTimeFormatInfo());
		}

		public IEnumerable<TradeItem> GetTradesToBump()
		{
			var tradeList = GetTrades();
			List<TradeItem> list = new List<TradeItem>();
			foreach (TradeItem x in tradeList)
			{
				if ((DateTime.UtcNow - x.LastBumped).TotalSeconds > bumpInterval)
					list.Add(x);
			}
			return list;
		}
	}
}
