using Game.Core.Services;
using System.Collections.Generic;

namespace Game.Core.SaveSystem
{
    public sealed class SaveService : ISaveService
    {
        private readonly List<ISaveable> _saveables = new List<ISaveable>();

        public void NotifyAboutSave()
        {
            for (int i = 0, count = _saveables.Count; i < count; i++)
            {
                var saveable = _saveables[i];
                saveable.OnSave();
            }
        }

        public void NotifyAboutLoad()
        {
            for (int i = 0, count = _saveables.Count; i < count; i++)
            {
                var saveable = _saveables[i];
                saveable.OnLoad();
            }
        }

        public void RegisterListener(ISaveable saveable)
        {
            _saveables.Add(saveable);
        }

        public void UnregisterListener(ISaveable saveable)
        {
            _saveables.Remove(saveable);
        }
    }
}