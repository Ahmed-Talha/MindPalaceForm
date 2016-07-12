namespace MindPalaceForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.labelCerebral = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelIQ = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelReenterPwd = new System.Windows.Forms.Label();
            this.txtReenterPwd = new System.Windows.Forms.TextBox();
            this.txtRichInstructions = new System.Windows.Forms.RichTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCaptchaOriginal = new System.Windows.Forms.TextBox();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.txtCaptchaInput = new System.Windows.Forms.TextBox();
            this.checkBoxRoller = new System.Windows.Forms.CheckBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelDOB = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelAge = new System.Windows.Forms.Label();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.iQNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanelCoordinates = new System.Windows.Forms.TableLayoutPanel();
            this.txtCoordinatesY = new System.Windows.Forms.TextBox();
            this.txtCoordinatesX = new System.Windows.Forms.TextBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.captchaTextShow = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.readFromFileBtn = new System.Windows.Forms.Button();
            this.objectShowTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listBoxProfiles = new System.Windows.Forms.ListBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFillSampleData = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.showGridBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iQNumericUpDown)).BeginInit();
            this.tableLayoutPanelCoordinates.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitle.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitle.Location = new System.Drawing.Point(179, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(375, 55);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Registration Form";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.UseMnemonic = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelName.Location = new System.Drawing.Point(25, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 18);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(157, 11);
            this.txtName.MinimumSize = new System.Drawing.Size(100, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(373, 24);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAddress.Location = new System.Drawing.Point(25, 72);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 18);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(157, 72);
            this.txtAddress.MinimumSize = new System.Drawing.Size(100, 24);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(373, 24);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelCoordinates.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCoordinates.Location = new System.Drawing.Point(24, 16);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(83, 18);
            this.labelCoordinates.TabIndex = 7;
            this.labelCoordinates.Text = "Coordinates";
            // 
            // labelCerebral
            // 
            this.labelCerebral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCerebral.AutoSize = true;
            this.labelCerebral.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelCerebral.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCerebral.Location = new System.Drawing.Point(25, 49);
            this.labelCerebral.Name = "labelCerebral";
            this.labelCerebral.Size = new System.Drawing.Size(95, 18);
            this.labelCerebral.TabIndex = 9;
            this.labelCerebral.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(156, 44);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(374, 24);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelIQ
            // 
            this.labelIQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIQ.AutoSize = true;
            this.labelIQ.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelIQ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIQ.Location = new System.Drawing.Point(25, 75);
            this.labelIQ.Name = "labelIQ";
            this.labelIQ.Size = new System.Drawing.Size(28, 18);
            this.labelIQ.TabIndex = 11;
            this.labelIQ.Text = "I  Q";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPassword.Location = new System.Drawing.Point(25, 102);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 18);
            this.labelPassword.TabIndex = 13;
            this.labelPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(157, 100);
            this.txtPassword.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(374, 24);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // labelReenterPwd
            // 
            this.labelReenterPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReenterPwd.AutoSize = true;
            this.labelReenterPwd.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelReenterPwd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelReenterPwd.Location = new System.Drawing.Point(26, 34);
            this.labelReenterPwd.Name = "labelReenterPwd";
            this.labelReenterPwd.Size = new System.Drawing.Size(125, 18);
            this.labelReenterPwd.TabIndex = 15;
            this.labelReenterPwd.Text = "Re-enter Password";
            // 
            // txtReenterPwd
            // 
            this.txtReenterPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReenterPwd.Location = new System.Drawing.Point(157, 28);
            this.txtReenterPwd.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtReenterPwd.Name = "txtReenterPwd";
            this.txtReenterPwd.Size = new System.Drawing.Size(373, 24);
            this.txtReenterPwd.TabIndex = 16;
            this.txtReenterPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReenterPwd.TextChanged += new System.EventHandler(this.txtReenterPwd_TextChanged);
            // 
            // txtRichInstructions
            // 
            this.txtRichInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRichInstructions.BackColor = System.Drawing.Color.Linen;
            this.txtRichInstructions.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtRichInstructions.ForeColor = System.Drawing.Color.DarkRed;
            this.txtRichInstructions.Location = new System.Drawing.Point(158, 130);
            this.txtRichInstructions.MinimumSize = new System.Drawing.Size(200, 40);
            this.txtRichInstructions.Name = "txtRichInstructions";
            this.txtRichInstructions.ReadOnly = true;
            this.txtRichInstructions.Size = new System.Drawing.Size(373, 42);
            this.txtRichInstructions.TabIndex = 17;
            this.txtRichInstructions.Text = "Password must have atleast EIGHT characters, atleast ONE Digit and atleast ONE up" +
    "percase letter";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelPhone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPhone.Location = new System.Drawing.Point(25, 57);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(65, 18);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Contact : ";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.Location = new System.Drawing.Point(157, 55);
            this.txtContact.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(373, 24);
            this.txtContact.TabIndex = 19;
            this.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCaptchaOriginal
            // 
            this.txtCaptchaOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaptchaOriginal.Location = new System.Drawing.Point(157, 82);
            this.txtCaptchaOriginal.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtCaptchaOriginal.Name = "txtCaptchaOriginal";
            this.txtCaptchaOriginal.Size = new System.Drawing.Size(373, 24);
            this.txtCaptchaOriginal.TabIndex = 20;
            this.txtCaptchaOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelCaptcha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCaptcha.Location = new System.Drawing.Point(25, 107);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(34, 18);
            this.labelCaptcha.TabIndex = 21;
            this.labelCaptcha.Text = "Text";
            // 
            // txtCaptchaInput
            // 
            this.txtCaptchaInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaptchaInput.Location = new System.Drawing.Point(157, 109);
            this.txtCaptchaInput.MinimumSize = new System.Drawing.Size(100, 21);
            this.txtCaptchaInput.Name = "txtCaptchaInput";
            this.txtCaptchaInput.Size = new System.Drawing.Size(373, 24);
            this.txtCaptchaInput.TabIndex = 22;
            this.txtCaptchaInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxRoller
            // 
            this.checkBoxRoller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRoller.AutoSize = true;
            this.checkBoxRoller.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkBoxRoller.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxRoller.Location = new System.Drawing.Point(187, 9);
            this.checkBoxRoller.Name = "checkBoxRoller";
            this.checkBoxRoller.Size = new System.Drawing.Size(214, 23);
            this.checkBoxRoller.TabIndex = 23;
            this.checkBoxRoller.Text = "I Am Ready and Good to GO!";
            this.checkBoxRoller.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccept.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnAccept.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnAccept.Location = new System.Drawing.Point(81, 37);
            this.btnAccept.MinimumSize = new System.Drawing.Size(100, 41);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(189, 41);
            this.btnAccept.TabIndex = 24;
            this.btnAccept.Text = "A C C E P T ";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCancel.Location = new System.Drawing.Point(285, 38);
            this.btnCancel.MinimumSize = new System.Drawing.Size(100, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 41);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "C A N C E L ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelDOB
            // 
            this.labelDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelDOB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDOB.Location = new System.Drawing.Point(24, 48);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(86, 18);
            this.labelDOB.TabIndex = 27;
            this.labelDOB.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 45);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(150, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 21);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelAge
            // 
            this.labelAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelAge.Location = new System.Drawing.Point(378, 45);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 18);
            this.labelAge.TabIndex = 29;
            this.labelAge.Text = "Age";
            this.labelAge.Visible = false;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxAge.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxAge.Location = new System.Drawing.Point(430, 41);
            this.txtBoxAge.MinimumSize = new System.Drawing.Size(100, 24);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.ReadOnly = true;
            this.txtBoxAge.Size = new System.Drawing.Size(100, 24);
            this.txtBoxAge.TabIndex = 30;
            this.txtBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxAge.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.txtBoxAge);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.labelDOB);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.labelAddress);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 117);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // iQNumericUpDown
            // 
            this.iQNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iQNumericUpDown.Font = new System.Drawing.Font("Calibri", 10F);
            this.iQNumericUpDown.Location = new System.Drawing.Point(157, 72);
            this.iQNumericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.iQNumericUpDown.MaximumSize = new System.Drawing.Size(77, 0);
            this.iQNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.iQNumericUpDown.MinimumSize = new System.Drawing.Size(50, 0);
            this.iQNumericUpDown.Name = "iQNumericUpDown";
            this.iQNumericUpDown.Size = new System.Drawing.Size(68, 24);
            this.iQNumericUpDown.TabIndex = 33;
            this.iQNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iQNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tableLayoutPanelCoordinates
            // 
            this.tableLayoutPanelCoordinates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCoordinates.ColumnCount = 2;
            this.tableLayoutPanelCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCoordinates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCoordinates.Controls.Add(this.txtCoordinatesY, 1, 0);
            this.tableLayoutPanelCoordinates.Controls.Add(this.txtCoordinatesX, 0, 0);
            this.tableLayoutPanelCoordinates.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.tableLayoutPanelCoordinates.Location = new System.Drawing.Point(153, 9);
            this.tableLayoutPanelCoordinates.MinimumSize = new System.Drawing.Size(225, 30);
            this.tableLayoutPanelCoordinates.Name = "tableLayoutPanelCoordinates";
            this.tableLayoutPanelCoordinates.RowCount = 1;
            this.tableLayoutPanelCoordinates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCoordinates.Size = new System.Drawing.Size(230, 30);
            this.tableLayoutPanelCoordinates.TabIndex = 34;
            // 
            // txtCoordinatesY
            // 
            this.txtCoordinatesY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoordinatesY.Location = new System.Drawing.Point(118, 3);
            this.txtCoordinatesY.MaximumSize = new System.Drawing.Size(100, 24);
            this.txtCoordinatesY.Name = "txtCoordinatesY";
            this.txtCoordinatesY.Size = new System.Drawing.Size(100, 24);
            this.txtCoordinatesY.TabIndex = 35;
            this.txtCoordinatesY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCoordinatesX
            // 
            this.txtCoordinatesX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoordinatesX.Location = new System.Drawing.Point(3, 3);
            this.txtCoordinatesX.MaximumSize = new System.Drawing.Size(100, 24);
            this.txtCoordinatesX.Name = "txtCoordinatesX";
            this.txtCoordinatesX.Size = new System.Drawing.Size(100, 24);
            this.txtCoordinatesX.TabIndex = 8;
            this.txtCoordinatesX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Calibri", 11F);
            this.labelGender.Location = new System.Drawing.Point(255, 74);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(54, 18);
            this.labelGender.TabIndex = 35;
            this.labelGender.Text = "Gender";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(315, 74);
            this.genderComboBox.MaximumSize = new System.Drawing.Size(300, 0);
            this.genderComboBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(216, 23);
            this.genderComboBox.TabIndex = 36;
            // 
            // captchaTextShow
            // 
            this.captchaTextShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.captchaTextShow.AutoSize = true;
            this.captchaTextShow.Font = new System.Drawing.Font("Calibri", 11F);
            this.captchaTextShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.captchaTextShow.Location = new System.Drawing.Point(25, 82);
            this.captchaTextShow.Name = "captchaTextShow";
            this.captchaTextShow.Size = new System.Drawing.Size(86, 18);
            this.captchaTextShow.TabIndex = 38;
            this.captchaTextShow.Text = "Captcha Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.groupBox2.Controls.Add(this.labelCoordinates);
            this.groupBox2.Controls.Add(this.tableLayoutPanelCoordinates);
            this.groupBox2.Controls.Add(this.labelCerebral);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.genderComboBox);
            this.groupBox2.Controls.Add(this.labelIQ);
            this.groupBox2.Controls.Add(this.labelGender);
            this.groupBox2.Controls.Add(this.iQNumericUpDown);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtRichInstructions);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(15, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(579, 195);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "More Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.groupBox3.Controls.Add(this.labelReenterPwd);
            this.groupBox3.Controls.Add(this.txtReenterPwd);
            this.groupBox3.Controls.Add(this.labelPhone);
            this.groupBox3.Controls.Add(this.captchaTextShow);
            this.groupBox3.Controls.Add(this.txtContact);
            this.groupBox3.Controls.Add(this.txtCaptchaOriginal);
            this.groupBox3.Controls.Add(this.txtCaptchaInput);
            this.groupBox3.Controls.Add(this.labelCaptcha);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(15, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 149);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.propertyGrid1.CategorySplitterColor = System.Drawing.Color.DodgerBlue;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.DarkTurquoise;
            this.propertyGrid1.DisabledItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.DodgerBlue;
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.Desktop;
            this.propertyGrid1.Location = new System.Drawing.Point(908, 0);
            this.propertyGrid1.MaximumSize = new System.Drawing.Size(300, 500);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(10, 10);
            this.propertyGrid1.TabIndex = 41;
            this.propertyGrid1.ViewBackColor = System.Drawing.Color.DodgerBlue;
            this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.HighlightText;
            this.propertyGrid1.Visible = false;
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.saveToFileBtn.Location = new System.Drawing.Point(81, 79);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(189, 23);
            this.saveToFileBtn.TabIndex = 42;
            this.saveToFileBtn.Text = "Save To file";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            this.saveToFileBtn.Click += new System.EventHandler(this.saveToFileBtn_Click);
            // 
            // readFromFileBtn
            // 
            this.readFromFileBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.readFromFileBtn.Location = new System.Drawing.Point(285, 79);
            this.readFromFileBtn.Name = "readFromFileBtn";
            this.readFromFileBtn.Size = new System.Drawing.Size(190, 23);
            this.readFromFileBtn.TabIndex = 43;
            this.readFromFileBtn.Text = "Read From file";
            this.readFromFileBtn.UseVisualStyleBackColor = true;
            this.readFromFileBtn.Visible = false;
            this.readFromFileBtn.Click += new System.EventHandler(this.readFromFileBtn_Click);
            // 
            // objectShowTextBox
            // 
            this.objectShowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.objectShowTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.objectShowTextBox.Font = new System.Drawing.Font("Calibri", 11F);
            this.objectShowTextBox.Location = new System.Drawing.Point(6, 116);
            this.objectShowTextBox.Multiline = true;
            this.objectShowTextBox.Name = "objectShowTextBox";
            this.objectShowTextBox.Size = new System.Drawing.Size(568, 41);
            this.objectShowTextBox.TabIndex = 44;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(936, 0);
            this.pictureBox.MaximumSize = new System.Drawing.Size(200, 833);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 833);
            this.pictureBox.TabIndex = 26;
            this.pictureBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 12F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(55, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(610, 701);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "P R O F I L E";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.groupBox5.Controls.Add(this.checkBoxRoller);
            this.groupBox5.Controls.Add(this.btnAccept);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.objectShowTextBox);
            this.groupBox5.Controls.Add(this.saveToFileBtn);
            this.groupBox5.Controls.Add(this.readFromFileBtn);
            this.groupBox5.Font = new System.Drawing.Font("Calibri", 10F);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(15, 504);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(579, 165);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Confirmation and Result";
            // 
            // listBoxProfiles
            // 
            this.listBoxProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProfiles.Font = new System.Drawing.Font("Calibri", 12F);
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.ItemHeight = 19;
            this.listBoxProfiles.Location = new System.Drawing.Point(730, 89);
            this.listBoxProfiles.MinimumSize = new System.Drawing.Size(166, 308);
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.Size = new System.Drawing.Size(166, 479);
            this.listBoxProfiles.TabIndex = 46;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnAddNew.Location = new System.Drawing.Point(730, 596);
            this.btnAddNew.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(166, 23);
            this.btnAddNew.TabIndex = 47;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnEdit.Location = new System.Drawing.Point(730, 625);
            this.btnEdit.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(166, 23);
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnDelete.Location = new System.Drawing.Point(730, 654);
            this.btnDelete.MinimumSize = new System.Drawing.Size(75, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 23);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFillSampleData
            // 
            this.btnFillSampleData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFillSampleData.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnFillSampleData.Location = new System.Drawing.Point(730, 682);
            this.btnFillSampleData.MinimumSize = new System.Drawing.Size(166, 23);
            this.btnFillSampleData.Name = "btnFillSampleData";
            this.btnFillSampleData.Size = new System.Drawing.Size(166, 23);
            this.btnFillSampleData.TabIndex = 50;
            this.btnFillSampleData.Text = "Fill Sample Data";
            this.btnFillSampleData.UseVisualStyleBackColor = true;
            this.btnFillSampleData.Click += new System.EventHandler(this.btnFillSampleData_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnTest.Location = new System.Drawing.Point(730, 711);
            this.btnTest.MinimumSize = new System.Drawing.Size(166, 23);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(166, 23);
            this.btnTest.TabIndex = 51;
            this.btnTest.Text = "Compare";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 811);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(936, 22);
            this.statusBar.TabIndex = 52;
            this.statusBar.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Step = 100;
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Ready To Go ";
            // 
            // showGridBtn
            // 
            this.showGridBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showGridBtn.Font = new System.Drawing.Font("Calibri", 10F);
            this.showGridBtn.Location = new System.Drawing.Point(730, 740);
            this.showGridBtn.MinimumSize = new System.Drawing.Size(166, 23);
            this.showGridBtn.Name = "showGridBtn";
            this.showGridBtn.Size = new System.Drawing.Size(166, 23);
            this.showGridBtn.TabIndex = 53;
            this.showGridBtn.Text = "Show Profile Grid";
            this.showGridBtn.UseVisualStyleBackColor = true;
            this.showGridBtn.Click += new System.EventHandler(this.showGridBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(100)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(1136, 833);
            this.Controls.Add(this.showGridBtn);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnFillSampleData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.listBoxProfiles);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Calibri", 8F);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MinimumSize = new System.Drawing.Size(1150, 872);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iQNumericUpDown)).EndInit();
            this.tableLayoutPanelCoordinates.ResumeLayout(false);
            this.tableLayoutPanelCoordinates.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Label labelCerebral;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelIQ;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelReenterPwd;
        private System.Windows.Forms.TextBox txtReenterPwd;
        private System.Windows.Forms.RichTextBox txtRichInstructions;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtCaptchaOriginal;
        private System.Windows.Forms.Label labelCaptcha;
        private System.Windows.Forms.TextBox txtCaptchaInput;
        private System.Windows.Forms.CheckBox checkBoxRoller;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.NumericUpDown iQNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCoordinates;
        private System.Windows.Forms.TextBox txtCoordinatesX;
        private System.Windows.Forms.TextBox txtCoordinatesY;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label captchaTextShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.Button readFromFileBtn;
        private System.Windows.Forms.TextBox objectShowTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxProfiles;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFillSampleData;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button showGridBtn;
       
    }
}

