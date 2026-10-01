using Godot;
using System;
using RunItBack;
using Range = Godot.Range;

public partial class healthBar : ProgressBar
{
	StyleBoxFlat bgStyle = new StyleBoxFlat();
	
	public double percent;
	
	public gameManager _gamemanager;

	public RichTextLabel textLabel;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_gamemanager = GetNode<gameManager>("/root/GameManager");
		textLabel = GetNode<RichTextLabel>("RichTextLabel");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		percent = Value / MaxValue;
		
		Value = _gamemanager._player.playerHealth;
		MaxValue = 10;
		if (_gamemanager._player.playerHealth > 10)
		{
			MaxValue = _gamemanager._player.playerHealth;
			Value = MaxValue;
		}

		if (percent >= 1)
		{
			bgStyle.BgColor = Colors.DarkGreen;
			AddThemeStyleboxOverride("background", bgStyle);
		}
		 if (percent <= .75)
		{
			bgStyle.BgColor = Colors.DarkOrange;
			AddThemeStyleboxOverride("background", bgStyle);
		}
		 if (percent <= .50)
		{
			bgStyle.BgColor = Colors.OrangeRed;
			AddThemeStyleboxOverride("background", bgStyle);
		}
		 if (percent <= .25)
		{
			bgStyle.BgColor = Colors.DarkRed;
			AddThemeStyleboxOverride("background", bgStyle);
		}
		if (MaxValue > 10 && Value > 10)
		{
			bgStyle.BgColor = Colors.Purple;
			AddThemeStyleboxOverride("background", bgStyle);
			textLabel.Visible = true;
			textLabel.Text = "Health Power On Health Surplus: " + (Value - 10);
		}
		if (Value < 10 || MaxValue == 10)
		{
			textLabel.Visible = false;
		}
	}
}
