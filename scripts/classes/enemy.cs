using Godot;

public partial class Enemy : CharacterBody2D
{
	[Export] 
	public int Health = 4;
	[Export] 
	public int Damage = 1;
	[Export] 
	public float Speed = 60f;
	[Export] 
	public float Gravity = 900f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		if (!IsOnFloor())
		{
			velocity.Y += Gravity * (float)delta;
		}

		Velocity = velocity;
		MoveAndSlide();
	}

	public void TakeDamage(int amount)
	{
		Health -= amount;

		if (Health <= 0)
		{
			QueueFree();
		}
	}
}