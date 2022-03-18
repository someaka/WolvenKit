
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkNoChildren : inkChildren
	{
		public inkNoChildren()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
