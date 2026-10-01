using Godot;
using System;
using RunItBack;

public partial class Arrow : Node2D
{
	public gameManager _gamemanager;
	public RayCast2D _raycast;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_gamemanager = GetNode<gameManager>("/root/gameManager");
		_raycast = GetNode<RayCast2D>("RayCast2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!_raycast.IsColliding())
		{
			QueueFree();
		}

		Vector2 position = Position;
		position.X -= 1 * (float)delta;
		Position = position;
	}

	public void killPlayer(Node2D player)
	{
		if (player is player)
		{
			_gamemanager._player.playerHealth -= 5;
			GD.Print("player -5");
		}
	}
}
