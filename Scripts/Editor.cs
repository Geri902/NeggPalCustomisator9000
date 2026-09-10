using Godot;
using System;
using System.Collections.Generic;

public partial class Editor : Node2D
{
	Dictionary<string, Image>[] images = { new Dictionary<string, Image>(), new Dictionary<string, Image>(), new Dictionary<string, Image>() };

	public override void _Ready()
	{
		LoadImages();
	}


	public override void _Process(double delta)
	{
	}

	private void LoadImages() // Too lazy to do it dynamycally
	{
		for (int i = 0; i < 3; i++)
		{
			images[i].Add("angry-fill", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-angry-fill.png").GetImage());
			images[i].Add("angry-outline", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-angry-outline.png").GetImage());
			images[i].Add("drool-mouth", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-drool-mouth.png").GetImage());
			images[i].Add("drool-outline", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-drool-outline.png").GetImage());
			images[i].Add("drool-tongue", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-drool-tongue.png").GetImage());
			images[i].Add("happy-fill", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-happy-fill.png").GetImage());
			images[i].Add("happy-outline", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-happy-outline.png").GetImage());
			images[i].Add("outline", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-outline.png").GetImage());
			images[i].Add("pog-eyes", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-pog-eyes.png").GetImage());
			images[i].Add("pog-mouth", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-pog-mouth.png").GetImage());
			images[i].Add("pog-outline", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-pog-outline.png").GetImage());
			images[i].Add("scared-fill", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-scared-fill.png").GetImage());
			images[i].Add("scared-outline", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-scared-outline.png").GetImage());
			images[i].Add("sleepy", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-sleepy.png").GetImage());
			images[i].Add("smug", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-smug.png").GetImage());
			images[i].Add("stem", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-stem.png").GetImage());
			images[i].Add("tail-base", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-tail-base.png").GetImage());
			images[i].Add("tail-top", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-tail-top.png").GetImage());
			images[i].Add("taunt-fill", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-taunt-fill.png").GetImage());
			images[i].Add("taunt-outline", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-taunt-outline.png").GetImage());
			images[i].Add("body", GD.Load<Texture2D>($"res://Assets/Pal_{i + 1}/{i+1}-body.png").GetImage());
		}
	}
}
