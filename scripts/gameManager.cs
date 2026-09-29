using Godot;
using System;

namespace RunItBack;

public partial class gameManager : Node
{
    
    public player _player;

    [Export]
    public int enemyHealth = 8;
    [Export]
    public int damage = 0;
    [Export]
    public bool alive = true;
    [Export]
    public int balance = 0;
    [Export]
    public int score = 0;

    public override void _PhysicsProcess(double delta)
    {
        if (!alive)
        {
            _player.playerHealth = 10;
            GD.Print(_player.playerHealth);
        }
    }
}

