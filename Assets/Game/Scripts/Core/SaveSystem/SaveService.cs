using Game.Core.Services;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Game.Core.SaveSystem {
    public sealed class SaveService : ISaveService {
        private IInputService _inputService;
        private readonly static List<ISaveable> _saveables = new List<ISaveable>();

        public IEnumerable<ISaveable> Observers => _saveables;

        [Inject]
        public void Construct(IInputService inputService) {
            _inputService = inputService;

            _inputService.OnQuickSaveAction += QuickSave;
            _inputService.OnQuickLoadAction += QuickLoad;
        }

        ~SaveService() {
            if(_inputService != null) {
                _inputService.OnQuickSaveAction -= QuickSave;
                _inputService.OnQuickLoadAction -= QuickLoad;
            }
        }

        private void QuickSave() {
            foreach (var saveable in _saveables) {
                saveable.Save();
            }
        }

        private void QuickLoad() {
            foreach (var saveable in _saveables) {
                saveable.Load();
            }
        }

        public void Add(ISaveable observer) {
            _saveables.Add(observer);
        }

        public void Remove(ISaveable observer) {
            _saveables.Remove(observer);
        }

        public void Save<T>(string key, T value, SaveType saveType = SaveType.Default) {
            Debug.Log($"Saving value {value} with key {key}");
        }

        public T Load<T>(string key, SaveType saveType = SaveType.Default) {
            Debug.Log($"Loading value for key {key}");
            return default(T);
        }
    }
}
