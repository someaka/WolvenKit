
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class redEvent : IScriptable
	{
		public redEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
