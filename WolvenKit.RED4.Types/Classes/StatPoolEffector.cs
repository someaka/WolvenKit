
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatPoolEffector : gameEffector
	{
		public StatPoolEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
