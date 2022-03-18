
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TXAACustomData : ICameraStorageCustomData
	{
		public TXAACustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
