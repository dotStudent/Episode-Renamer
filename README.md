This Tool is intended to Rename TV Show Episodes by cutting off known Parts of the File.

![alt text](https://cloud.githubusercontent.com/assets/26997146/25377123/e7ab110c-29a6-11e7-80ac-1c30e4be06ee.png)


In the configuration of the Tool you can define the patterns which should be cutted off and define the used File Extensions for TV Shows.

Beside the patterns for suffixes, prefixes can be cut off by (provided) regular Expressions.

The renaming itself works by Command Line and include possiblility to add to Explorer Context Menu. 

![alt text](https://cloud.githubusercontent.com/assets/26997146/25377411/c32c7d24-29a7-11e7-9057-732ebb5fd695.png)


You can prefer if the Filename or Foldername should be used for the final Filename if both is available.

Example from Filename: 

Filename: this.is.the.PrefixS01E01.This.is.the.Filename.this.is.the.Suffix.mkv 

Prefix: ->this.is.the.Prefix<- Cut off automatically, because is before Episode Information (RegEx)

Suffix: ->.this.is.the.Suffix<- This is cutted off when you added this Text to the Database before 

Final Filename: ->S01E01.This.is.the.Filename.mkv<- This is the final FilenameExample 

Example From Foldername:

FolderName: C:\TVShows\this.is.the.PrefixS01E01.This.is.the.Filename.this.is.the.Suffix\i.am.the.filename.mkv 

Filename: ->S01E01.This.is.the.Filename.mkv<- This is the final FilenameUsage:Episode-Renamer.exe C:\moviefolder\movie.mkv /preferfilename=true /preferfoldername=true
