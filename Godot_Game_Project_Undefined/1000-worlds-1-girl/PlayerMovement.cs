using Godot;
using System;
using System.Numerics;

public partial class PlayerMovement : CharacterBody2D
{
	public const int SPEED = 350;

	Godot.Vector2 velocity = new Godot.Vector2();

	public void GetInput()
	{
		// Get input
		velocity = new Godot.Vector2();

		if (Input.IsActionPressed("up"))
		{
			velocity.Y -= 1;
			// GD.Print("Up was pressed");
		}
		if (Input.IsActionPressed("down"))
		{
			velocity.Y += 1;
			 // GD.Print("Down was pressed");
		}
		if (Input.IsActionPressed("right"))
		{
			velocity.X += 1;
			// GD.Print("Right was pressed");
		}
		if (Input.IsActionPressed("left"))
		{
			velocity.X -= 1;
			// GD.Print("Left was pressed");
		}

		// Set the velocity value in CharacterBody2D to the new vector
		Velocity = velocity.Normalized() * SPEED;
	}

	public override void _PhysicsProcess(double delta)
	{
		// Move character in 4 cardinal directions
		GetInput();
		MoveAndSlide();
	}
}
