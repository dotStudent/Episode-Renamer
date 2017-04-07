using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode_Renamer
{
    class FileOperations
    {
        #region Public Methods
        public List<string> MovieObject(string file)
        {
            if (Data.dataLoaded == false)
            {
                Data.LoadData();
            }

            if (ElementExist(file) == true)
            {
                FileAttributes attr = File.GetAttributes(file);
                List<string> files = new List<string>();
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory) //If Element is Directory and not File
                {
                    foreach (string extension in Data.extensionList)
                    {
                        files.AddRange(Directory.GetFiles(file, "*." + extension));
                    }
                    if (files.Count > 0)
                    {
                        return files;
                    }
                    else
                    {
                        return null;
                    }
                }
                else //Element is File
                {
                    foreach (string extension in Data.extensionList)
                    {
                        if (Path.GetExtension(file) == "." + extension)//Get Files
                        {
                            //Element is Supported Video File
                            files.Add(file);
                            return files;
                        }
                    }
                }
            }
            return null;
        }
        public static string renameFile(string oldfilename, string newfilename) //Rename File in File System
        {
            if (File.Exists(oldfilename) && !File.Exists(newfilename)) //Only Rename if old File exist and new File not
            {
                File.Move(oldfilename, newfilename); //Rename
                return oldfilename + " renamed to " + newfilename; //return log Infos
            }
            else
            {
                return oldfilename + " not found or " + newfilename + " already existing!"; // Return log Infos
            }
        }
        #endregion

        #region Helpers
        public static bool ElementExist(string element) //Check if string file is file or folder and return status 
        {
            bool exists = false;

            if (Directory.Exists(element))
            {
                exists = true;
            }
            if (File.Exists(element))
            {
                exists = true;
            }
            return exists;
        }
        #endregion
    }
}
