
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataStatPool_Record : gamedataTweakDBRecord
	{
		public gamedataStatPool_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
