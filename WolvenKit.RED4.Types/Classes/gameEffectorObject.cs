
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectorObject : ISerializable
	{
		public gameEffectorObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
