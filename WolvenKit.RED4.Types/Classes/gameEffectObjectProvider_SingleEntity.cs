
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_SingleEntity : gameEffectObjectProvider
	{
		public gameEffectObjectProvider_SingleEntity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
