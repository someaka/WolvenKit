
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIStopCoverCommandParams : questScriptedAICommandParams
	{
		public AIStopCoverCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
