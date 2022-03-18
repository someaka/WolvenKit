
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnUnstoppableStateSignal : gameTaggedSignalUserData
	{
		public OnUnstoppableStateSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
