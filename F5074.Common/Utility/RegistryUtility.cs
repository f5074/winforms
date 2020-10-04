using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace F5074.Common.Utility
{
    public static class RegistryUtility
    {
        private const string REG_SUB_KEY = @"SOFTWARE\\F5074";
        private static Dictionary<string, object> tempStorage = new Dictionary<string, object>();

        private static RegistryKey Load()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(REG_SUB_KEY, true);
            if (key == null)
            {
                key = Registry.LocalMachine.CreateSubKey(REG_SUB_KEY);
            }
            return key;
        }
        public static void SetValue(string key, object value)
        {
            try
            {
                var Key = Load();
                Key.SetValue(key, value);
                Key.Close();
            }
            catch (Exception e)
            {
                tempStorage[key] = value;
            }
        }


        public static T GetValue<T>(string key)
        {
            try
            {
                var Key = Load();
                var result = Key.GetValue(key);
                Key.Close();
                return (T)result;
            }
            catch (Exception e)
            {
                return (T)(tempStorage.ContainsKey(key) ? tempStorage[key] : null);
            }
        }

        public static T GetValue<T>(string key, object defaultValue)
        {
            try
            {
                var Key = Load();
                var result = Key.GetValue(key, defaultValue);
                Key.Close();
                return (T)result;
            }
            catch (Exception e)
            {
                return (T)(tempStorage.ContainsKey(key) ? tempStorage[key] : null);
            }
        }

        public static void DeleteValue(string key)
        {
            try
            {
                var Key = Load();
                Key.DeleteValue(key);
                Key.Close();
            }
            catch (Exception e)
            {
                tempStorage.Remove(key);
            }
        }
    }
}
