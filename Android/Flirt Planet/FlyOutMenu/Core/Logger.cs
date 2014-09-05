//--------------------------------------------------------------------------------
//
// Core.Logger.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Text;

//--------------------------------------------------------------------------------

namespace Core
{
	public static class Logger
	{
		#region Variables

		//----------------------------------------

		static StringBuilder sExceptionLog = new StringBuilder();
		static StringBuilder sDebugLog = new StringBuilder();

		//----------------------------------------

		#endregion

		#region Methods

		//----------------------------------------
		// Report exception

		public static void ReportException(string errorMessage)
		{
			sExceptionLog.AppendLine("Exception: " + errorMessage);

			Debug.WriteLine("Exception: " + errorMessage);
		}

		//----------------------------------------
		// Write debug log

		public static void DebugLog(string debugMessage)
		{
			sDebugLog.AppendLine("Debug: " + debugMessage);

			Console.WriteLine("Debug: " + debugMessage);
		}

		//----------------------------------------

		public static void Assert(bool condition, string message = "")
		{
			if (!condition)
			{
				DebugLog("Assert: " + message);
			}
		}

		//----------------------------------------
		// TO DO: Write Exception file

		public static void WriteExceptionFile()
		{

		}

		//----------------------------------------

		public static string ListToString<T>(this T[] array, string separator = ", ")
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < array.Length; ++i)
			{
				sb.Append(array[i].ToString());
				if (i != array.Length - 1)
					sb.Append(separator);
			}

			return sb.ToString();
		}

		//----------------------------------------

		#endregion

	} // End Class: Logger

} // End Namespace: Core.Business

//--------------------------------------------------------------------------------
// EOF
