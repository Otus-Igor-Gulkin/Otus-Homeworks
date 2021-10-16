using Game.Core.SaveSystem;
using Game.Core.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Game.Experiment
{
    public class TestSaveable : MonoBehaviour, ISaveable {
        private ISaveService _saveService;

        [Inject]
        public void Construct(ISaveService saveService) {
            _saveService = saveService;
        }

        private void OnEnable() {
            Register();
        }

        private void OnDisable() {
            Unregister();
        }

        public void Save() {
            _saveService.Save("TestInt", 0);
        }

        public void Load() {
            _saveService.Load<int>("TestInt");
        }

        public void Register() {
            _saveService.Add(this);
        }

        public void Unregister() {
            _saveService.Remove(this);
        }
    }
}
