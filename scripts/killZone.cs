using Godot;
using RunItBack;

public partial class killZone : Node2D
{
    public void playerEntered(Node2D killing)
    {
        if (killing is player targetPlayer)
        {
            targetPlayer.playerHealth = 0;

            GD.Print("Player entered KillZone!");
        }
    }
}