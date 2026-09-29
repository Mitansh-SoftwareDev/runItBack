using Godot;

namespace RunItBack;

public abstract partial class player : CharacterBody2D
{
    public const float Speed = 200.0f;
    public const float JumpVelocity = -300.0f;
    public Vector2 spawn_point;
    
    [Export]
    public int playerHealth = 10;

    public gameManager _gamemanager;

    public override void _Ready()
    {
        _gamemanager = (gameManager)GetNode("/root/gameManager");
        _gamemanager._player = this;
    }
    
public override void _PhysicsProcess(double delta)
    {
        
        Vector2 velocity = Velocity;

        // Add the gravity.
        if (!IsOnFloor())
        {
            velocity += GetGravity() * (float)delta;
        }
        
        // Handle Animations.
        if (Velocity.Y > 0)
        {
            GetNode<AnimatedSprite2D>("AnimatedSprite2D").Play("fall");
        }
        if (Velocity.Y < 0)
        {
        GetNode<AnimatedSprite2D>("AnimatedSprite2D").Play("jump");
        }
        else if (Input.IsActionJustPressed("left"))
        {
            GetNode<AnimatedSprite2D>("AnimatedSprite2D").FlipH = true;
            GetNode<AnimatedSprite2D>("AnimatedSprite2D").Play("run");
        }
        else if (Input.IsActionJustPressed("right"))
        {
            GetNode<AnimatedSprite2D>("AnimatedSprite2D").FlipH = false;
            GetNode<AnimatedSprite2D>("AnimatedSprite2D").Play("run");
        }
        else if (velocity.Y == 0 & velocity.X == 0)
        {
            GetNode<AnimatedSprite2D>("AnimatedSprite2D").Play("idle");
        }

        // Handle Jump.
        if (Input.IsActionJustPressed("up") && IsOnFloor())
        {
            velocity.Y = JumpVelocity;
        }

        // Get the input direction and handle the movement/deceleration.
        // As good practice, you should replace UI actions with custom gameplay actions.
        Vector2 direction = Input.GetVector("left", "right", "up", "down");
        if (direction != Vector2.Zero)
        {
            velocity.X = direction.X * Speed;
        }
        else
        {
            velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
        }

        Velocity = velocity;
        MoveAndSlide();
        
        if (playerHealth <= 0)
        {
            Position = spawn_point;
            _gamemanager.alive = false;
        }
    }


}