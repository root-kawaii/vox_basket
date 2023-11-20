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



public partial class GameState : Node
{

	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}


	public void LoadMenu(int menuLevel)
	{
		CallDeferred("_DeferredLoadMenu", menuLevel);
	}

	private void _DeferredLoadMenu(int menuLevel)
	{
		// Replace the current menus instance with the new ones
		Node currentMenu = menus[menuLevel];

		Node container = currentScene.FindNode("menu", false, false) as Node;
		if (container == null)
		{
			Node menuNode = new Node();
			menuNode.Name = "menu";
			currentScene.AddChild(menuNode);
			container = menuNode;
		}

		// Clear the current menu item/s
		foreach (Node location in container.GetChildren())
		{
			container.RemoveChild(location);
		}

		// Add our selected menu
		container.AddChild(currentMenu);
	}
}










