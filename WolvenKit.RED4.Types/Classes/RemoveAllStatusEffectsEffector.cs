
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveAllStatusEffectsEffector : gameEffector
	{
		public RemoveAllStatusEffectsEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
