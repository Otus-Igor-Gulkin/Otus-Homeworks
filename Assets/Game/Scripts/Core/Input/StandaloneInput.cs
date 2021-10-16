using Game.Core.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Core.Input {
    public sealed class StandaloneInput : MonoBehaviour, IInputService {
        public event Action<Vector2> OnMovementAction;

        public event Action OnQuickSaveAction;
        public event Action OnQuickLoadAction;

        public void OnMovement(InputAction.CallbackContext ctx) {
            var movement = ctx.ReadValue<Vector2>();

            if (ctx.phase == InputActionPhase.Performed || ctx.phase == InputActionPhase.Canceled) {
                OnMovementAction?.Invoke(movement);
            }
        }

        public void OnQuickSave(InputAction.CallbackContext ctx) {
            if(ctx.phase == InputActionPhase.Started) {
                OnQuickSaveAction?.Invoke();
            }
        }

        public void OnQuickLoad(InputAction.CallbackContext ctx) {
            if (ctx.phase == InputActionPhase.Started) {
                OnQuickLoadAction?.Invoke();
            }
        }
    }
}