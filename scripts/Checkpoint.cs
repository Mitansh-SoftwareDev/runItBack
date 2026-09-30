using Godot;
using RunItBack;

public partial class Checkpoint : Node2D
{
    public void playerEntered(Node2D checkpoint)
    {
        if (checkpoint is player targetPlayer)
        {
            targetPlayer.spawn_point = GlobalPosition;

            GD.Print("Checkpoint reached!");
        }
    }
}