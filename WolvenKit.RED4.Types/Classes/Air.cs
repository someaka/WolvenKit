
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Air : DefaultTransition
	{
		public Air()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
