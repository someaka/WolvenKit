
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSignalUserDataDefinition : ISerializable
	{
		public gameSignalUserDataDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
