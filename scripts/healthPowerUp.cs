using Godot;
using System;
using RunItBack;

public partial class healthPowerUp : Node2D
{
	public gameManager _gamemanager;

	public override void _Ready()
	{
		_gamemanager = GetNode<gameManager>("/root/GameManager");
	}

	public void healthActivate(Node2D player)
		{
			if (player is player)
			{
				GD.Print(_gamemanager);
				GD.Print(_gamemanager._player);
				GD.Print(_gamemanager._player.playerHealth);
				_gamemanager._player.playerHealth = 15;
				
				GD.Print("health activated - Health Now 15!");
				QueueFree();
			}
		}
}
