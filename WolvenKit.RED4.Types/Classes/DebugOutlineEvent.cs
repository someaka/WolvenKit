using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DebugOutlineEvent : redEvent
	{
		private CEnum<EOutlineType> _type;
		private CFloat _opacity;
		private entEntityID _requester;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<EOutlineType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get => GetProperty(ref _opacity);
			set => SetProperty(ref _opacity, value);
		}

		[Ordinal(2)] 
		[RED("requester")] 
		public entEntityID Requester
		{
			get => GetProperty(ref _requester);
			set => SetProperty(ref _requester, value);
		}
	}
}
