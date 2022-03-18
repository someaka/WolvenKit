
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IUpdatableSystem : IScriptable
	{
		public IUpdatableSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
