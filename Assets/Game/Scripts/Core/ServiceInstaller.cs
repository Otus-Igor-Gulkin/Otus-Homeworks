using Game.Core.Input;
using Game.Core.SaveSystem;
using Game.Core.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Game.Core {
    public class ServiceInstaller : MonoInstaller {
        [SerializeField]
        private StandaloneInput _standaloneInput;

        public override void InstallBindings() {
            Container.Bind<IInputService>().FromComponentInNewPrefab(_standaloneInput).AsSingle().NonLazy();
            Container.Bind<ISaveService>().To<SaveService>().AsSingle().NonLazy();
        }
    }
}