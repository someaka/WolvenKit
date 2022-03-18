
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider : gameEffectNode
	{
		public gameEffectObjectProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
