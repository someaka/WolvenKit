using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitializeFocusCluesEvent : redEvent
	{
		private entEntityID _requesterID;

		[Ordinal(0)] 
		[RED("requesterID")] 
		public entEntityID RequesterID
		{
			get => GetProperty(ref _requesterID);
			set => SetProperty(ref _requesterID, value);
		}

		public InitializeFocusCluesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}