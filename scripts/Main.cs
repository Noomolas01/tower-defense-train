using Godot;
using System;

// Author : Silvera Netanel

namespace Com.IsartDigital.ProjectName
{
	public partial class Main : Node2D
	{
		#region Singleton
		static private Main instance;

		private Main()
		{

		}

		static public Main GetInstance()
		{
			if (instance == null) instance = new Main();
			return instance;
		}

		#endregion
		private Vector2 screenSize;
		Grid myGrid; 

		public override void _Ready()
		{
			#region Singleton
			if (instance != null)
			{
				QueueFree();
				GD.Print(nameof(Main) + "Instance already exists, destroying the last added");
				return;
			}

			instance = null;

			#endregion
			screenSize = GetWindow().Size;
			myGrid = new Grid(10, 10, screenSize);
			//myGrid.OnShowGrid();
			myGrid.SetGrid(); 
		}

		public override void _Process(double pDelta)
		{
			float lDelta = (float)pDelta;
		}

		protected override void Dispose(bool pDisposing)
		{
			instance = null; 
			base.Dispose(pDisposing);
		}
	}
}
