
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataScannableData_Record : gamedataTweakDBRecord
	{
		public gamedataScannableData_Record()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
