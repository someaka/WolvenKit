
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RandomChancePrereq : gameIScriptablePrereq
	{
		public RandomChancePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
