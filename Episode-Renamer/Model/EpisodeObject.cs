using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode_Renamer
{
    public class EpisodeObject
    {
        #region Private Variables
        private string _path; //Path from full pathfilename
        private string[] _splitpath;
        private string _filename; //Filename from full pathfilename
        private string _extension; //File Extension from full pathfilename
        private string _newFilename = "";
        private string _oldpathfile;
        private string _newpathfile;
        #endregion

        #region Constructor
        public EpisodeObject(string pathfilename)
        {
            if (File.Exists(pathfilename) == true)
            {
                _oldpathfile = pathfilename;
                _path = Path.GetDirectoryName(pathfilename);
                _splitpath = _path.Split('\\');
                _filename = Path.GetFileNameWithoutExtension(pathfilename);
                _extension = Path.GetExtension(pathfilename);
            }
            else
            {
                _filename = pathfilename;
            }
        }
        #endregion

        #region Public Variables
        public string EpisodePath { get { return _path; } }
        public string[] EpisodeSplitPath { get { return _splitpath; } }
        public string EpisodeFile { get { return _filename; } }
        public string EpisodeExtension { get { return _extension; } }
        public string EpisodeNewFile
        {
            get
            {
                return _newFilename;
            }
            set
            {
                _newFilename = value;
                _newpathfile = _path + "\\" + _newFilename + _extension;
            }
        }
        public string oldEpisodeFilePath { get { return _oldpathfile; } }
        public string newEpisodeFilePath { get { return _newpathfile; } }
        public int type { get; set; } //Tells where the Foldername can be taken from
        public bool Error { get; set; } //Something is Wrong with the Episode Object
        public bool NameMustComeFromFile { get; set; } //Given was Folder and there was more then one Movie File in the Folder
        #endregion
    }
}
