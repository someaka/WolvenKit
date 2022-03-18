
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestroyLink : redEvent
	{
		public DestroyLink()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
