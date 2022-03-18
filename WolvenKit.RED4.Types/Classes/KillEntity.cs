
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KillEntity : AIActionHelperTask
	{
		public KillEntity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
