using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Core.Services {
    public interface IInputService {
        event Action<Vector2> OnMovementAction;
    }
}
