namespace WolvenKit.RED4.Types;

public partial class SetGameplayRoleEvent
{
    partial void PostConstruct()
    {
        // TODO: Need to confirm, UnAssigned(0) is used in archive files
        GameplayRole = Enums.EGameplayRole.None;
    }
}
