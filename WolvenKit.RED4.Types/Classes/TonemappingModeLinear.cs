
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TonemappingModeLinear : ITonemappingMode
	{
		public TonemappingModeLinear()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
