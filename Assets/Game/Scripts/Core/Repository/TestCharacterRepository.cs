using UnityEngine;

namespace Game.Experiment
{
    public sealed class TestCharacterRepository
    {
        private const string PREFS_KEY = "TestInt";
        
        public void SaveTestValue(int testValue)
        {
            PlayerPrefs.SetInt(PREFS_KEY, testValue);
        }

        public int LoadTestValue()
        {
            if (PlayerPrefs.HasKey(PREFS_KEY))
            {
                return PlayerPrefs.GetInt(PREFS_KEY);
            }

            return default;
        }
    }
}