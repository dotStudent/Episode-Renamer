using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Episode_Renamer
{
    static class Data
    {
        #region Private Variables
        public static bool dataLoaded = false;
        public static List<string> suffixList = new List<string>();
        public static List<string> extensionList = new List<string>();

        private static SQLiteCommand sCommandSuffix;
        private static SQLiteDataAdapter sAdapterSuffix;
        private static SQLiteCommandBuilder sBuilderSuffix;
        private static DataTable sDtSuffix;

        private static SQLiteCommand sCommandExtension;
        private static SQLiteDataAdapter sAdapterExtension;
        private static SQLiteCommandBuilder sBuilderExtension;
        private static DataTable sDtExtension;


        private static string source = Properties.Settings.Default.dbpath;
        private static string connectionString = "Data Source=" + Properties.Settings.Default.dbpath;
        #endregion

        #region Public Methods
        public static bool LoadData() // Load Suffix Data to DataSet -> Datatable
        {
            DataSet sDsSuffix = new DataSet();
            //sDs.Clear();
            if (FileOperations.ElementExist(source) == true)
            {
                string sql = "SELECT id, presuffix FROM PreSuffixTxt";
                SQLiteConnection connection = new SQLiteConnection(connectionString);
                sCommandSuffix = new SQLiteCommand(sql, connection);
                connection.Open();
                sAdapterSuffix = new SQLiteDataAdapter(sCommandSuffix);
                sBuilderSuffix = new SQLiteCommandBuilder(sAdapterSuffix);

                sAdapterSuffix.Fill(sDsSuffix, "PreSuffixTxt");
                sDtSuffix = sDsSuffix.Tables["PreSuffixTxt"];
                sDtSuffix.Columns[1].Unique = true;
                connection.Close();
                suffixList.Clear();
                foreach (DataRow row in sDtSuffix.Rows)
                {
                    suffixList.Add((string)row["presuffix"]);
                }

                DataSet sDsExtension = new DataSet();
                string sql2 = "SELECT id, Extension FROM Extensions";
                SQLiteConnection connection2 = new SQLiteConnection(connectionString);
                sCommandExtension = new SQLiteCommand(sql2, connection2);
                connection.Open();
                sAdapterExtension = new SQLiteDataAdapter(sCommandExtension);
                sBuilderExtension = new SQLiteCommandBuilder(sAdapterExtension);

                sAdapterExtension.Fill(sDsExtension, "Extension");
                sDtExtension = sDsExtension.Tables["Extension"];
                sDtExtension.Columns[1].Unique = true;
                connection.Close();
                extensionList.Clear();
                foreach (DataRow row in sDtExtension.Rows)
                {
                    string ext = ((string)row["Extension"]).Replace(".", "");

                    extensionList.Add(ext);
                }

                dataLoaded = true;
                return true;
            }
            else
            {
                dataLoaded = false;
                return false;
            }
        }
        public static DataTable LoadSuffix() //Public Datatable with Suffix Information
        {
            return sDtSuffix;
        }
        public static DataTable LoadExtensions() //Public Datatable with Extensions Information
        {
            return sDtExtension;
        }
        public static void SaveSuffix()
        {
            if (sDtSuffix != null && sDtExtension != null)
            {
                sAdapterSuffix.Update(sDtSuffix);
                sAdapterExtension.Update(sDtExtension);
            }
        }// Save Changes To DB
        #endregion
    }
}
