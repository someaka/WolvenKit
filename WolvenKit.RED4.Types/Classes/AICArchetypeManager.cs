
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICArchetypeManager : AIIArchetypeManager
	{
		public AICArchetypeManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
