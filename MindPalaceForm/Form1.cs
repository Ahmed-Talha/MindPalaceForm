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
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace MindPalaceForm
{
    [Serializable]
    public partial class Form1 : Form
    {
        ContainerClass container = new ContainerClass();
        Info information = new Info();
        Info returnedObjectToEdit = new Info();
        UserInputs userInputs = new UserInputs();
        Form2 secondForm = new Form2();
        bool editFlag = false;
        string filename = "SavedInfo.xml";
        enum gender { Select, Male, Female, TestGender01, TestGender02 };

        //======================================== D E C L A R A T I O N S ==============================================//

        public Form1()
        {
            InitializeComponent();
            information.PropertyChanged += information_PropertyChanged;
            container.AddProfileEvent += container_AddProfileEvent;
            container.EditProfileEvent += container_EditProfileEvent;
            container.DeleteProfileEvent += container_DeleteProfileEvent;
            
            this.Location = new Point(150, 75);
        }
        void container_DeleteProfileEvent(object sender)
        {
            toolStripProgressBar1.PerformStep();
            toolStripStatusLabel1.Text = "Delete Event Handled in Status Bar";
            MessageBox.Show("Delete Event Handled");
        }
        void container_EditProfileEvent(object sender)
        {
            //toolStripProgressBar1.PerformStep();
            toolStripStatusLabel1.Text = "Edit event handled in Status Bar";
            MessageBox.Show("Profile Edit Handled");
        }
        void container_AddProfileEvent(object sender)
        {
            toolStripProgressBar1.PerformStep();
            toolStripStatusLabel1.Text = "Add Profile Event Handled in Status Bar";
            MessageBox.Show("Add Profile Event Handled");
            toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
        }
        void information_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
              SetData(sender as Info);
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            SaveUserInputs();
            if (!editFlag)
            {
                if (container.ValidateInput(userInputs))
                {
                    if (information.Name != null)
                    {
                        Info NewInformation = new Info();
                        container.SaveDataOfWrapperClass(NewInformation,userInputs); //saveInfo(NewInformation);
                        showSavedData(NewInformation);
                        container.AddProfile(NewInformation);
                        saveToFileBtn.Visible = true; readFromFileBtn.Visible = true;
                        //secondForm.Show();
                        //information = NewInformation;
                    }
                    else
                    {
                        //Info information = new Info();
                        container.SaveDataOfWrapperClass(information, userInputs);// saveInfo(information);
                        showSavedData(information);
                        container.AddProfile(information);
                        saveToFileBtn.Visible = true; readFromFileBtn.Visible = true;
                        //secondForm.Show();
                    }
                }
                else MessageBox.Show("Invalid/Missing Input somewhere");
            }
            else
            {
                if (container.ValidateInput(userInputs))
                {
                    container.SaveDataOfWrapperClass(returnedObjectToEdit, userInputs);// saveInfo(returnedObjectToEdit);
                    toolStripProgressBar1.PerformStep();
                    showSavedData(returnedObjectToEdit);
                    container.UpdateProfile(returnedObjectToEdit);
                    toolStripProgressBar1.Value = toolStripProgressBar1.Minimum;
                    listBoxProfiles.Items.Insert(listBoxProfiles.SelectedIndex, returnedObjectToEdit.Name);
                    listBoxProfiles.Items.RemoveAt(listBoxProfiles.SelectedIndex);
                    information = returnedObjectToEdit;
                    editFlag = false;
                    saveToFileBtn.Visible = true; readFromFileBtn.Visible = true;
                    //secondForm.Show();
                }
                else MessageBox.Show("Invalid/Missing Input somewhere");
            }
        }

        /*private bool validateInputs()
        {
                    if (container.ValidateInput(userInputs))
                        return true;
                    else
                    {
                        MessageBox.Show("Invalid or Missing Input in Form");
                        return false;
                    }           
        }*/ // Handled in container class
        
        private void showSavedData(Info information) //Show data into property grid and in message box
        {
            MessageBox.Show(information.ToString(), "Congratulations!!!");
            propertyGrid1.SelectedObject = information;
            if (editFlag==false) { listBoxProfiles.Items.Add(information.Name); }
        }

        /*private void saveInfo(Info information) // Save input data
        {
            information.Name = txtName.Text;// +" " + name2.Text + " " + name3.Text;
            information.Address = txtAddress.Text;
            information.CoordinatesX = Convert.ToInt32(txtCoordinatesX.Text);
            information.CoordinatesY = Convert.ToInt32(txtCoordinatesY.Text);
            information.Email = txtEmail.Text;
            information.Gender = genderComboBox.SelectedItem.ToString();
            information.Password = txtPassword.Text;
            information.DOB = dateTimePicker1.Value;
            information.IQ = Convert.ToInt32(iQNumericUpDown.Value.ToString());
            information.Contact = Convert.ToInt64(txtContact.Text);
        }*/ // Handled in container class
        void SetData(Info userInfo) // Set Data in the form controls 
        {
            txtName.Text = userInfo.Name;
            txtAddress.Text = userInfo.Address;
            if (userInfo.Contact == 0) { txtContact.Text = ""; }
            else txtContact.Text = userInfo.Contact.ToString();
            txtEmail.Text = userInfo.Email;
            txtCoordinatesX.Text = userInfo.CoordinatesX.ToString();
            txtCoordinatesY.Text = userInfo.CoordinatesY.ToString();
            if (userInfo.IQ == 0) { userInfo.IQ = 100; }
            iQNumericUpDown.Value = userInfo.IQ;
            if (userInfo.Gender != null) { genderComboBox.Text = userInfo.Gender; }
            else genderComboBox.SelectedIndex = 0;
            txtPassword.Text = userInfo.Password;
            txtReenterPwd.Text = userInfo.Password;
            if (userInfo.DOB.ToString() == "1/1/0001 12:00:00 AM") { dateTimePicker1.Value = DateTime.Now; txtBoxAge.Visible = false; labelAge.Visible = false; }
            else dateTimePicker1.Value = userInfo.DOB;
            checkBoxRoller.Checked = false;

            // set data to form controls fron userInfo
        }
        void SaveUserInputs()
        {
            userInputs.InputName = txtName.Text;
            userInputs.InputDob = dateTimePicker1.Value.ToString();
            userInputs.InputAddress = txtAddress.Text;
            userInputs.InputCoordinatesX = txtCoordinatesX.Text;
            userInputs.InputCoordinatesY = txtCoordinatesY.Text;
            userInputs.InputEmail = txtEmail.Text;
            userInputs.InputIq = iQNumericUpDown.Value.ToString();
            userInputs.InputGender = genderComboBox.SelectedItem.ToString();
            userInputs.InputPassword = txtPassword.Text;
            userInputs.InputReenterdPassword = txtReenterPwd.Text;
            userInputs.InputContact = txtContact.Text;
            userInputs.InputCaptchaText = txtCaptchaOriginal.Text;
            userInputs.InputCaptchaUserText = txtCaptchaInput.Text;
            userInputs.CheckBoxChack = checkBoxRoller.Checked;
        } //Save User Inputs into userinput Class
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        } 
        private void txtReenterPwd_TextChanged(object sender, EventArgs e)
        {
            txtReenterPwd.UseSystemPasswordChar = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateSelected = dateTimePicker1.Value;
            int age = DateTime.Now.Year - dateSelected.Year;
            txtBoxAge.Text = age.ToString();
            txtBoxAge.Visible = true; labelAge.Visible = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        private void FillSampleData()
        {
            Info information = new Info();
            information.Name = "testName";
            information.Address = "testAddress";
            information.DOB = DateTime.Now;
            information.Email = "a@b.c";
            information.CoordinatesX = 54;
            information.CoordinatesY = 89;
            information.Gender = "male";
            information.Contact = 03211234567;
            information.Password = "Bonfire666";
            information.IQ = 167;
            SetData(information);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            genderComboBox.Items.Add(gender.Select);
            genderComboBox.Items.Add(gender.Female);
            genderComboBox.Items.Add(gender.Male);
            genderComboBox.Items.Add(gender.TestGender01);
            genderComboBox.Items.Add(gender.TestGender02);
            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            //genderComboBox.SelectedIndex = 0;
            FillSampleData();
            listBoxProfiles.Text = container.Profiles.ToString();

            //listBoxProfiles.DataSource = container.Profiles;
            //listBoxProfiles.DisplayMember = "Name";
        }
        private void saveToFileBtn_Click(object sender, EventArgs e)
        {
            /*//Stream stream = File.Open(filename, FileMode.Create);
            TextWriter writer = new StreamWriter("SavedInfo.xml");
            XmlSerializer XmlSerial = new XmlSerializer(typeof(Info));
            //BinaryFormatter bFormatter = new BinaryFormatter();
            //bFormatter.Serialize(stream, container.Profiles);
            XmlSerial.Serialize(writer, container.Profiles);
            writer.Close();

            MessageBox.Show("File Saved Successfully");*/
        } //Commented
        private void readFromFileBtn_Click(object sender, EventArgs e)
        {
            /*Info InfoReadFromFile = new Info();
            Stream OutputStream = File.Open(filename, FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();
            InfoReadFromFile = (Info)bformatter.Deserialize(OutputStream);
            OutputStream.Close();

            MessageBox.Show("Read From File Successful");
            propertyGrid1.SelectedObject = InfoReadFromFile;
            //SetData(InfoReadFromFile);
            showSavedData(InfoReadFromFile);*/
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            editFlag = false;
            toolStripStatusLabel1.Text = "Adding Profile";
            Info information = new Info();
            SetData(information);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //listBoxProfiles.SelectedItem.ToString();
            try
            {
                toolStripStatusLabel1.Text = "Edit in progress";
                returnedObjectToEdit = container.EditProfile(listBoxProfiles.Text);
                SetData(returnedObjectToEdit);
                editFlag = true;
            }
            catch { MessageBox.Show("Please Select a Profile to Edit"); }
            
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = "Delete in process";
                toolStripProgressBar1.PerformStep();
                container.DeleteProfile(listBoxProfiles.SelectedItem.ToString());
                Info information = new Info();
                SetData(information);
                MessageBox.Show("Profile Deleted Successfully");
                listBoxProfiles.Items.RemoveAt(listBoxProfiles.SelectedIndex);
            }
            catch { MessageBox.Show("Please Select a Profile to Delete"); }
            //listBoxProfiles.Items.Remove(listBoxProfiles.SelectedItem);

        }
        private void btnFillSampleData_Click(object sender, EventArgs e)
        {
            FillSampleData();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (container.Compare(listBoxProfiles.SelectedItem.ToString()))
                MessageBox.Show("Object Found");
            else
                MessageBox.Show("Object Not Found");
        }
        private void showGridBtn_Click(object sender, EventArgs e)
        {
            if (secondForm.IsDisposed) { Form2 SecondFormTemp = new Form2(); secondForm = SecondFormTemp; }
            secondForm.ReadDataFromFile();
            secondForm.Show();
        }


    }
    //=============================================================================================================================//

    public interface IPropertyNotification : INotifyPropertyChanged
    {

    }
    [Serializable()]
    public class PropertyNotificationObject : IPropertyNotification
    {
        [field:NonSerialized()]
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventArgs e = new PropertyChangedEventArgs(propertyName);
            OnPropertyChanged(e);
        }
        [field:NonSerialized()]
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler temp = this.PropertyChanged;
            if (null != temp)
                temp(this, e);
        }
    }

    //===========================================================================================================================//


    [Serializable()]
    class Info : PropertyNotificationObject
    {
        
        private DateTime dOB;
        private int coordinatesX, coordinatesY, iQ;
        private string name, address, email, password, gender;
        private double contact;

        public string Name
        {
            get { return name; }
            set
            {
                if (Object.Equals(value, this.name) == false && this.name != null)
                {
                    this.name = value;
                    OnPropertyChanged("Name");
                }
                name = value;
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (Object.Equals(this.gender, value) == false && this.gender != null)
                {
                    this.gender = value;
                    OnPropertyChanged("Gender");
                }
                gender = value;
            }
        }
        public DateTime DOB
        {
            get { return dOB; }
            set
            {

                dOB = value;
            }
        }
        public int IQ
        {
            get { return iQ; }
            set
            {
                if (Object.Equals(this.iQ, value) == false && this.iQ != 0)
                {
                    this.iQ = value;
                    OnPropertyChanged("IQ");
                }
                iQ = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (Object.Equals(this.address, value) == false && this.address != null)
                {
                    this.address = value;
                    OnPropertyChanged("Address");
                }
                address = value;
            }
        }
        public int CoordinatesY
        {
            get { return coordinatesY; }
            set
            {
                if (Object.Equals(this.coordinatesY, value) == false && this.coordinatesY != 0)
                {
                    this.coordinatesY = value;
                    OnPropertyChanged("CoordinatesY");
                }
                coordinatesY = value;
            }
        }
        public int CoordinatesX
        {
            get { return coordinatesX; }
            set
            {
                if (Object.Equals(this.coordinatesX, value) == false && this.coordinatesX != 0)
                {
                    this.coordinatesX = value;
                    OnPropertyChanged("CoordinatesX");
                }
                coordinatesX = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (Object.Equals(this.email, value) == false && this.email != null)
                {
                    this.email = value;
                    OnPropertyChanged("Email");
                }
                email = value;
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public double Contact
        {
            
            get { return contact; }
            set
            {
                Double test = 0;

                if (Object.Equals(value, this.contact) == false && this.contact != 0)
                {
                    this.contact = value;
                    OnPropertyChanged("Contact");
                }
                contact = value;
            }
        }
        public override string ToString()
        {
            string result = "Name: "+name+" \n\nDOB: "+dOB.ToShortDateString()+" \n\nAddress: "+address+" \n\nEmail: "+email+"\n\nIQ: "+iQ+"\n\nContact: "+contact;
            return result;
        }
    }

   //============================================================================================================================//
    [Serializable]
    class ContainerClass
    {
        public delegate void AddProfileEventHandler(object sender);//, EventArgs e);
        public delegate void EditProfileEventHandler(object sender);//, EventArgs e);
        public delegate void DeleteProfileEventHandler(object sender);//, EventArgs e);
        private List<Info> listOfProfiles = new List<Info>();

        public delegate bool ValidateInputs(object currentProfile);
        public event AddProfileEventHandler AddProfileEvent;
        public event EditProfileEventHandler EditProfileEvent;
        public event DeleteProfileEventHandler DeleteProfileEvent;

        
        public ContainerClass() { }
        [XmlElement]
        public List<Info> Profiles
        {
            get { return listOfProfiles; }
            set { listOfProfiles = value; }
        }
        public void AddProfile(Info profileToAdd)
        {
            //Action OnAddNewClick = OnAddingProfile;
            //OnAddNewClick();
            Profiles.Add(profileToAdd);
            //EventArgs e = new EventArgs();
            OnAddingProfile();
        }
        protected void OnAddingProfile()//EventArgs e)
        {
            if(AddProfileEvent!=null)
            {
                
                AddProfileEvent(this);//, e);
            }
        }
        public Info FindProfile(string NameOfProfile)
        {
            for (int i = listOfProfiles.Count - 1; i >= 0; i--)
            {
                Info temp = listOfProfiles[i].Name == NameOfProfile ? listOfProfiles[i] : null;
                return temp;
            }
            return null;
        }
        public void UpdateProfile(Info profileToUpdate)
        {
            for (int i = listOfProfiles.Count - 1; i >= 0; i--)
            {
                if (listOfProfiles[i].Name == profileToUpdate.Name)
                {
                    listOfProfiles[i] = profileToUpdate;
                }
            }
        }
        public Info EditProfile(string nameOfProfileToEdit)
        {
            //Action EditEventAction = OnEditingProfile;
            //EditEventAction();
            OnEditingProfile();
            foreach (Info profile in listOfProfiles)
            {
                if (profile.Name == nameOfProfileToEdit)
                   return profile;
            }
            return null;
        }
        protected void OnEditingProfile()
        {
            if(EditProfileEvent!=null)
            {
                EditProfileEvent(this);
            }
        }
        public void DeleteProfile(string nameOfProfileToDelete)
        {
            //Action DeleteEventAction = OnDeleteProfile;
            //DeleteEventAction();
            //EventArgs e = new EventArgs();
            OnDeleteProfile();
            for (int i = listOfProfiles.Count - 1; i >= 0 ; i-- )
            {
               if(listOfProfiles[i].Name==nameOfProfileToDelete)
               {
                   listOfProfiles.RemoveAt(i);
               }
            }
        }
        protected void OnDeleteProfile()//EventArgs e)
        {
            if(DeleteProfileEvent!= null)
            {
                DeleteProfileEvent(this);
            }
        }
        public bool Compare(string nameOfObjectToCompare)
        {
            Info searchResult = listOfProfiles.Find(searchProfile => searchProfile.Name == nameOfObjectToCompare);
            foreach(Info profile in listOfProfiles)
            {
                if (profile == searchResult)
                    return true;
            }
            return false;
        }
        public bool ValidateInput(UserInputs userInputsToCheck)
        {
            string emailRegex = @".@.\..";
            Match match = Regex.Match(userInputsToCheck.InputEmail, emailRegex);
            if (userInputsToCheck.CheckBoxChack)
                if (match.Success)
                    // We can add separate if checks to identify which condition went wrong
                    if (userInputsToCheck.InputCoordinatesX.All(char.IsDigit) && userInputsToCheck.InputCoordinatesY.All(char.IsDigit) && userInputsToCheck.InputIq.All(char.IsDigit) &&
                        userInputsToCheck.InputContact.All(char.IsDigit) && userInputsToCheck.InputPassword.Any(char.IsDigit) && userInputsToCheck.InputPassword == userInputsToCheck.InputReenterdPassword &&
                        userInputsToCheck.InputCaptchaText == userInputsToCheck.InputCaptchaUserText && userInputsToCheck.InputPassword.Length > 7 && userInputsToCheck.InputPassword.Any(char.IsUpper) &&
                        userInputsToCheck.InputGender != "Select" && userInputsToCheck.InputName != "")
                        return true;
                    else
                        return false;
                else
                { MessageBox.Show("Invalid Email"); return false; }
            else { MessageBox.Show("Please Check If You Are Ready"); return false; }
                
            
        }
        public void SaveDataOfWrapperClass(Info information, UserInputs userInputs)
        {
            information.Name = userInputs.InputName;
            information.Address = userInputs.InputAddress;
            information.CoordinatesX = Convert.ToInt32(userInputs.InputCoordinatesX);
            information.CoordinatesY = Convert.ToInt32(userInputs.InputCoordinatesY);
            information.Email = userInputs.InputEmail;
            information.Gender = userInputs.InputGender;
            information.Password = userInputs.InputPassword;
            information.DOB = DateTime.Parse(userInputs.InputDob);
            information.IQ = Convert.ToInt32(userInputs.InputIq);
            information.Contact = Convert.ToInt64(userInputs.InputContact);
        }
    }

    //===========================================================================================================================//
    class UserInputs
    {
        private string inputDob;
        private string inputContact;
        private string inputCoordinatesX, inputCoordinatesY, inputIq;
        private string inputCaptchaText, inputCaptchaUserText, inputName, inputAddress, inputEmail, inputPassword, inputGender, inputReenterdPassword;
        private bool checkBoxChack;

        public bool CheckBoxChack
        {
            get { return checkBoxChack; }
            set { checkBoxChack = value; }
        }
        public string InputDob
        {
            get { return inputDob; }
            set { inputDob = value; }
        }
        public string InputIq
        {
            get { return inputIq; }
            set { inputIq = value; }
        }
        public string InputCoordinatesY
        {
            get { return inputCoordinatesY; }
            set { inputCoordinatesY = value; }
        }
        public string InputCoordinatesX
        {
            get { return inputCoordinatesX; }
            set { inputCoordinatesX = value; }
        }
        public string InputReenterdPassword
        {
            get { return inputReenterdPassword; }
            set { inputReenterdPassword = value; }
        }
        public string InputGender
        {
            get { return inputGender; }
            set { inputGender = value; }
        }
        public string InputPassword
        {
            get { return inputPassword; }
            set { inputPassword = value; }
        }
        public string InputEmail
        {
            get { return inputEmail; }
            set { inputEmail = value; }
        }
        public string InputAddress
        {
            get { return inputAddress; }
            set { inputAddress = value; }
        }
        public string InputName
        {
            get { return inputName; }
            set { inputName = value; }
        }
        public string InputCaptchaUserText
        {
            get { return inputCaptchaUserText; }
            set { inputCaptchaUserText = value; }
        }
        public string InputCaptchaText
        {
            get { return inputCaptchaText; }
            set { inputCaptchaText = value; }
        }
        public string InputContact
        {
            get { return inputContact; }
            set { inputContact = value; }
        }
    }
}