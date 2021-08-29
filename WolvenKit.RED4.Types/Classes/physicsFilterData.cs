using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsFilterData : ISerializable
	{
		private physicsSimulationFilter _simulationFilter;
		private physicsQueryFilter _queryFilter;
		private CName _preset;
		private CHandle<physicsCustomFilterData> _customFilterData;

		[Ordinal(0)] 
		[RED("simulationFilter")] 
		public physicsSimulationFilter SimulationFilter
		{
			get => GetProperty(ref _simulationFilter);
			set => SetProperty(ref _simulationFilter, value);
		}

		[Ordinal(1)] 
		[RED("queryFilter")] 
		public physicsQueryFilter QueryFilter
		{
			get => GetProperty(ref _queryFilter);
			set => SetProperty(ref _queryFilter, value);
		}

		[Ordinal(2)] 
		[RED("preset")] 
		public CName Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}

		[Ordinal(3)] 
		[RED("customFilterData")] 
		public CHandle<physicsCustomFilterData> CustomFilterData
		{
			get => GetProperty(ref _customFilterData);
			set => SetProperty(ref _customFilterData, value);
		}
	}
}
