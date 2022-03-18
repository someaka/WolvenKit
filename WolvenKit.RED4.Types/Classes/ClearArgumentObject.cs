
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ClearArgumentObject : SetArguments
	{
		public ClearArgumentObject()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
