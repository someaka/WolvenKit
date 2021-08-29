using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeadContextDecisions : InputContextTransitionDecisions
	{
		private CHandle<redCallbackObject> _callbackID;

		[Ordinal(0)] 
		[RED("callbackID")] 
		public CHandle<redCallbackObject> CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}
	}
}
