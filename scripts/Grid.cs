using Godot;
using System;

// Author : Silvera Netanel

namespace Com.IsartDigital.ProjectName
{
	public partial class Grid
	{
		private Tile[,] tiles;

		public readonly Vector2 TILE_SIZE;
		public readonly int ROW_LENGTH;
        public readonly int COLUMN_LENGTH;

        public Grid(int pGridSize, Vector2 pTileSize)
		{
			tiles = new Tile[pGridSize, pGridSize];
			TILE_SIZE = pTileSize;

			ROW_LENGTH = tiles.GetLength(0);
            COLUMN_LENGTH = tiles.GetLength(1);
			InitTile();
        }

		private void InitTile()
		{
			Tile lActualTile;

			for (int row = 0; row < ROW_LENGTH; row++)
			{
				for(int column = 0; column < COLUMN_LENGTH; column++)
				{
					lActualTile = new Tile(TILE_SIZE);
					lActualTile.Position = new Vector2
						(
						lActualTile.Size.X / 2f +  row * lActualTile.Size.X,
                        lActualTile.Size.Y / 2f + column * lActualTile.Size.Y
                        );

					tiles[row, column] = lActualTile;
				}
			}
		}

		public void InstantiateGraphicalTile(Node pContainer)
		{
			PackedScene lGraphTileScene = GD.Load<PackedScene>("res://scenes/graphical_tile.tscn");
			Polygon2D lPolygon;

			for (int row = 0; row < ROW_LENGTH; row++)
			{
				for (int column = 0; column < COLUMN_LENGTH; column++)
				{
					lPolygon = lGraphTileScene.Instantiate<Polygon2D>();
					lPolygon.Position = tiles[row, column].Position;
					//pContainer.AddChild(lPolygon);
				}
			}
		}

		public void Print()
		{
			foreach (Tile tile in tiles) GD.Print(tile.Position);
		}


	}
}
