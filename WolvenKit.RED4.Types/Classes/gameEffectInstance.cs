
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectInstance : gameIEffect
	{
		public gameEffectInstance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
