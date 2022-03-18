
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class gameNPCHealthStatPoolsListener : gamePuppetStatPoolsListener
	{
		public gameNPCHealthStatPoolsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
