
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ActionEnum : ActionInt
	{
		public ActionEnum()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
