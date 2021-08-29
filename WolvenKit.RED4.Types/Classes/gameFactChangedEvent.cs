using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFactChangedEvent : redEvent
	{
		private CName _factName;

		[Ordinal(0)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}
	}
}
