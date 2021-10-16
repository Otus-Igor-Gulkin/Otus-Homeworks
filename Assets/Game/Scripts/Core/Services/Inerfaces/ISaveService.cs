using Game.Core.SaveSystem;
using Game.Core.Types;

namespace Game.Core.Services {
    public interface ISaveService : IObservable<ISaveable> {
        public void Save<T>(string key, T value, SaveType saveType = SaveType.Default);
        public T Load<T>(string key, SaveType saveType = SaveType.Default);
    }
}
