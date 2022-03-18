
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameITimeState : ISerializable
	{
		public gameITimeState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
