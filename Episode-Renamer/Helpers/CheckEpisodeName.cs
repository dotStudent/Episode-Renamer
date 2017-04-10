using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Episode_Renamer
{
    public class CheckEpisodeName
    {
        #region Public Constants
        // Was used before value was in Database
        //public static string strRegex = @"(?i:S)\d{1,2}(?i:E)\d{0,1}\w+.*"; //Regex String to receive Episode Information and everything behind
        #endregion
        public string TestRegEx { get; set; }
        public string TestPrefixCut
        {
            get
            {
                if (TestRegEx != null && TestRegEx != "")
                {
                    if (Regex.IsMatch(TestName, TestRegEx)) //Check if s0(0)e0(0) is in Filename
                    {
                        var value = Regex.Match(TestName, TestRegEx); //Cut Part before matching string
                        string improvedfilename = episodeImprove(value.ToString(), true); //Send to Function to improve Episode Information
                        return improvedfilename; //Return Improved and Cutted Filename
                    }
                }
                return "No RegEx Set or Applicable";
            }
            set
            {
                TestName = value;
            }
        }
        public string TestSuffixCut
        {
            get
            {
                return cutSuffix(TestName);
            }
            set
            {
                TestName = value;
            }
        }
        private string TestName = "";
        #region Constructor
        public CheckEpisodeName()
        {

        }
        public CheckEpisodeName(EpisodeObject episode, bool preferFile, bool preferFolder)
        {
            Check(episode, preferFile, preferFolder);
        }
        #endregion

        #region Public Methods
        public void Check(EpisodeObject episode, bool preferFile, bool preferFolder)
        {
            checkForEpisodeInformation(episode);
            cutEpisode(episode, preferFile, preferFile);
        }
        #endregion

        #region Private Methods
        private void checkForEpisodeInformation(EpisodeObject input) // Check if Episode is useable for Renaming
        {
            bool episodeInFile = false; //True if Episodename is in File
            bool episodeInFolder = false; //True if Episodename is in Folder and can be used

            if (Regex.IsMatch(input.EpisodeFile, Data.defaultRegex)) //Check if s00e00 is in Filename
            {
                episodeInFile = true;
            }
            //Check now Foldernames for Episode Information
            int countEpisodepath = 0;
            foreach (string episode in input.EpisodeSplitPath) //Search for Usable Information in Foldernames
            {
                if (Regex.IsMatch(episode, Data.defaultRegex) && input.NameMustComeFromFile == false) //Check if s00e00 is in Filename, Also ignore when more than one Movieobject is in the same Folder
                {
                    //Episode is in path
                    countEpisodepath++;
                }
                if (countEpisodepath == 1)
                {
                    episodeInFolder = true;
                }
            }
            if (episodeInFile == true && episodeInFolder == true)
            {
                input.type = 3; //Episode Information is in Filename and Path
            }
            else if (episodeInFile == true && episodeInFolder == false)
            {
                input.type = 1; //Episode Information is in Filename
            }
            else if (episodeInFile == false && episodeInFolder == true)
            {
                input.type = 2; //Episode Information is in Path
            }
            else
            {
                input.type = 0; //Episode Information is neither in Filename nor Path
            }
        }
        private void cutEpisode(EpisodeObject episode, bool preferFile, bool preferFolder)
        {
            string possibleFileNameFromFile = "";
            string possibleFileNameFromFolder = "";

            if (episode.type == 1 || episode.type == 3) //Use File if Episode Information is in Filename
            {
                possibleFileNameFromFile = getLongestFileNameFromFile(episode.EpisodeFile);
            }
            if (episode.type == 2 || episode.type == 3)//Check if Episode Information can be received from Path
            {
                possibleFileNameFromFolder = getLongestFileNameFromFolder(episode.EpisodeSplitPath);
            }
            if (episode.type == 0) //File and Path have no Episode Information but maybe suffix to cut
            {
                possibleFileNameFromFile = getLongestFileNameFromFile(episode.EpisodeFile);
            }
            //Normally longestCut Wins, but when not defined specific

            if (episode.type == 3)
            {
                if (preferFile == true && preferFolder == false && possibleFileNameFromFile.Length > 0)
                {
                    episode.EpisodeNewFile = possibleFileNameFromFile;
                }
                else if (preferFolder == true && preferFile == false && possibleFileNameFromFolder.Length > 0)
                {
                    episode.EpisodeNewFile = possibleFileNameFromFolder;
                }
            }
            if (episode.EpisodeNewFile == "" && possibleFileNameFromFile.Length > possibleFileNameFromFolder.Length)
            {
                episode.EpisodeNewFile = possibleFileNameFromFile;
            }
            else if (episode.EpisodeNewFile == "")
            {
                episode.EpisodeNewFile = possibleFileNameFromFolder;
            }
            else
            {
                //No FileInformation in it
            }
        }
        private string getLongestFileNameFromFile(string fileName)
        {
            string WithoutPrefixFilename = cutPrefix(fileName); //Cut prefix before S..E..
            string newFilename = cutSuffix(WithoutPrefixFilename);

            return newFilename;
        }//Get LongestCutFromFilename
        private string getLongestFileNameFromFolder(string[] EpisodeSplitPath)
        {
            string WithoutPrefixFilename = "";
            string newFilename = "";

            foreach (string pathChunk in EpisodeSplitPath) //Get every Chunk of a Path
            {
                WithoutPrefixFilename = cutPrefix(pathChunk); // Cuts everything before S00E00 if possible
                newFilename = cutSuffix(WithoutPrefixFilename); //try to cut "suf" from Foldername Chunk
            }
            return newFilename;
        }
        private string cutPrefix(string filename) //Remove Everything before the Episode Information 
        {
            if (Regex.IsMatch(filename, Data.defaultRegex)) //Check if s0(0)e0(0) is in Filename
            {
                var value = Regex.Match(filename, Data.defaultRegex); //Cut Part before matching string
                string improvedfilename = episodeImprove(value.ToString(), true); //Send to Function to improve Episode Information
                return improvedfilename; //Return Improved and Cutted Filename
            }
            return filename; // Nothing to cut...send back received filename
        }
        private string cutSuffix(string EpisodePlusGarbage)
        {
            //Returns the best filename possible
            int bestMatch = 0;
            for (int i = 0; i < Data.suffixList.Count; i++)
            {
                string newfilename = EpisodePlusGarbage.Replace(Data.suffixList[i], "");
                if (EpisodePlusGarbage.Length - newfilename.Length > Data.suffixList[bestMatch].Length)
                {
                    bestMatch = i;
                }
            }
            return EpisodePlusGarbage.Replace(Data.suffixList[bestMatch], ""); ;
        }
        private string episodeImprove(string filename, bool prefix) //Take Care that Episode Information is Always in Upper and 2 digit
        {
            string season = "";
            string episode = "";
            string episodename = "";
            string episodepart = Regex.Match(filename, @"(?i:S)\d*(?i:E)\d*").ToString(); //Extract Episode Part from Filename
            episodename = filename.Replace(episodepart, ""); //Remove Episode Part from Filename

            if (episodepart.Length < 6 && episodepart.Length >= 4) // Not everything is 2 digit but long enough
            {
                episodepart = episodepart.ToUpper(); //Bring characters to upper
                string[] seasonepisode = episodepart.Split('E'); //Split Season Part from Episode
                season = seasonepisode[0].Replace("S", ""); //Only give Season number
                episode = seasonepisode[1]; //Only give Episode number
                if (season.Length < 2) //Season is only 1 digit
                {
                    season = "0" + season; //Add 0 before season number
                }
                if (episode.Length < 2) //Episode is only 1 digit
                {
                    episode = "0" + episode; //Add 0 before episode number
                }
                if (prefix == true)
                {
                    return "S" + season + "E" + episode + episodename; //Bulid and return full Episode Information String
                }
                else
                {
                    return "S" + season + "E" + episode;
                }
            }
            else //Nothing to do, Episode is already 2 digit for Season and Episode
            {
                if (prefix == true)
                {
                    return episodepart.ToUpper() + episodename; //Take care, "S" and "E" are Upper Case
                }
                else
                {
                    return episodepart.ToUpper();
                }
            }
        }
        #endregion
    }
}
