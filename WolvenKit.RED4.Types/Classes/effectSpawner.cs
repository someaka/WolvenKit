
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectSpawner : ISerializable
	{
		public effectSpawner()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
