using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneInstanceOwnerId : CVariable
	{
		private CUInt64 _hash;

		[Ordinal(0)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		public scnSceneInstanceOwnerId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}