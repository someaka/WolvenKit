
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleComponentWithCounter : gameScriptableComponent
	{
		public SampleComponentWithCounter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
