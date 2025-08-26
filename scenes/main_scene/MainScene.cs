using Godot;
using System;

public partial class MainScene : Node2D
{
	private Label _number_of_lines;
	private double _count = 0;
	
	private double _number_of_engineer = 0.0;
	
	public override void _Ready()
	{
		_number_of_lines = GetNode<Label>("Number_of_lines");
		_number_of_lines.Text = "Number of lines: 0";
	}
	
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("KeyA"))
		{
			_count = _count + 10.0;
		}
		
		if (Input.IsActionJustPressed("KeyJ"))
		{
			_number_of_engineer = _number_of_engineer + 0.01;
		}		
		_count = _count + _number_of_engineer;
		_number_of_lines.Text = $"Number of lines: {Math.Floor(_count)}";
	}
}
