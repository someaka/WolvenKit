
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class IScriptable : ISerializable
	{
		public IScriptable()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
