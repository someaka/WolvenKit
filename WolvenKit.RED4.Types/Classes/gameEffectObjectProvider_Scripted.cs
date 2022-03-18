
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_Scripted : gameEffectObjectProvider
	{
		public gameEffectObjectProvider_Scripted()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
