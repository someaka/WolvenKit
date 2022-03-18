
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entISkinableComponent : entIPlacedComponent
	{
		public entISkinableComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
