using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	/* I dont remember why i created this class 0_o
	 * Dont take care of it ^_^
	 */

	class InvalidCredentialsException : Exception
	{
		public InvalidCredentialsException(string message):base(message)
		{
			
		}

		public override string Message
		{
			get { return "Credentials are invalid"; }
		}
	}
}
