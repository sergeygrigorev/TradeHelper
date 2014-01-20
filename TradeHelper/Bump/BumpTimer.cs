using System.Timers;
using TradeHelper.Data.Bump;

namespace TradeHelper.Bump
{
	/* This class allows us to auto-bump all trades each %interval% %time-measurement-unit%
	 */

	class BumpTimer
	{
		private Timer timer;
		private OutpostBumpService outpost;
		private BazaarBumpService bazaar;

		public BumpTimer(int IntervalMilliseconds = 1000*60*5)
		{
			timer = new Timer();
			timer.Interval = IntervalMilliseconds;
			outpost = new OutpostBumpService();
			bazaar = new BazaarBumpService();
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
