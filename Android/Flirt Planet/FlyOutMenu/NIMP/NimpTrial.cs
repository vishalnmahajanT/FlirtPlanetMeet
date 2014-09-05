//--------------------------------------------------------------------------------
//
// iOS.NimpRewardPopup.cs - How information about each trial ("I AM XXXX/TRUE or FALSE")
//						    is stored both for the screen and for building the report
//						    string for Neurosense
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

namespace flirtplanet
{
	public class NimpTrial
	{
		public int 		Id { get; set; }
		public string 	Text { get; set; }
		public bool 	DisplayTrue { get; set; }

		// These are determined after user makes choice
		public bool 	Attempted { get; set; }
		public bool 	GotRightFirstTry { get; set; }
		public double 	MSResponseTime { get; set; }

		//----------------------------------------

		public NimpTrial(int id)
		{
			Attempted = false;
			MSResponseTime = 9999999;
		}

		//----------------------------------------

	} // End Class: NimpTrial

} // End Namespace: iOS

//--------------------------------------------------------------------------------
// EOF


