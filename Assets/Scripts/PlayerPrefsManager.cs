using UnityEngine;

namespace ApplicationStorage
{
    public class PlayerPrefsManager : MonoBehaviour
    {
        // Save an integer value
        public static void SaveInt(string key, int value)
        {
            PlayerPrefs.SetInt(key, value);
            PlayerPrefs.Save();
        }

        // Save a float value
        public static void SaveFloat(string key, float value)
        {
            PlayerPrefs.SetFloat(key, value);
            PlayerPrefs.Save();
        }

        // Save a string value
        public static void SaveString(string key, string value)
        {
            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();
        }

        // Get an integer value
        public static int GetInt(string key, int defaultValue = 0)
        {
            return PlayerPrefs.GetInt(key, defaultValue);
        }

        // Get a float value
        public static float GetFloat(string key, float defaultValue = 0.0f)
        {
            return PlayerPrefs.GetFloat(key, defaultValue);
        }

        // Get a string value
        public static string GetString(string key, string defaultValue = null)
        {
            return PlayerPrefs.GetString(key, defaultValue);
        }

        // Delete a specific key
        public static void DeleteKey(string key)
        {
            PlayerPrefs.DeleteKey(key);
        }

        // Delete all data saved with PlayerPrefs
        public static void DeleteAll()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}