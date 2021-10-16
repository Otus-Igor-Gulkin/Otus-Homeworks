using Game.Core.Types;

namespace Game.Core.SaveSystem {
    public interface ISaveable : IObserver {
        void Save();
        void Load();
    }
}
