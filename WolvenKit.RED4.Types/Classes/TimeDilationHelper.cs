
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeDilationHelper : IScriptable
	{
		public TimeDilationHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
