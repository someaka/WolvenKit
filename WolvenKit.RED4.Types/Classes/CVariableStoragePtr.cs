
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	[REDClass(SerializeDefault = true)]
	public partial class CVariableStoragePtr : RedBaseClass
	{
		public CVariableStoragePtr()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
