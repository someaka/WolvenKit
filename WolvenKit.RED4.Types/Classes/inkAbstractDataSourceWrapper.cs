
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkAbstractDataSourceWrapper : IScriptable
	{
		public inkAbstractDataSourceWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
