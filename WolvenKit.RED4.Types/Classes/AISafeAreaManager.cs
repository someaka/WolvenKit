
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISafeAreaManager : AIISafeAreaManager
	{
		public AISafeAreaManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
