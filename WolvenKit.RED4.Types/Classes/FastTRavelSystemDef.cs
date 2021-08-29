using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTRavelSystemDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _destinationPoint;
		private gamebbScriptID_Variant _startingPoint;
		private gamebbScriptID_Bool _fastTravelLoadingScreenFinished;

		[Ordinal(0)] 
		[RED("DestinationPoint")] 
		public gamebbScriptID_Variant DestinationPoint
		{
			get => GetProperty(ref _destinationPoint);
			set => SetProperty(ref _destinationPoint, value);
		}

		[Ordinal(1)] 
		[RED("StartingPoint")] 
		public gamebbScriptID_Variant StartingPoint
		{
			get => GetProperty(ref _startingPoint);
			set => SetProperty(ref _startingPoint, value);
		}

		[Ordinal(2)] 
		[RED("FastTravelLoadingScreenFinished")] 
		public gamebbScriptID_Bool FastTravelLoadingScreenFinished
		{
			get => GetProperty(ref _fastTravelLoadingScreenFinished);
			set => SetProperty(ref _fastTravelLoadingScreenFinished, value);
		}
	}
}
