﻿using LibDmd.DmdDevice;

namespace LibDmd
{
	public class AlphaNumericFrame
	{
		/// <summary>
		/// The segment data
		/// </summary>
		public ushort[] SegmentData { get; }

		/// <summary>
		/// The extended segment data
		/// </summary>
		public ushort[] SegmentDataExtended { get; }

		/// <summary>
		/// The segment type
		/// </summary>
		public NumericalLayout SegmentLayout { get; }

		public AlphaNumericFrame(NumericalLayout layout, ushort[] segData)
		{
			SegmentData = segData;
			SegmentLayout = layout;
		}

		public AlphaNumericFrame(NumericalLayout layout, ushort[] segData, ushort[] segDataExtended)
		{
			SegmentData = segData;
			SegmentDataExtended = segDataExtended;
			SegmentLayout = layout;
		}
	}
}
