
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataStatModifier_Record : gamedataTweakDBRecord
	{
		public gamedataStatModifier_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
