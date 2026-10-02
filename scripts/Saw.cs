using Godot;
using System;
using RunItBack;
using gameManager = RunItBack.gameManager;

public partial class Saw : Node2D
{
	public gameManager _gamemanager;
	public RayCast2D _raycast;
	public RayCast2D _raycast2;
	public AnimatedSprite2D _sprite;
	public float valueMove = 25;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_gamemanager = GetNode<gameManager>("/root/GameManager");
		_raycast = GetNode<RayCast2D>("RayCast2D");
		_raycast2 = GetNode<RayCast2D>("RayCast2");
		_sprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		_sprite.Play("default");

	
}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (!_raycast.IsColliding() && _sprite.FlipH == false)
		{
			Vector2 position = Position;
			position.X -= valueMove * (float)delta;
			Position = position; 
		}
		else if (!_raycast2.IsColliding() && _sprite.FlipH == true)
		{
			Vector2 position = Position;
			position.X += valueMove * (float)delta;
			Position = position; 
		}
		if (_raycast.IsColliding())
		{
			_sprite.FlipH = true;
		}
		if (_raycast2.IsColliding())
		{
			_sprite.FlipH = false;
		}
	}

	public void sawKill(Node2D player)
	{
			_gamemanager._player.playerHealth -= 6;
			GD.Print("Player hit");
			GD.Print(" saw player -6");
			_sprite.Play("saw hit");
	}
}
