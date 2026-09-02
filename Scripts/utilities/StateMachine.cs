using Godot;
using System;
namespace Game.Utilities
{
public partial class StateMachine : Node
{

	[ExportCategory("State Machine Var")]
	[Export] public Node Customer;	
	[Export] public State CurrentState;	
	

	public override void _Ready()
	{
		
	}
	


}

}
