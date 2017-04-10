using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bulb;
using Episode_Renamer.Helpers;

namespace Episode_Renamer.Forms
{
    public partial class frmConfig : Form
    {
        #region Private Variables
        private int rowIndex1;
        private bool dbProblem = false;
        #endregion

        #region constructor
        public frmConfig()
        {
            InitializeComponent();

            tbDBPath.Text = Properties.Settings.Default.dbpath;
            
            try
            {
                Data.LoadData(); //Load Data from Database

                if (Data.dataLoaded == true)
                {
                    lblStatus.Text = "Only Suffix is needed, Prefix is cut automatically";
                    dgvPrefix.DataSource = Data.LoadSuffix(); //Bind DatagridView on Datatable from DB
                    dgvPrefix.Columns[0].Visible = false; //Hide Column0 (Index)
                    dgvPrefix.Columns[1].HeaderCell.Value = "Suffix";

                    dgvFileTypes.DataSource = Data.LoadExtensions(); //Bind DatagridView on Datatable from DB
                    dgvFileTypes.Columns[0].Visible = false; //Hide Column0 (Index)
                    dgvFileTypes.Columns[1].HeaderCell.Value = "Extension";

                    dgvRegEx.DataSource = Data.LoadRegex();
                    dgvRegEx.Columns[0].Visible = false; //Hide Column0 (Index)
                    dgvRegEx.Columns[1].HeaderCell.Value = "RegEx";
                    dgvRegEx.Columns[2].HeaderCell.Value = "Description";
                    dgvRegEx.Columns[3].HeaderCell.Value = "IsDefault";
                }
                else
                {
                    lblStatus.Text = "DB is not available, Check path!";
                }
            }
            catch (Exception ex)
            {
                ShowMessagebox(ex.ToString());
                dbProblem = true;
            }
        }
        #endregion

