
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class gamePlayerHealthStatPoolsListener : gamePuppetStatPoolsListener
	{
		public gamePlayerHealthStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
