namespace WolvenKit.RED4.Types;

public partial class communitySpawnPhase
{
    partial void PostConstruct()
    {
        // TODO: Need to confirm, default__false_ is used in archive files
        AlwaysSpawned = Enums.gameAlwaysSpawnedState.false_;
    }
}
