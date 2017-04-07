using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode_Renamer
{
    public static class RegistryOperations
    {
        #region Public Fields
        public static int CheckFileHandler
        {
            get
            {
                return CheckHandlerValid(true);
            }
        }
        public static int CheckFolderHandler
        {
            get
            {
                return CheckHandlerValid(false);
            }
        }
        #endregion

        #region Public Methods
        public static string WriteHandlerToRegistry(bool file)
        {
            string PathPart = "";
            //if File == true check Filehandler else Check Folderhandler
            if (file == true)
            {
                PathPart = "*";
            }
            else
            {
                PathPart = "Folder";
            }
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            string commandvalue = path + " \"%1\"";
            try
            {
                RegistryKey key1 = Registry.ClassesRoot.CreateSubKey(PathPart + @"\shell\Episode-Renamer");
                key1.SetValue("", "&Episode-Renamer");
                key1.SetValue("Icon", "shell32.dll,43");
                key1.Close();

                RegistryKey key2 = Registry.ClassesRoot.CreateSubKey(PathPart + @"\shell\Episode-Renamer\command");
                key2.SetValue("", commandvalue);

                if (file == true)
                {
                    return "Registry Entry for Files created";
                }
                else
                {
                    return "Registry Entry for Folders created";
                }
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string DeleteHandlerInRegistry(bool file)
        {
            string PathPart = "";
            //if File == true check Filehandler else Check Folderhandler
            if (file == true)
            {
                PathPart = "*";
            }
            else
            {
                PathPart = "Folder";
            }
            try
            {
               Registry.ClassesRoot.DeleteSubKeyTree(PathPart + @"\shell\Episode-Renamer");
                if (file == true)
                {
                    return "Registry Entry for Files deleted";
                }
                else
                {
                    return "Registry Entry for Folders deleted";
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Cannot delete a subkey tree because the subkey does not exist.")
                {
                    return "Not enough Rights to delete Keys. Start App as Admin!";
                }
                else
                {
                    return ex.Message;
                }
            }
        }
        internal static int CheckHandlerValid(bool file)
        {
            string PathPart = "";
            //if File == true check Filehandler else Check Folderhandler

            //-1 File not found
            //0 Registry Entry not found
            //1 OK
            if (file == true)
            {
                PathPart = "*";
            }
            else
            {
                PathPart = "Folder";
            }

            RegistryKey key1 = Registry.ClassesRoot.OpenSubKey(PathPart + @"\shell\Episode-Renamer");
            if (key1 != null)
            {
                string sethandler = (string)key1.GetValue("");
                if (sethandler == "&Episode-Renamer")
                {
                    RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(PathPart + @"\shell\Episode-Renamer\command");
                    string command = (string)key2.GetValue("");
                    command = command.Replace(" \"%1\"", "");
                    if (File.Exists(command))
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }
        #endregion
    }
}
