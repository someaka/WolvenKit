using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EmptyHandsDecisions : UpperBodyTransition
	{
		[Ordinal(0)] [RED("stateBodyDone")] public CBool StateBodyDone { get; set; }

		public EmptyHandsDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}