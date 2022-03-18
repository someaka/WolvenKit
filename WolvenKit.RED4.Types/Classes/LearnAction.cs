
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LearnAction : ConsumeAction
	{
		public LearnAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
