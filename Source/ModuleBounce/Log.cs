using System.Diagnostics;

using KSPe.Util.Log;

namespace SXT
{
	internal static class Log
	{
		private static readonly Logger LOG = Logger.CreateForType<ModuleBounce>();

		internal static void init()
		{
			LOG.level =
#if DEBUG
				Level.TRACE
#else
                Level.INFO
#endif
				;
		}

		internal static void force(string msg, params object[] @params)
		{
			LOG.force(msg, @params);
		}

		internal static void error(string msg, params object[] @params)
		{
			LOG.error(msg, @params);
		}

		internal static void warn(string msg, params object[] @params)
		{
			LOG.warn(msg, @params);
		}

		[Conditional("DEBUG")]	
		internal static void dbg(string msg, params object[] @params)
		{
			LOG.dbg(msg, @params);
		}
	}
}
