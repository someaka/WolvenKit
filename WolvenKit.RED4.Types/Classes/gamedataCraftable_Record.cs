
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataCraftable_Record : gamedataTweakDBRecord
	{
		public gamedataCraftable_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
