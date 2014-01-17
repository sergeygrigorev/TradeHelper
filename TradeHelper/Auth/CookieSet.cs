using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	/* Represents some collection of cookies
	 */

	class CookieSet
	{
		private Dictionary<string, string> _data;

		public CookieSet()
		{
			_data = new Dictionary<string, string>();
		}

		public CookieSet (string saved):this()
		{
			if (saved == "")
				return;
			string[] cookies = saved.Split(';');
			for (int i = 0; i < cookies.Length; i++)
				if (cookies[i][0] == ' ')
					cookies[i] = cookies[i].Substring(1);
			foreach (string s in cookies)
			{
				Add(new Cookie(s));
			}
		}

		public void Add(Cookie c)
		{
			_data.Add(c.Name, c.Value);
		}

		public Cookie Get(string name)
		{
			if (_data.Keys.Contains(name))
				return new Cookie(name, _data[name]);
			throw new ArgumentException("No such cookie");
		}

		public string this[string s]
		{
			get { return Get(s).Value; }
			set
			{
				if (_data.Keys.Contains(s))
					_data[s] = value;
				else _data.Add(s, value);
			}
		}

		public override string ToString()
		{
			string s = "";
			foreach (KeyValuePair<string, string> k in _data)
			{
				if (s != "")
					s += "; ";
				s += this.Get(k.Key);
			}
			return s;
		}
	}
}
