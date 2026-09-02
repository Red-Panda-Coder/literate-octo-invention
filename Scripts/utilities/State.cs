using Godot;
using Game.Core;

namespace Game.Utilities
{
    public abstract partial class State : Node
    {
        [Export] public Node StateOwner;	

        public virtual void EnterState()
        {
            Core.Logger.Info($"Entering {GetType().Name} State");
        }

         public virtual void ExitState()
        {
            Core.Logger.Info($"Exiting {GetType().Name} State");
        }
    }
    }
