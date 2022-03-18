
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DefaultTransition : gamestateMachineFunctor
	{
		public DefaultTransition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
