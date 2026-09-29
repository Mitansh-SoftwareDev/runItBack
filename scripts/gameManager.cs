using Godot;
using System;

namespace RunItBack;

public partial class gameManager : Node
{
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
}
