using Game.Core;
using Godot;
using System;

namespace Game.Gameplay

{
	
	public partial class CharacterMovement : Node
	{
		[Signal] public delegate void AnimationEventHandler();	
		
		[ExportCategory("Nodes")]
		[Export] public Node2D Character;
		[Export] public CharacterInput CharacterInput;
		[ExportCategory("Movement")]
		[Export] public Vector2 TargetPosition = Vector2.Down;
		[Export] public bool IsWalking = false;
 
			
			//Need to figure out why I needed to add .Core before Logger, 
			//This was not needed in tutorial
		public override void _Ready()
		{
			Core.Logger.Info("Loading Character Movement component ...");

		}


		public override void _Process(double delta)
		{
			
		}	


		public bool IsMoving()
		{
			return IsWalking;
		}
		public void StartWalking()
		{
			if (!IsMoving())
			{
				//TODO Walk animation needs to be added
				TargetPosition = Character.Position + CharacterInput.Direction * Globals.Instance.GRID_SIZE;
				Core.Logger.Info($"Character is moving from {Character.Position} to {TargetPosition}");
				IsWalking = true;
			}
			else
			{
				Core.Logger.Warning("Character is already moving, cannot start walking.");
			}

			
		}
		public void Walk(double delta)
		{
			if (IsWalking)
			{
				Character.Position = Character.Position.MoveToward(TargetPosition, (float)delta * Globals.Instance.GRID_SIZE * 4 );
				if (Character.Position.DistanceTo(TargetPosition) <1f)
				{
					StopWalking();
				}
			}
			else
			{
				//TO: Idle Animation
			}
		}	

		public void StopWalking()
		{
			IsWalking = false;
			SnapPositionToGrid();
		}

		public void Turn()
		{
			//TOODO: Turn Animation
		}


		public void SnapPositionToGrid()
		{
			Character.Position = new Vector2(
				Mathf.Round(Character.Position.X / Globals.Instance.GRID_SIZE) * Globals.Instance.GRID_SIZE,
				Mathf.Round(Character.Position.Y / Globals.Instance.GRID_SIZE) * Globals.Instance.GRID_SIZE
			);
		}





	}
}
