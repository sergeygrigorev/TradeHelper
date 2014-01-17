using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	public class Cookie
	{
		private string _name, _value;

		public Cookie(string cookie)
		{
			if (cookie == "")
				throw new NullReferenceException("Empty cookie");
			int i = cookie.IndexOf('=');
			_name = cookie.Substring(0, i);
			_value = cookie.Substring(i + 1);
		}

		public Cookie(string name, string value)
		{
			_name = name;
			_value = value;
		}

		public string Name
		{
			get { return _name; }
		}

		public string Value
		{
			get { return _value; }
		}

		public override string ToString()
		{
			return _name + "=" + _value;
		}
	}
}
