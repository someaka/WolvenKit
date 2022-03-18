
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ISerializable : RedBaseClass
	{
		public ISerializable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
