using Game.Core.Services;
using System;
using System.Collections.Generic;

namespace Game.Core.SaveSystem {
    public sealed class SaveService : ISaveService {
        private readonly static List<ISaveable> _saveables = new List<ISaveable>();

        public IEnumerable<ISaveable> Observers => _saveables;

        public void Add(ISaveable observer) {
            _saveables.Add(observer);
        }

        public void Remove(ISaveable observer) {
            _saveables.Remove(observer);
        }

        private static void SaveAll() {
            foreach(var saveable in _saveables) {
                saveable.Save();
            }
        }

        public void Save<T>(string key, T value, SaveType saveType = SaveType.Default) {
            throw new NotImplementedException();
        }

        public T Load<T>(string key, SaveType saveType = SaveType.Default) {
            throw new NotImplementedException();
        }
    }
}
