using Godot;
using System;
using RunItBack;

public partial class Checkpoint : Node2D
{
	public player _player;
	
	[Export]
	public Vector2 playerPos =  new Vector2(0, 0); 
	public void playerEntered(Node2D checkpoint)
	{
		GD.Print("player entered");
		playerPos = checkpoint.GlobalPosition;

		if (checkpoint is player)
		{
			_player.spawn_point = playerPos;
		}
		
	} 
}
