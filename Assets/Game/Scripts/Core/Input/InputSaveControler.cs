using Game.Core.Services;
using Zenject;

namespace Game.Core.SaveSystem
{
    public sealed class InputSaveControler
    {
        private IInputService _inputService;

        private ISaveService _saveService;

        [Inject]
        public void Construct(IInputService inputService, ISaveService saveService)
        {
            _inputService = inputService;
            _saveService = saveService;

            _inputService.OnQuickSaveAction += QuickSave;
            _inputService.OnQuickLoadAction += QuickLoad;
        }

        ~InputSaveControler()
        {
            if (_inputService != null)
            {
                _inputService.OnQuickSaveAction -= QuickSave;
                _inputService.OnQuickLoadAction -= QuickLoad;
            }
        }

        private void QuickSave()
        {
            this._saveService.NotifyAboutSave();
        }

        private void QuickLoad()
        {
            this._saveService.NotifyAboutLoad();
        }
    }
}