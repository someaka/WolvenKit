
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MiddleFive : DefaultTransition
	{
		public MiddleFive()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
