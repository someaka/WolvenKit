
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IDisplayData : IScriptable
	{
		public IDisplayData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
