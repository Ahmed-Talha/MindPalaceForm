using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace MindPalaceForm
{
    public partial class Form2 : Form
    {
        ContainerClass wrapperClass = new ContainerClass();
        string filename = "SavedInfo.txt";
        List<Info> profilesTemp = new List<Info>();
        int increament = 0;
        public Form2()
        {
            InitializeComponent();
            //ReadDataFromFile();
            //gridDataProfiles.DataSource = profilesTemp;
        }

        public void ReadDataFromFile()
        {
            
            Stream OutputStream = File.Open(filename, FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();
            profilesTemp = (List<Info>)bformatter.Deserialize(OutputStream);
            OutputStream.Close();

            gridDataProfiles.AutoGenerateColumns = true;
            gridDataProfiles.AutoSize = true;
            
            //gridDataProfiles.edi
            gridDataProfiles.DataSource = profilesTemp;
            //ProfilesNames.DataPropertyName = "Name";
            /*foreach(DataGridViewRow row in gridDataProfiles.Rows)
            {
                row.Cells["SerialNo"].Value = increament.ToString();
                increament++;
            }*/
            gridDataProfiles.Show();
        }

        private void gridDataProfiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string Name = gridDataProfiles.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            Info changedObjectInDataGrid =  wrapperClass.FindProfile(Name);
            wrapperClass.UpdateProfile(changedObjectInDataGrid);
        }
    }
}
