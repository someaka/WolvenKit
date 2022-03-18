
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VolFogCustomData : ICameraStorageCustomData
	{
		public VolFogCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
