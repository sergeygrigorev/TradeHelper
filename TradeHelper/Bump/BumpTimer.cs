using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using TradeHelper.Bump;

namespace TradeHelper.Bump
{
	/* This class allows us to auto-bump all trades each %interval% %time-measurement-unit%
	 */

	class BumpTimer
	{
		private Timer timer;
		private int interval;
		private Outpost.BumpService outpost;
		private Bazaar.BumpService bazaar;
		
		public BumpTimer(int IntervalMilliseconds)
		{
			timer = new Timer();
			interval = IntervalMilliseconds;
			Register(outpost.BumpAll);
			Register(bazaar.BumpAll);
			Start();
		}

		public void SetInterval(int Milliseconds)
		{
			timer.Interval = Milliseconds;
		}

		public void Start()
		{
			timer.Start();
		}

		public void Stop()
		{
			timer.Stop();
		}

		private bool Auto
		{
			get { return timer.AutoReset; }
			set { timer.AutoReset = value; }
		}

		private void Register(ElapsedEventHandler eh)
		{
			timer.Elapsed += eh;
		}

		private void Unregister(ElapsedEventHandler eh)
		{
			timer.Elapsed -= eh;
		}


	}
}
