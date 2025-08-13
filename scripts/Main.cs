 using Godot;
 using System;
 
 public partial class Main : Node2D
 {
 	public override void _Ready()
 	{
 		GD.Print("C# is ready!");
 	}
	
	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.A))
		{
			GD.Print("A key is pressed!");
		}
	}
 }
