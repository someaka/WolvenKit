
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRuntimeSystemWeather : worldIRuntimeSystem
	{
		public worldRuntimeSystemWeather()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
