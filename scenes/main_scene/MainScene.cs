using Godot;
using System;

public partial class MainScene : Node2D
{
	private Label _number_of_lines;
	private Label _bug_ratio_label;
	private Label _number_of_engineers_label;
	
	private double _totalCodeLines = 0;
	private double _workingCodeLines = 0;
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
		// Aを押した時コード行数を増やす
		if (Input.IsActionJustPressed("KeyA"))
		{
			_totalCodeLines = _totalCodeLines + 10.0;
		}
		
		// Dを押した時バグ発生率を減らす
		if (Input.IsActionJustPressed("KeyD"))
		{
			_bug_ratio = Math.Clamp(_bug_ratio - 0.1, 0.0, 1.0);
		}
		
		// Jを押した時エンジニア数を増やす
		if (Input.IsActionJustPressed("KeyJ"))
		{
			_number_of_engineers = _number_of_engineers + 0.01;
		}
		
		// Lを押した時QAの数を増やす
		if (Input.IsActionJustPressed("KeyL"))
		{
			
		}
		
		// Debug
		if (Input.IsActionJustPressed("KeyEnter"))
		{
			_bug_ratio = Math.Clamp(_bug_ratio + 0.1, 0.0, 1.0);
		}		
		
		_totalCodeLines = _totalCodeLines + _number_of_engineers;
		_workingCodeLines = _totalCodeLines * (1 - _bug_ratio);
		
		_number_of_lines.Text = $"Number of lines: {Math.Round(_workingCodeLines)}";
		_bug_ratio_label.Text = $"Bug ratio: {Math.Round(_bug_ratio * 100)}%";
		_number_of_engineers_label.Text = $"Number of engineers: {_number_of_engineers * 100}";
	}
}
