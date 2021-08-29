using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimDefinition : IScriptable
	{
		private CArray<CHandle<inkanimInterpolator>> _interpolators;
		private CArray<CHandle<inkanimEvent>> _events;

		[Ordinal(0)] 
		[RED("interpolators")] 
		public CArray<CHandle<inkanimInterpolator>> Interpolators
		{
			get => GetProperty(ref _interpolators);
			set => SetProperty(ref _interpolators, value);
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CArray<CHandle<inkanimEvent>> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}
	}
}
