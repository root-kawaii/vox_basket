using System;
using System.Collections.Generic;
using Godot;
using Godot.Collections;

public partial class Player : CharacterBody3D
{
	// How fast the player moves in meters per second.
	[Export]
	public int Speed { get; set; } = 14;

	public int pos = 0;
	private Array<Node3D> squares = new Array<Node3D>();
	// The downward acceleration when in the air, in meters per second squared.
	[Export]
	public int FallAcceleration { get; set; } = 75;

	private Vector3 _targetVelocity = Vector3.Zero;


	public override void _Ready()
	{

		Node3D step = (Node3D)GetNode("../Arena");
		foreach (Node x in step.GetChildren())
		{
			squares.Add((Node3D)x);
		}
		var actionMenu = (Player)GetNode("../MenuBar/ActionMenu");
		var actions = actionMenu.GetChildren();
		this.Position = squares[0].Position + new Godot.Vector3(0, 1, 0);
		// _bar.MaxValue = actionMenu.
	}


	private void _on_texture_button_pressed()
	{
		pos = 1 + pos;
		Console.Write(squares[pos].Position);
		this.Position = squares[pos].Position + new Godot.Vector3(0, 1, 0);
	}

	private void _on_texture_button_2_pressed()
	{
		pos = -1 + pos;
		Console.Write(squares[pos].Position);
		this.Position = squares[pos].Position + new Godot.Vector3(0, 1, 0);
	}



	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("move_backward"))
		{
			Console.Write(squares[5].Position);
			this.Position = squares[5].Position + new Godot.Vector3(0, 1, 0);
		}
	}


}