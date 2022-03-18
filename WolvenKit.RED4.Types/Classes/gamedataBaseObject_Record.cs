
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataBaseObject_Record : gamedataTweakDBRecord
	{
		public gamedataBaseObject_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
