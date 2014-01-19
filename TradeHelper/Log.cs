using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeHelper
{
	class Log
	{
		private const string fileName = "log.txt";
		private string userFileName;
		private bool truncate;

		public Log(string filename = "", bool truncate = false)
		{
			userFileName = filename;
			this.truncate = truncate;
		}

		public void Write (string s)
		{
			FileStream stream = new FileStream((userFileName == "") ? fileName : userFileName,
			                                   (truncate) ? FileMode.Truncate : FileMode.OpenOrCreate);
			StreamWriter f = new StreamWriter(stream);
			f.Write(s);
			f.Close();
			stream.Close();
		}
	}
}
