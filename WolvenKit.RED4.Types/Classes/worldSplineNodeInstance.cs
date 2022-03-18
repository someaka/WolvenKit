
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldSplineNodeInstance : worldSocketNodeInstance
	{
		public worldSplineNodeInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
