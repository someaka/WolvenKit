
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProjectileHelper : IScriptable
	{
		public ProjectileHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
