
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SimpleTemporalCustomData : ICameraStorageCustomData
	{
		public SimpleTemporalCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
