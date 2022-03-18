
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConstantStatPoolPrereq : StatPoolPrereq
	{
		public ConstantStatPoolPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
