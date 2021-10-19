using System;
using UnityEngine;

namespace Game.Core.Services
{
    public interface IInputService
    {
        event Action<Vector2> OnMovementAction;

        event Action OnQuickSaveAction;
        
        event Action OnQuickLoadAction;
    }
}