
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveExitedSplineEvent : redEvent
	{
		public moveExitedSplineEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
