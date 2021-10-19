namespace Game.Core.SaveSystem
{
    public interface ISaveable
    {
        void OnSave();
        
        void OnLoad();
    }
}