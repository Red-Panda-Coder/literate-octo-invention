using Godot;
using Game.Core;
using System;
using System.Runtime.InteropServices.JavaScript;


namespace Game.Gameplay
{



    public partial class PlayerInput : Node
    {
        [ExportCategory("Player Imput")]
        [Export] public double HoldThreshhol = 0.1f;
        [Export] public double HoldTime = 0.0f;

        public override void _Ready()
        {
        }

    }

}