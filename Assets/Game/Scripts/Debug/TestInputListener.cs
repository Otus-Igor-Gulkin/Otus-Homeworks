using Game.Core.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Game.Experiment
{
    public class TestInputListener : MonoBehaviour
    {
        private IInputService _inputService;

        [Inject]
        private void Construct(IInputService inputService) {
            _inputService = inputService;
        }

        private void OnEnable() {
            _inputService.OnMovementAction += OnMovementAction;
        }

        private void OnDisable() {
            _inputService.OnMovementAction -= OnMovementAction;
        }

        private void OnMovementAction(Vector2 movement) {
            Debug.Log($"Moving to: {movement}");
        }
    }
}
