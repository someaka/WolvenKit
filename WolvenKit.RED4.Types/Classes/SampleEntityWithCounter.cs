
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleEntityWithCounter : gameObject
	{
		public SampleEntityWithCounter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
