using Godot;
public partial class enemy : CharacterBody2D
{
	[ExportGroup("Physics")]
	[Export] public float Gravity = 980.0f;

	[ExportGroup("Combat")]
	[Export] public int MaxHealth = 3;
	[Export] public int ContactDamage = 1;
	[Export] public float AttackCooldown = 1.0f;

	public int Health;
	public float CooldownRemaining;


	public override void _PhysicsProcess(double delta)
	{
		float time = (float)delta;
		CooldownRemaining -= time;
		if (CooldownRemaining < 0.0f)
			CooldownRemaining = 0.0f;

		Vector2 velocity = Velocity;

        // Add the gravity.
        if (!IsOnFloor())
        {
            velocity += GetGravity() * (float)delta;
        }
		Velocity = velocity;
		MoveAndSlide();
	}
}
