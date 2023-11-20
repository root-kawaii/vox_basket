using Godot;
using System;

enum MENU_LEVEL
{
	NONE,
	MAIN,
	START,
	JOIN,
	OPTIONS
}

public partial class main : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var gameState = (GameState)GetNode("/root/GameStates");
		gameState.load_menu(MENU_LEVEL.MAIN);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
