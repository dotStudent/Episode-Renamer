using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode_Renamer
{
    class Headless //Headless Mode -> Only Commandline
    {
        #region Private Variables
        List<EpisodeObject> episodeFiles = new List<EpisodeObject>();
        private bool preferFile = false;
        private bool preferFolder = false;
        #endregion

        #region Public Methods
        public Headless(string[] args)
        {
            FileOperations fileOp = new FileOperations();
            for (int i = 0; i < args.Length; i++) //For Every FileObject in Arguments
            {
                if (args[i].ToLower() == ("preferfilename=true"))
                {
                    preferFile = true;
                }
                else if ((args[i].ToLower() == ("preferfilename=true")))
                {
                    preferFolder = true;
                }
                CreateEpisodeObjects(fileOp.MovieObject(args[i])); //Create Movieobject
                CheckEpisodeObjects(); //Check for Renaming
                RenameEpisodeObjects(); //Rename
            }
        }
        public void CreateEpisodeObjects(List<string> movieobjects)
        {
            int objCount = 0;
            if (movieobjects != null && movieobjects.Count > 0)
            {
                objCount = movieobjects.Count;
                foreach (string movieobject in movieobjects)
                {
                    EpisodeObject newfile = new EpisodeObject(movieobject);
                    newfile.Error = false;
                    if (objCount == 1)
                    {
                        //Only one File in List, Foldername can be used for Naming
                        newfile.NameMustComeFromFile = false;
                    }
                    else
                    {
                        //More than one File in List, Foldername cannot be used for Naming
                        newfile.NameMustComeFromFile = true;
                    }
                    if (newfile != null)
                    {
                        episodeFiles.Add(newfile);
                    }
                }
            }
        }//Make Episode Object from file
        public void CheckEpisodeObjects()
        {
            if (episodeFiles.Count > 0)
            {
                foreach (EpisodeObject episode in episodeFiles)
                {
                    CheckEpisodeName chk = new CheckEpisodeName();
                    chk.Check(episode, preferFile, preferFolder);
                }
            }
        }
        public void RenameEpisodeObjects()
        {
            if (episodeFiles.Count > 0)
            {
                foreach (EpisodeObject episode in episodeFiles)
                {
                    if (episode.oldEpisodeFilePath != episode.newEpisodeFilePath)
                    {
                        FileOperations.renameFile(episode.oldEpisodeFilePath, episode.newEpisodeFilePath);
                    }
                }
            }
        } //If new Episode Name was found, Rename File
        #endregion
    }
}

