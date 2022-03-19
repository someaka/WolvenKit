namespace WolvenKit.RED4.Types;

public partial class questVehicleCommandParams
{
    partial void PostConstruct()
    {
        // TODO: Need to confirm, Move_On_Spline, Follow and Racing is used in archive files
        Type = Enums.questVehicleCommandType.Move_To;
    }
}
