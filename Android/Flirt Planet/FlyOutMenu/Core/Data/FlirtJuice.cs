//--------------------------------------------------------------------------------
//
// Core.Data.FlirtJuice.cs - 
//
// Copyright 2014 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;

//--------------------------------------------------------------------------------

namespace Core.Data
{
	[Serializable]
	public class FlirtJuice
	{
		#region Variables

		//----------------------------------------

		int mFlirtJuicePacks;
		int mRefundFlirtJuice;
		int mRefundFlirtJuiceCap;

		//----------------------------------------

		#endregion Variables

		#region Properties

		//----------------------------------------

		public int FlirtJuicePacks
		{
			get { return mFlirtJuicePacks; }
			set { mFlirtJuicePacks = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int RefundFlirtJuice
		{
			get { return mRefundFlirtJuice; }
			set { mRefundFlirtJuice = Convert.ToInt32(value); }
		}

		//----------------------------------------

		public int RefundFlirtJuiceCap
		{
			get { return mRefundFlirtJuiceCap; }
			set { mRefundFlirtJuiceCap = Convert.ToInt32(value); }
		}

		//----------------------------------------

		#endregion Properties

	} // End Class: FlirtJuice

} // End Namespace: Core.Data

//--------------------------------------------------------------------------------
// EOF

