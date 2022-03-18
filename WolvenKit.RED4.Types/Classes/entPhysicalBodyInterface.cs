
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPhysicalBodyInterface : IScriptable
	{
		public entPhysicalBodyInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
