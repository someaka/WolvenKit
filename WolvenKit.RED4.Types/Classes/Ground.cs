
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Ground : DefaultTransition
	{
		public Ground()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
