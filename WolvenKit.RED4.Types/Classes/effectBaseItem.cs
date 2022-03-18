
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectBaseItem : ISerializable
	{
		public effectBaseItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
