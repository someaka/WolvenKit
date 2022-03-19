namespace WolvenKit.RED4.Types;

public partial class communitySpawnEntry
{
    partial void PostConstruct()
    {
        // TODO: Need to confirm, default__true_ is used in archive files
        SpawnInView = Enums.gameSpawnInViewState.true_;
    }
}
