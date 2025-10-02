 using Godot;
 using System;
 
 public partial class Main : Node2D
 {
	private int _count = 0;
	
 	public override void _Ready()
 	{
 		GD.Print("C# is ready!");
 	}
	
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("KeyEnter"))
		{
			_count++;
		}
		GD.Print(_count);
	}	
 }
