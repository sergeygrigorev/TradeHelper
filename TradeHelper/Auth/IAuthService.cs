using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper.Auth
{
	/* This Iface is for authentification.
	 * Gets new Credentials or validates existing ones
	 */

	interface IAuthService
	{
		Credentials Credentials { get; }
	}
}
