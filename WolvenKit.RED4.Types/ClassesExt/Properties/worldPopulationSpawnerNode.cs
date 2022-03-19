namespace WolvenKit.RED4.Types;

public partial class worldPopulationSpawnerNode
{
    partial void PostConstruct()
    {
        // TODO: Need to confirm, default__false_ is used in archive files
        AlwaysSpawned = Enums.gameAlwaysSpawnedState.false_;

        // TODO: Need to confirm, default__true_ is used in archive files
        SpawnInView = Enums.gameSpawnInViewState.true_;
    }
}
