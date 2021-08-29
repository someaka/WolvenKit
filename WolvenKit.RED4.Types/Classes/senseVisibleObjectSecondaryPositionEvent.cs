using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class senseVisibleObjectSecondaryPositionEvent : redEvent
	{
		private Vector3 _offset;

		[Ordinal(0)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}
	}
}
