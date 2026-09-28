using Godot;
using System;
using RunItBack;

public partial class killZone : Node
{
	
	public void playerEnter(Node2D killing)
	{
		_player.playerHealth = 0;
		GD.Print("player entered");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
