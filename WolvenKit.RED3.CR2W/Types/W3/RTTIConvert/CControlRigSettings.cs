using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CControlRigSettings : CObject
	{
		[Ordinal(1)] [RED("fkBonesNames_l1", 2,0)] 		public CArray<CName> FkBonesNames_l1 { get; set;}

		[Ordinal(2)] [RED("fkBones_l1", 2,0)] 		public CArray<CInt32> FkBones_l1 { get; set;}

		[Ordinal(3)] [RED("ikBonesNames", 2,0)] 		public CArray<CName> IkBonesNames { get; set;}

		[Ordinal(4)] [RED("ikBones", 2,0)] 		public CArray<CInt32> IkBones { get; set;}

		public CControlRigSettings(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}