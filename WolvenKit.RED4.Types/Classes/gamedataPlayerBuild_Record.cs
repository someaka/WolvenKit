
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataPlayerBuild_Record : gamedataTweakDBRecord
	{
		public gamedataPlayerBuild_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
