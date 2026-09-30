using Godot;
using System;
using RunItBack;

public partial class healthPowerUp : Node2D
{
	public gameManager _gameManager;

	public override void _Ready()
	{
		_gameManager = GetNode<gameManager>("/root/gameManager");
	}

	public void healthActivate(Node2D _player)
		{
			if (_player is player)
			{
				_gameManager._player.playerHealth = 15;
				GD.Print("health activated - Health Now 15!");
			}
		}
}
