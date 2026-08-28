using Godot;
using Game.Core;
using System;
using System.Runtime.InteropServices.JavaScript;


namespace Game.Gameplay;




    public abstract partial class CharacterInput : Node
    {   
        [Signal] public delegate void WalkEventHandler();
        [Signal] public delegate void TurnEventHandler();


       [ExportCategory("Common Input")]
       [Export] public Vector2 Direction = Vector2.Zero;
       [Export] public Vector2 TargetPosition = Vector2.Zero;


    }

