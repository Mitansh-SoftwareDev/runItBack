using Godot;
using System;
using RunItBack;

public partial class enemyArcher : Enemy
{

	private bool active = false;
	private bool ableToShoot = true;
	private float shootTimer = 1f;
	private float shootCooldown = 2f;
	public player _player;

public override void _Process(double delta)
{
	if (active)
	{
		if (ableToShoot)
		{
			GD.Print("Player is in range");
			ableToShoot = false;
			shootTimer = shootCooldown;
		}
	}

	if (shootTimer <= 0)
	{
		ableToShoot = true;
	}
	else
	{
		shootTimer -= (float)delta;
	}

}
private void _on_detect_radius_body_entered(Node2D  body)
{
	GD.Print("Player body entered " + body);
	if (body is player)
	{
		_player = (player)body;
		active = true;
	}
}

private void _on_detect_radius_body_exited(Node2D  body)
{
	GD.Print("Player body exited " + body);
	if (body is player)
	{
		active = false;
	}
}
}
