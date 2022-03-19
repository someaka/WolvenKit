namespace WolvenKit.RED4.Types;

public partial class questSwitchNodeDefinition
{
    partial void PostConstruct()
    {
        // TODO: Need to confirm, First_Fulfilled is used in archive files
        Behaviour = Enums.questESwitchBehaviourType.All_Fulfilled;
    }
}
