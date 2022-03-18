
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameActionInternalEvent : IScriptable
	{
		public gameActionInternalEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