        #region Buttons
        private void btn_save_Click(object sender, EventArgs e)
        {
            int ok = CheckDataTableForDefault(Data.LoadRegex(), 3, "1");
            if (ok == 1 && dbProblem == false)
            {
                Data.SaveSuffix(); //Save Changes to DB

                Properties.Settings.Default.dbpath = tbDBPath.Text;
                Properties.Settings.Default.Save();
                //this.Close();
            }
            else if (ok == 0)
            {
                ShowMessagebox("You need to select one Default Value in the Regex Grid");
            }
            else if (ok == -1)
            {
                ShowMessagebox("You need to have at least one Regex Value");
            }
            else if (ok > 1)
            {
                ShowMessagebox("Only one default Value in Regex Grid is allowed");
            }



        }
        private void btn_DBSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "SQLiteDB|*.db|All|*.*";
            openFileDialog1.ShowHelp = true;
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                tbDBPath.Text = openFileDialog1.FileName;
            }
        }
        private void btnRegFile_Click(object sender, EventArgs e)
        {
            lblStatus.Text = RegistryOperations.WriteHandlerToRegistry(true);
            CheckFileHandler();
        }
        private void btnUnregFile_Click(object sender, EventArgs e)
        {
            lblStatus.Text = RegistryOperations.DeleteHandlerInRegistry(true);
            CheckFileHandler();
        }
        private void btnRegFolder_Click(object sender, EventArgs e)
        {
            lblStatus.Text = RegistryOperations.WriteHandlerToRegistry(false);
            CheckFolderHandler();
        }
        private void btnUnregFolder_Click(object sender, EventArgs e)
        {
            lblStatus.Text = RegistryOperations.DeleteHandlerInRegistry(false);
            CheckFolderHandler();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {

            
            CheckEpisodeName cen = new CheckEpisodeName();
            string regex = GetSelectedRegex();

            if (regex != "")
            {
                string NewTestFileName = "";
                cen.TestRegEx = regex;
                cen.TestPrefixCut = tbTest.Text;
                NewTestFileName = cen.TestPrefixCut;

                if (cBSuffix.Checked == true)
                {
                    cen.TestSuffixCut = NewTestFileName;
                    NewTestFileName = cen.TestSuffixCut;
                }
                tbTestResult.Text = NewTestFileName;
            }
            else
            {
                tbTestResult.Text = "No Regex selected";
            }
        }
        #endregion

        #region Events
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            if (tbInfo.SelectedTab.Text == "Registry") //.SelectedIndex == 3)
            {
                CheckFileHandler();
                CheckFolderHandler();
            }
        }
        private void dgvPrefix_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e) //Enable Mouse Click on dataGridView
        {
            //Handler to Delete Datagridview Entry
            if (e.Button == MouseButtons.Right)
            {
                this.dgvPrefix.Rows[e.RowIndex].Selected = true;
                this.rowIndex1 = e.RowIndex;
                this.dgvPrefix.CurrentCell = this.dgvPrefix.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip.Show(this.dgvPrefix, e.Location);
                contextMenuStrip.Show(Cursor.Position);
            }
        }
        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //The Context Menu for Deleting of Datarows
            if (!this.dgvPrefix.Rows[this.rowIndex1].IsNewRow)
            {
                //Get the System ID of deleted System and write it to list
                this.dgvPrefix.Rows.RemoveAt(this.rowIndex1);
            }
        }
        private void dgvFileTypes_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Handler to Delete Datagridview Entry
            if (e.Button == MouseButtons.Right)
            {
                this.dgvFileTypes.Rows[e.RowIndex].Selected = true;
                this.rowIndex1 = e.RowIndex;
                this.dgvFileTypes.CurrentCell = this.dgvFileTypes.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvFileTypes, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        private void deleteRowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //The Context Menu for Deleting of Datarows
            if (!this.dgvFileTypes.Rows[this.rowIndex1].IsNewRow)
            {
                //Get the System ID of deleted System and write it to list
                this.dgvFileTypes.Rows.RemoveAt(this.rowIndex1);
            }
        }
        #endregion

        #region Helpers
        private Control SearchControl(string name, Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if(ctrl.Name == name)
                {
                    return ctrl;
                }
            }
            return null;
        }
        private void CheckFileHandler()
        {
            if (SearchControl("bulbFile", gBFileHandler) == null)
            {
                LedBulb bulbFile = new LedBulb();
                bulbFile.Location = new System.Drawing.Point(20, 15);
                //bulbFile.Color = System.Drawing.Color.LawnGreen;
                bulbFile.Size = new System.Drawing.Size(25, 20);
                //bulbFile.On = false;
                bulbFile.Name = "bulbFile";
                gBFileHandler.Controls.Add(bulbFile);
            }
            int FileHandler = 0;
            try
            {
                FileHandler = RegistryOperations.CheckFileHandler;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            Control ctrl = SearchControl("bulbFile", gBFileHandler);

            ToggleReg((LedBulb)ctrl, btnRegFile, btnUnregFile, FileHandler);
        }
        private void CheckFolderHandler()
        {
            if (SearchControl("bulbFolder", gbFolderHandler) == null)
            {
                LedBulb bulbFolder = new LedBulb();
                bulbFolder.Location = new System.Drawing.Point(20, 15);
                bulbFolder.Color = System.Drawing.Color.LawnGreen;
                bulbFolder.Size = new System.Drawing.Size(25, 20);
                bulbFolder.On = false;
                bulbFolder.Name = "bulbFolder";
                gbFolderHandler.Controls.Add(bulbFolder);
            }
            int FolderHandler = 0;
            try
            {
                FolderHandler = RegistryOperations.CheckFolderHandler;
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            Control ctrl = SearchControl("bulbFolder", gbFolderHandler);

            ToggleReg((LedBulb)ctrl, btnRegFolder, btnUnregFolder, FolderHandler);
        }
        private void ToggleReg(LedBulb bulb, Button btnreg, Button btnunreg, int status)
        {
            if (status == 1)
            {
                bulb.Color = Color.LawnGreen;
                bulb.On = true;
                btnreg.Enabled = false;
                btnunreg.Enabled = true;

            }
            else if (status == -1)
            {
                bulb.Color = Color.Red;
                bulb.On = true;
                btnreg.Enabled = true;
                btnunreg.Enabled = true;

            }
            else
            {
                bulb.Color = Color.LawnGreen;
                bulb.On = false;
                btnreg.Enabled = true;
                btnunreg.Enabled = false;
            }
        }
        private int CheckDataTableForDefault(DataTable dt, int ColID, string Value)
        {
            int count = 0;
            if (dt.Columns.Count > ColID)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[ColID].ToString() == Value)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    return 0;
                }
                else if (count == 1)
                {
                    return 1;
                }
                else
                {
                    return count;
                }
            }
            else
            {
                return -1;
            }
        }
        private void ShowMessagebox(string Message)
        {
            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
            {
                MessageBox.Show(this, Message);
            }
        }
        private string GetSelectedRegex()
        {
            int index = dgvRegEx.CurrentCell.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvRegEx.Rows[index];
            string regex = row.Cells[1].Value.ToString();
            if (regex == null || regex == "")
            {
                return "";
            }
            else
            {
                return regex;
            }

        }
        #endregion
    }
}
