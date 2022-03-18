
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IMaterial : CResource
	{
		public IMaterial()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
