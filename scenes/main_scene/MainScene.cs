using Godot;
using System;

public partial class MainScene : Node2D
{
	private Label _number_of_lines;
	private int _count = 0;
	
	public override void _Ready()
	{
		_number_of_lines = GetNode<Label>("Number_of_lines");
		_number_of_lines.Text = "Number of lines: 0";
	}
	
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("KeyEnter"))
		{
			_count++;
			_number_of_lines.Text = $"Number of lines: {_count}";
		}
	}
}
