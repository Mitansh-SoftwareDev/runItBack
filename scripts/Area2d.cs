using Godot;
using System;
using RunItBack;

public partial class Area2d : Area2D
{
	
	public gameManager _gamemanager;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_gamemanager = GetNode<gameManager>("/root/GameManager");;
	}
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public void spikeOn(Node2D Body)
	{
		if (Body is player)
		{
			_gamemanager._player.playerHealth -= 2;
			GD.Print("spikeOn");
		}
	}
}
