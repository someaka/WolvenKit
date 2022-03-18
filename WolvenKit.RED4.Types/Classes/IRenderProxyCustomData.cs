
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IRenderProxyCustomData : RedBaseClass
	{
		public IRenderProxyCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
