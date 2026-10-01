using Godot;
using System;
using RunItBack;

public partial class enemyArcher : enemy
{
    public RayCast2D rayLeft;
    public RayCast2D rayRight;
    
    public override void _Ready()
    {
        rayLeft = GetNode<RayCast2D>("rayLeft");
        rayRight = GetNode<RayCast2D>("rayRight");
    }

    public void _process(double delta)
    {
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
