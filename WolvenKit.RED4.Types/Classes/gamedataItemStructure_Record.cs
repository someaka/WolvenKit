
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataItemStructure_Record : gamedataTweakDBRecord
	{
		public gamedataItemStructure_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
