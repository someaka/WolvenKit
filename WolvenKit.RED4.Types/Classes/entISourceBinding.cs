
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entISourceBinding : entIBinding
	{
		public entISourceBinding()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
