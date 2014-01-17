using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	interface IAuthService
	{
		Credentials GetCreds();
		bool IsValid(Credentials Creds);
	}
}
