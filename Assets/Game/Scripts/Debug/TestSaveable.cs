using Game.Core.SaveSystem;
using Game.Core.Services;
using UnityEngine;
using Zenject;

namespace Game.Experiment
{
    public class TestSaveable : MonoBehaviour, ISaveable
    {
        private ISaveService _saveService;

        private TestCharacterRepository _repository;
        
        [Inject]
        public void Construct(ISaveService saveService, TestCharacterRepository repository)
        {
            _saveService = saveService;
            _repository = repository;
        }

        private void OnEnable()
        {
            _saveService.RegisterListener(this);
        }

        private void OnDisable()
        {
            _saveService.UnregisterListener(this);
        }

        void ISaveable.OnSave()
        {
            const int testValue = 0;
            Debug.Log($"Saving value {testValue}");
            _repository.SaveTestValue(testValue);
        }

        void ISaveable.OnLoad()
        {
            var testValue = _repository.LoadTestValue();
            Debug.Log($"Loading value {testValue}");
        }
    }
}