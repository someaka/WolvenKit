
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class workSelector : workRandomList
	{
		public workSelector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
