using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

public partial class Tile
{
    public Vector2 Position { get; set; }
    public List<string> Values { get; set; }
    public Vector2 Size { get; set; }
    public Tile(Vector2 pSize, params string[] pValues)
    {
        Size = pSize;
        Values = pValues.ToList();
    }
}
