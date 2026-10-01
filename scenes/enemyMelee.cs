using Godot;
using System;
using RunItBack;

public partial class EnemyArcher : Enemy
{
    public RayCast2D rayLeft;
    public RayCast2D rayRight;
    
    public override void _Ready()
    {
        rayLeft = GetNode<RayCast2D>("rayLeft");
        rayRight = GetNode<RayCast2D>("rayRight");
    }

    public override void _Process(double delta)
    {
        base._Process(delta);

        if (rayLeft.IsColliding())
        {
            GD.Print("Ray Left is colliding with: " + rayLeft.GetCollider());
        }
        if (rayRight.IsColliding())
        {
            GD.Print("Ray Right is colliding with: " + rayRight.GetCollider());
        }
    }

}
