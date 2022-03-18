
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entIPositionProvider : IScriptable
	{
		public entIPositionProvider()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
