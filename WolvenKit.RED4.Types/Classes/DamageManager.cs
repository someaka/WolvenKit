
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageManager : IScriptable
	{
		public DamageManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
