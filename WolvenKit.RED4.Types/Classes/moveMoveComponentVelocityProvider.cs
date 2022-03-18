
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class moveMoveComponentVelocityProvider : entIVelocityProvider
	{
		public moveMoveComponentVelocityProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
