
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IBackendData : ISerializable
	{
		public IBackendData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
