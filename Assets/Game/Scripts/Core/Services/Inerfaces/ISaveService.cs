using Game.Core.SaveSystem;

namespace Game.Core.Services
{
    //Доменная логика
    public interface ISaveService
    {
        void NotifyAboutSave();

        void NotifyAboutLoad();

        void RegisterListener(ISaveable saveable);

        void UnregisterListener(ISaveable saveable);
    }
}