
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkIStateMachine : ISerializable
	{
		public inkIStateMachine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
