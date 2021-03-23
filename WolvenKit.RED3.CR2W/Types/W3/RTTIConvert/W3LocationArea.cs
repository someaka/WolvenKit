using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LocationArea : CGameplayEntity
	{
		[Ordinal(1)] [RED("locationNameKey")] 		public CName LocationNameKey { get; set;}

		[Ordinal(2)] [RED("rewardName")] 		public CName RewardName { get; set;}

		[Ordinal(3)] [RED("discovered")] 		public CBool Discovered { get; set;}

		public W3LocationArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LocationArea(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}