using QuickTools.QData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QuickToolsGUI
{
    public class GlobalSettings
    {
        public static string TextEntry = null;
        public static string DefaultSettingFile = "QuickToolsGUI";
        public static string DefaultBackGroundColor = "black";
        public static int    DefaultFontSize = 9;
        public static string   PrivateTextEntry = "False";





        public static void EnablePrivateTextEntry()
        {
            SaveSetting("PrivateTextEntry", "True");
        }
        public static void DisablePrivateTextEntry() 
        {
            SaveSetting("PrivateTextEntry", "False");

        }
        public static void SaveSetting(string key , string value)
        {
            QSettings settings = new QSettings(DefaultSettingFile);
            settings.Create();
            settings.Load();
            settings.UpdateSetting(key, value); 

        }
        public static string GetSetting(string key)
        {

            return new QSettings(DefaultSettingFile).GetSetting(key);
        }

        public static void ReloadSettings()
        {

        }
        public static void ResetToDefaultSettings()
        {
            QSettings settings = new QSettings(DefaultSettingFile);
            settings.DeleteSettingsFile();
            settings.Create();
            
                    settings.AddSetting("TextEntry",null);
                    settings.AddSetting("DefaultSettingFile",DefaultSettingFile);
                    settings.AddSetting("DefaultBackGroundColor",DefaultBackGroundColor);
                    settings.AddSetting("DefaultFontSize", DefaultFontSize) ;
                    settings.AddSetting("PrivateTextEntry",PrivateTextEntry);
        }
        public static void LoadSettings()
        {
            QSettings settings = new QSettings(DefaultSettingFile);
            settings.Create();
            settings.Load(); 



        }
        public void LoadThemSettings()
        {

        }
        public GlobalSettings()
        {
            GlobalSettings.LoadSettings(); 
        }
    }
}
