
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CarriedObject : OldUpperBodyTransition
	{
		public CarriedObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
