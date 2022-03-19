namespace WolvenKit.RED4.Types;

public partial class worldMeshNode
{
    partial void PostConstruct()
    {
        // TODO: Need to confirm, Default is used in archive files
        OccluderType = Enums.visWorldOccluderType.None;
    }
}
