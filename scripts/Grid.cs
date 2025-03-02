using Godot;
using System;

// Author : Silvera Netanel

namespace Com.IsartDigital.ProjectName
{
	public partial class Grid 
	{
		public Tile[,] tiles;
		private Vector2 screenSize; 
		
		public Grid (int pHeight, int pWidth, Vector2 pScreenSize)
		{
			tiles = new Tile[pHeight, pWidth];
			screenSize = pScreenSize;
            SetGrid();
        }

		public void OnShowGrid()
		{	
			GD.Print(tiles.Length);
            for (int y = 0; y < tiles.GetLength(0); y++)
            {
				for (int x = 0; x < tiles.GetLength(1); x++)
				{
					GD.Print(tiles[x, y]);	
				}
                
            }
		}
		
		public void SetGrid()
		{
			float ratioX = screenSize.X / tiles.GetLength(1); 
			float ratioY = screenSize.Y / tiles.GetLength(0);
			Vector2 offSet = new Vector2(ratioX / 2, ratioY / 2);
			Tile lActualTile; 

			for (int row = 0; row < tiles.GetLength(1); row++)
			{
				for (int col = 0; col < tiles.GetLength(0); col++)
				{
					lActualTile = new Tile(new Vector2(25, 25), "test"); 
					lActualTile.Position = offSet + lActualTile.Position with { X = lActualTile.Size.X * row, Y = lActualTile.Size.Y * col};
					tiles[row, col] = lActualTile;
					GD.Print(tiles[row, col].Position);
				}
			}
			
        }

		public void SetGraphicOnGrid(Node2D pNode)
		{
			PackedScene lPolygonScene = GD.Load<PackedScene>("res://scenes/Tile.tscn");
			Polygon2D lPolygon; 

            foreach (var tile in tiles)
			{
                lPolygon = lPolygonScene.Instantiate<Polygon2D>();
				lPolygon.Scale = lPolygon.Scale * 1.2f;
				lPolygon.Position = tile.Position;
				pNode.AddChild(lPolygon);
			}
		}

	}
}
