
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimationsLoaded : gameTaggedSignalUserData
	{
		public AnimationsLoaded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
