using Godot;
using System;

public partial class MainScene : Node2D
{
	private Label _number_of_lines;
	private Label _bug_ratio_label;
	private Label _number_of_engineers_label;
	
	private double _count = 0;
	private double _bug_ratio = 0;
	private double _number_of_engineers = 0.0;
	
	private double _increment = 0.0;
	
	public override void _Ready()
	{
		_number_of_lines = GetNode<Label>("Number_of_lines");
		_number_of_lines.Text = "Number of lines: 0";
		
		_bug_ratio_label = GetNode<Label>("Bug_ratio");
		_bug_ratio_label.Text = "Bug ratio: 0%";
		
		_number_of_engineers_label = GetNode<Label>("Number_of_engineers");
		_bug_ratio_label.Text = "Number of engineers: 0";
	}
	
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("KeyA"))
		{
			_count = (_count + 10.0) * (1 - _bug_ratio);
		}
		
		if (Input.IsActionJustPressed("KeyJ"))
		{
			_number_of_engineers = _number_of_engineers + 0.01;
			_increment = _number_of_engineers * (1 - _bug_ratio);
		}
		
		// Debug
		if (Input.IsActionJustPressed("KeyEnter"))
		{
			_bug_ratio = _bug_ratio + 0.1;
		}		
		
		_count = _count + _increment;
		
		_number_of_lines.Text = $"Number of lines: {Math.Floor(_count)}";
		_bug_ratio_label.Text = $"Bug ratio: {_bug_ratio * 100}%";
		_number_of_engineers_label.Text = $"Number of engineers: {_number_of_engineers * 100}";
	}
}
