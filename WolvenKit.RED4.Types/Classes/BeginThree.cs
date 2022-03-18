
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BeginThree : DefaultTransition
	{
		public BeginThree()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
