using Godot;
using System;

// Author : Silvera Netanel

namespace Com.IsartDigital.ProjectName
{
	public partial class Grid 
	{
		public int[,] tiles;
		private Vector2 screenSize; 
		
		public Grid (int pHeight, int pWidth, Vector2 pScreenSize)
		{
			tiles = new int[pHeight, pWidth];
			screenSize = pScreenSize;
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

			for (int row = 0; row < tiles.GetLength(1); row++)
			{
				for (int col = 0; col < tiles.GetLength(0); col++)
				{
					GD.Print(tiles[row, col]);
				}
			}
        }

	}
}
