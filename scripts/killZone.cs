using Godot;
using System;
using RunItBack;

public partial class killZone : Node2D
{
	public player _player;
	
	public void playerEntered(Node2D killing)
	{
		if (killing is player)
		{
			_player = (player)killing;
		}

		_player.playerHealth = 0;
		GD.Print("player entered");
	}
}
