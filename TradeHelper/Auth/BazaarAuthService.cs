using System;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace TradeHelper.Auth
{
	class BazaarAuthService : IAuthService
	{
		private const string MainUrl = "http://bazaar.tf/";
		private const string LoginUrl = MainUrl + "users/login";

		private const string SaveFile = "creds.bazaar";
		private const int attempts = 5;

		private Credentials creds;

		public BazaarAuthService()
		{
			FileStream str = new FileStream(SaveFile, FileMode.OpenOrCreate);
			StreamReader f = new StreamReader(str);

			if (!f.EndOfStream)
				creds = new Credentials((new Uri(MainUrl)).Host, f.ReadLine());
			
			f.Close();
			str.Close();

			Login();
		}

		private void Login(int retry = 0)
		{
			if (IsValid())
				return;
			if (retry >= attempts)
				throw new InvalidCredentialsException("Wrong credentials! Authorization failed!");
			AuthForm a = new AuthForm(LoginUrl, Callback);
			a.ShowDialog();
			if (!IsValid())
				Login(retry + 1);
			else Save();
		}

		private void Save()
		{
			FileStream str = new FileStream(SaveFile,FileMode.Truncate);
			StreamWriter f = new StreamWriter(str);
			if (creds != null)
				f.Write(creds.Get());
			f.Close();
			str.Close();
		}

		public Credentials Credentials
		{
			get
			{
				Login();
				return creds;
			}
		}

		public string Get()
		{
			Login();
			return creds.ToString();
		}

		private void Callback(string s)
		{
			creds = new Credentials((new Uri(MainUrl)).Host, s);
		}

		private bool IsValid()
		{
			WebClient web = new WebClient();
			string dl;
			try
			{
				web.Headers.Add("Cookie", creds.ToString());
				dl = web.DownloadString(MainUrl);
			}
			catch(Exception e)
			{
				return false;
			}
			HtmlDocument doc = new HtmlDocument();
			doc.LoadHtml(dl);
			if (doc.GetElementbyId("profile-menu") == null)
				return false;
			return true;
		}
	}
}
