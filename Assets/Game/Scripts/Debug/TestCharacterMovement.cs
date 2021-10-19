using Game.Core.Services;
using UnityEngine;
using Zenject;

namespace Game.Experiment
{
    public class TestCharacterMovement : MonoBehaviour
    {
        private Vector3 _movementVector;
        private IInputService _inputService;

        [Inject]
        private void Construct(IInputService inputService)
        {
            _inputService = inputService;
        }

        private void OnEnable()
        {
            _inputService.OnMovementAction += OnMovementAction;
        }

        private void OnDisable()
        {
            _inputService.OnMovementAction -= OnMovementAction;
        }

        private void Update()
        {
            transform.Translate(_movementVector * Time.deltaTime * 5f);
        }

        private void OnMovementAction(Vector2 movement)
        {
            _movementVector = new Vector3(movement.x, 0, movement.y);
        }
    }
}