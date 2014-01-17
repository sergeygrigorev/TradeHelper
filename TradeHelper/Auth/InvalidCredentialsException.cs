using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	class InvalidCredentialsException : Exception
	{
		public override string Message
		{
			get { return "Credentials are invalid"; }
		}
	}
}
