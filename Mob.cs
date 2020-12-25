using Godot;
using System;

public class Mob : RigidBody2D
{
	
	[Export]
	public int MinSpeed = 150;
	[Export]
	public int MaxSpeed = 250;

	static private Random _random = new Random();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var animSprite = GetNode<AnimatedSprite>("AnimatedSprite");
		var mobTypes = animSprite.Frames.GetAnimationNames();
		animSprite.Animation = mobTypes[_random.Next(0, mobTypes.Length)];
	}

	public void OnVisibilityNotifier2DScreenExited()
	{

	}
}


