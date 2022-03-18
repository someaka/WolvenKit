
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCollidableEntityId : ISerializable
	{
		public gameCollidableEntityId()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
