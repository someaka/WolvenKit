
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class CFrustum : RedBaseClass
	{
		public CFrustum()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
