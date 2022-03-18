
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityStubComponent : gameComponent
	{
		public gameEntityStubComponent()
		{
			Name = "entityStub";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
