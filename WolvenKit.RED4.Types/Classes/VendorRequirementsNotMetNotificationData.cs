using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorRequirementsNotMetNotificationData : IScriptable
	{
		private gameSItemStackRequirementData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public gameSItemStackRequirementData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
