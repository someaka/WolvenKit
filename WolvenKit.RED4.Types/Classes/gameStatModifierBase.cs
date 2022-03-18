
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatModifierBase : RedBaseClass
	{
		public gameStatModifierBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
