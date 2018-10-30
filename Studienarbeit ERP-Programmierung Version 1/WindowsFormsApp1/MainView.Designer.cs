namespace WindowsFormsApp1
{
    partial class MainView
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
            this.Passwörter = new System.Windows.Forms.TabControl();
            this.Mitarbeiter = new System.Windows.Forms.TabPage();
            this.infoLabel = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.adressCodeBox = new System.Windows.Forms.TextBox();
            this.regionBox = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.ComboBox();
            this.plzLabel = new System.Windows.Forms.Label();
            this.adressCodeLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.persNrLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.faxLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.faxBox = new System.Windows.Forms.TextBox();
            this.persNrBox = new System.Windows.Forms.TextBox();
            this.functionBox = new System.Windows.Forms.TextBox();
            this.plzBox = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.employeeListView = new System.Windows.Forms.ListView();
            this.logoutButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.telLabel = new System.Windows.Forms.Label();
            this.regionLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.getListButton = new System.Windows.Forms.Button();
            this.listEmployeeLabel = new System.Windows.Forms.Label();
            this.Passwoerter = new System.Windows.Forms.TabPage();
            this.passwordListView = new System.Windows.Forms.ListView();
            this.logoutPWButton = new System.Windows.Forms.Button();
            this.closePWButton = new System.Windows.Forms.Button();
            this.hintLabel = new System.Windows.Forms.Label();
            this.pWLabel = new System.Windows.Forms.Label();
            this.passwordWdhBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.changePWButton = new System.Windows.Forms.Button();
            this.createButtonPW = new System.Windows.Forms.Button();
            this.initButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.confirmPWButton = new System.Windows.Forms.Button();
            this.showPWButton = new System.Windows.Forms.Button();
            this.listLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Passwörter.SuspendLayout();
            this.Mitarbeiter.SuspendLayout();
            this.Passwoerter.SuspendLayout();
            this.SuspendLayout();
            // 
            // Passwörter
            // 
            this.Passwörter.Controls.Add(this.Mitarbeiter);
            this.Passwörter.Controls.Add(this.Passwoerter);
            this.Passwörter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwörter.Location = new System.Drawing.Point(3, 12);
            this.Passwörter.Name = "Passwörter";
            this.Passwörter.SelectedIndex = 0;
            this.Passwörter.Size = new System.Drawing.Size(1325, 714);
            this.Passwörter.TabIndex = 0;
            // 
            // Mitarbeiter
            // 
            this.Mitarbeiter.BackColor = System.Drawing.Color.White;
            this.Mitarbeiter.Controls.Add(this.infoLabel);
            this.Mitarbeiter.Controls.Add(this.streetBox);
            this.Mitarbeiter.Controls.Add(this.countryBox);
            this.Mitarbeiter.Controls.Add(this.adressCodeBox);
            this.Mitarbeiter.Controls.Add(this.regionBox);
            this.Mitarbeiter.Controls.Add(this.titleBox);
            this.Mitarbeiter.Controls.Add(this.plzLabel);
            this.Mitarbeiter.Controls.Add(this.adressCodeLabel);
            this.Mitarbeiter.Controls.Add(this.streetLabel);
            this.Mitarbeiter.Controls.Add(this.persNrLabel);
            this.Mitarbeiter.Controls.Add(this.customerLabel);
            this.Mitarbeiter.Controls.Add(this.countryLabel);
            this.Mitarbeiter.Controls.Add(this.faxLabel);
            this.Mitarbeiter.Controls.Add(this.cityLabel);
            this.Mitarbeiter.Controls.Add(this.titleLabel);
            this.Mitarbeiter.Controls.Add(this.emailLabel);
            this.Mitarbeiter.Controls.Add(this.functionLabel);
            this.Mitarbeiter.Controls.Add(this.telBox);
            this.Mitarbeiter.Controls.Add(this.faxBox);
            this.Mitarbeiter.Controls.Add(this.persNrBox);
            this.Mitarbeiter.Controls.Add(this.functionBox);
            this.Mitarbeiter.Controls.Add(this.plzBox);
            this.Mitarbeiter.Controls.Add(this.cityBox);
            this.Mitarbeiter.Controls.Add(this.employeeListView);
            this.Mitarbeiter.Controls.Add(this.logoutButton);
            this.Mitarbeiter.Controls.Add(this.closeButton);
            this.Mitarbeiter.Controls.Add(this.confirmButton);
            this.Mitarbeiter.Controls.Add(this.lastnameLabel);
            this.Mitarbeiter.Controls.Add(this.telLabel);
            this.Mitarbeiter.Controls.Add(this.regionLabel);
            this.Mitarbeiter.Controls.Add(this.firstnameLabel);
            this.Mitarbeiter.Controls.Add(this.firstnameBox);
            this.Mitarbeiter.Controls.Add(this.emailBox);
            this.Mitarbeiter.Controls.Add(this.lastnameBox);
            this.Mitarbeiter.Controls.Add(this.customerBox);
            this.Mitarbeiter.Controls.Add(this.createButton);
            this.Mitarbeiter.Controls.Add(this.changeButton);
            this.Mitarbeiter.Controls.Add(this.detailsButton);
            this.Mitarbeiter.Controls.Add(this.getListButton);
            this.Mitarbeiter.Controls.Add(this.listEmployeeLabel);
            this.Mitarbeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mitarbeiter.Location = new System.Drawing.Point(4, 34);
            this.Mitarbeiter.Name = "Mitarbeiter";
            this.Mitarbeiter.Padding = new System.Windows.Forms.Padding(3);
            this.Mitarbeiter.Size = new System.Drawing.Size(1317, 676);
            this.Mitarbeiter.TabIndex = 0;
            this.Mitarbeiter.Text = "Mitarbeiter";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(373, 592);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 24);
            this.infoLabel.TabIndex = 46;
            // 
            // streetBox
            // 
            this.streetBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetBox.Location = new System.Drawing.Point(625, 133);
            this.streetBox.Name = "streetBox";
            this.streetBox.ReadOnly = true;
            this.streetBox.Size = new System.Drawing.Size(216, 30);
            this.streetBox.TabIndex = 45;
            // 
            // countryBox
            // 
            this.countryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryBox.Location = new System.Drawing.Point(625, 397);
            this.countryBox.Name = "countryBox";
            this.countryBox.ReadOnly = true;
            this.countryBox.Size = new System.Drawing.Size(216, 30);
            this.countryBox.TabIndex = 43;
            // 
            // adressCodeBox
            // 
            this.adressCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressCodeBox.Location = new System.Drawing.Point(625, 459);
            this.adressCodeBox.Name = "adressCodeBox";
            this.adressCodeBox.ReadOnly = true;
            this.adressCodeBox.Size = new System.Drawing.Size(216, 30);
            this.adressCodeBox.TabIndex = 42;
            // 
            // regionBox
            // 
            this.regionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionBox.Location = new System.Drawing.Point(625, 333);
            this.regionBox.Name = "regionBox";
            this.regionBox.ReadOnly = true;
            this.regionBox.Size = new System.Drawing.Size(216, 30);
            this.regionBox.TabIndex = 40;
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titleBox.DisplayMember = "wählen";
            this.titleBox.Enabled = false;
            this.titleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.FormattingEnabled = true;
            this.titleBox.Items.AddRange(new object[] {
            "Frau",
            "Herr"});
            this.titleBox.Location = new System.Drawing.Point(202, 89);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(133, 30);
            this.titleBox.TabIndex = 39;
            this.titleBox.Text = "--Wählen--";
            // 
            // plzLabel
            // 
            this.plzLabel.AutoSize = true;
            this.plzLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plzLabel.Location = new System.Drawing.Point(486, 202);
            this.plzLabel.Name = "plzLabel";
            this.plzLabel.Size = new System.Drawing.Size(48, 25);
            this.plzLabel.TabIndex = 38;
            this.plzLabel.Text = "PLZ";
            // 
            // adressCodeLabel
            // 
            this.adressCodeLabel.AutoSize = true;
            this.adressCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressCodeLabel.Location = new System.Drawing.Point(484, 462);
            this.adressCodeLabel.Name = "adressCodeLabel";
            this.adressCodeLabel.Size = new System.Drawing.Size(117, 25);
            this.adressCodeLabel.TabIndex = 37;
            this.adressCodeLabel.Text = "Adresscode";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.Location = new System.Drawing.Point(484, 136);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(71, 25);
            this.streetLabel.TabIndex = 36;
            this.streetLabel.Text = "Straße";
            // 
            // persNrLabel
            // 
            this.persNrLabel.AutoSize = true;
            this.persNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persNrLabel.Location = new System.Drawing.Point(25, 409);
            this.persNrLabel.Name = "persNrLabel";
            this.persNrLabel.Size = new System.Drawing.Size(160, 25);
            this.persNrLabel.TabIndex = 35;
            this.persNrLabel.Text = "Personalnummer";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(25, 524);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(70, 25);
            this.customerLabel.TabIndex = 34;
            this.customerLabel.Text = "Kunde";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(486, 400);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(56, 25);
            this.countryLabel.TabIndex = 33;
            this.countryLabel.Text = "Land";
            // 
            // faxLabel
            // 
            this.faxLabel.AutoSize = true;
            this.faxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxLabel.Location = new System.Drawing.Point(25, 355);
            this.faxLabel.Name = "faxLabel";
            this.faxLabel.Size = new System.Drawing.Size(116, 25);
            this.faxLabel.TabIndex = 31;
            this.faxLabel.Text = "Faxnummer";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(484, 273);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(58, 25);
            this.cityLabel.TabIndex = 30;
            this.cityLabel.Text = "Stadt";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(25, 90);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(76, 25);
            this.titleLabel.TabIndex = 29;
            this.titleLabel.Text = "Anrede";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(25, 246);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 25);
            this.emailLabel.TabIndex = 28;
            this.emailLabel.Text = "Email";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionLabel.Location = new System.Drawing.Point(25, 465);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(87, 25);
            this.functionLabel.TabIndex = 27;
            this.functionLabel.Text = "Funktion";
            // 
            // telBox
            // 
            this.telBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telBox.Location = new System.Drawing.Point(202, 294);
            this.telBox.Name = "telBox";
            this.telBox.ReadOnly = true;
            this.telBox.Size = new System.Drawing.Size(222, 30);
            this.telBox.TabIndex = 25;
            // 
            // faxBox
            // 
            this.faxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faxBox.Location = new System.Drawing.Point(202, 352);
            this.faxBox.Name = "faxBox";
            this.faxBox.ReadOnly = true;
            this.faxBox.Size = new System.Drawing.Size(222, 30);
            this.faxBox.TabIndex = 24;
            // 
            // persNrBox
            // 
            this.persNrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persNrBox.Location = new System.Drawing.Point(202, 406);
            this.persNrBox.Name = "persNrBox";
            this.persNrBox.ReadOnly = true;
            this.persNrBox.Size = new System.Drawing.Size(222, 30);
            this.persNrBox.TabIndex = 23;
            // 
            // functionBox
            // 
            this.functionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionBox.Location = new System.Drawing.Point(202, 462);
            this.functionBox.Name = "functionBox";
            this.functionBox.ReadOnly = true;
            this.functionBox.Size = new System.Drawing.Size(222, 30);
            this.functionBox.TabIndex = 22;
            // 
            // plzBox
            // 
            this.plzBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plzBox.Location = new System.Drawing.Point(625, 202);
            this.plzBox.Name = "plzBox";
            this.plzBox.ReadOnly = true;
            this.plzBox.Size = new System.Drawing.Size(216, 30);
            this.plzBox.TabIndex = 21;
            // 
            // cityBox
            // 
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityBox.Location = new System.Drawing.Point(625, 270);
            this.cityBox.Name = "cityBox";
            this.cityBox.ReadOnly = true;
            this.cityBox.Size = new System.Drawing.Size(216, 30);
            this.cityBox.TabIndex = 20;
            // 
            // employeeListView
            // 
            this.employeeListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeListView.Location = new System.Drawing.Point(901, 98);
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(398, 492);
            this.employeeListView.TabIndex = 19;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.SelectedIndexChanged += new System.EventHandler(this.employeeListView_SelectedIndexChanged);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.DeepPink;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(935, 612);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(131, 35);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Ausloggen";
            this.toolTip1.SetToolTip(this.logoutButton, "Klicken Sie diesen Button, wenn Sie sich ausloggen möchten");
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DeepPink;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(1168, 612);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(131, 35);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Beenden";
            this.toolTip1.SetToolTip(this.closeButton, "Klicken Sie diesen Button, wenn Sie das Programm beenden möchten");
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.DeepPink;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(22, 612);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(163, 35);
            this.confirmButton.TabIndex = 14;
            this.confirmButton.Text = "Bestätigen";
            this.toolTip1.SetToolTip(this.confirmButton, "Benutzen Sie diesen Button, wenn Sie Ihre Eingaben in den oberen Feldern\r\nbestäti" +
        "gen möchten (vorher muss der Ändern oder Anlegen Button genutzt worden sein)");
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLabel.Location = new System.Drawing.Point(25, 189);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(107, 25);
            this.lastnameLabel.TabIndex = 13;
            this.lastnameLabel.Text = "Nachname";
            // 
            // telLabel
            // 
            this.telLabel.AutoSize = true;
            this.telLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telLabel.Location = new System.Drawing.Point(25, 297);
            this.telLabel.Name = "telLabel";
            this.telLabel.Size = new System.Drawing.Size(149, 25);
            this.telLabel.TabIndex = 12;
            this.telLabel.Text = "Telefonnummer";
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regionLabel.Location = new System.Drawing.Point(486, 336);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(73, 25);
            this.regionLabel.TabIndex = 11;
            this.regionLabel.Text = "Region";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameLabel.Location = new System.Drawing.Point(25, 136);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(92, 25);
            this.firstnameLabel.TabIndex = 10;
            this.firstnameLabel.Text = "Vorname";
            // 
            // firstnameBox
            // 
            this.firstnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameBox.Location = new System.Drawing.Point(202, 133);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.ReadOnly = true;
            this.firstnameBox.Size = new System.Drawing.Size(222, 30);
            this.firstnameBox.TabIndex = 9;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(202, 243);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(222, 30);
            this.emailBox.TabIndex = 8;
            // 
            // lastnameBox
            // 
            this.lastnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameBox.Location = new System.Drawing.Point(202, 186);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.ReadOnly = true;
            this.lastnameBox.Size = new System.Drawing.Size(222, 30);
            this.lastnameBox.TabIndex = 7;
            // 
            // customerBox
            // 
            this.customerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBox.Location = new System.Drawing.Point(202, 521);
            this.customerBox.Name = "customerBox";
            this.customerBox.ReadOnly = true;
            this.customerBox.Size = new System.Drawing.Size(222, 30);
            this.customerBox.TabIndex = 6;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.DeepPink;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(285, 29);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(106, 35);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Anlegen";
            this.toolTip1.SetToolTip(this.createButton, "Klicken Sie diesen Button, wenn Sie einen neuen\r\n Eintrag in der Tabelle anlegen " +
        "möchten");
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DeepPink;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(154, 29);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(106, 35);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "Ändern";
            this.toolTip1.SetToolTip(this.changeButton, "Klicken Sie diesen Button, wenn Sie einen Eintrag verändern möchten.\r\n(Vorher mus" +
        "s ein Eintrag aus der Liste ausgewählt worden sein :) )");
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_click);
            // 
            // detailsButton
            // 
            this.detailsButton.BackColor = System.Drawing.Color.DeepPink;
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsButton.Location = new System.Drawing.Point(30, 29);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(106, 35);
            this.detailsButton.TabIndex = 3;
            this.detailsButton.Text = "Details";
            this.toolTip1.SetToolTip(this.detailsButton, "Klicken Sie diesen Button, wenn Sie sich Details zu der Liste anzeigen lassen wol" +
        "len \r\n(Das bedeutet, es muss vorher die Liste angezeigt werden! :) )");
            this.detailsButton.UseVisualStyleBackColor = false;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // getListButton
            // 
            this.getListButton.BackColor = System.Drawing.Color.DeepPink;
            this.getListButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getListButton.Location = new System.Drawing.Point(1150, 19);
            this.getListButton.Name = "getListButton";
            this.getListButton.Size = new System.Drawing.Size(130, 35);
            this.getListButton.TabIndex = 2;
            this.getListButton.Text = "Anzeigen";
            this.toolTip1.SetToolTip(this.getListButton, "Klicken Sie diesen Button wenn Sie sich die Übersicht, \r\nüber alle Einträge anzei" +
        "gen lassen möchten.");
            this.getListButton.UseVisualStyleBackColor = false;
            this.getListButton.Click += new System.EventHandler(this.getListButton_Click);
            // 
            // listEmployeeLabel
            // 
            this.listEmployeeLabel.AutoSize = true;
            this.listEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEmployeeLabel.Location = new System.Drawing.Point(930, 24);
            this.listEmployeeLabel.Name = "listEmployeeLabel";
            this.listEmployeeLabel.Size = new System.Drawing.Size(182, 25);
            this.listEmployeeLabel.TabIndex = 0;
            this.listEmployeeLabel.Text = "Liste der Mitarbeiter";
            // 
            // Passwoerter
            // 
            this.Passwoerter.Controls.Add(this.passwordListView);
            this.Passwoerter.Controls.Add(this.logoutPWButton);
            this.Passwoerter.Controls.Add(this.closePWButton);
            this.Passwoerter.Controls.Add(this.hintLabel);
            this.Passwoerter.Controls.Add(this.pWLabel);
            this.Passwoerter.Controls.Add(this.passwordWdhBox);
            this.Passwoerter.Controls.Add(this.passwordLabel);
            this.Passwoerter.Controls.Add(this.passwordBox);
            this.Passwoerter.Controls.Add(this.changePWButton);
            this.Passwoerter.Controls.Add(this.createButtonPW);
            this.Passwoerter.Controls.Add(this.initButton);
            this.Passwoerter.Controls.Add(this.deleteButton);
            this.Passwoerter.Controls.Add(this.confirmPWButton);
            this.Passwoerter.Controls.Add(this.showPWButton);
            this.Passwoerter.Controls.Add(this.listLabel);
            this.Passwoerter.Location = new System.Drawing.Point(4, 34);
            this.Passwoerter.Name = "Passwoerter";
            this.Passwoerter.Padding = new System.Windows.Forms.Padding(3);
            this.Passwoerter.Size = new System.Drawing.Size(1317, 676);
            this.Passwoerter.TabIndex = 1;
            this.Passwoerter.Text = "Passwörter";
            this.Passwoerter.UseVisualStyleBackColor = true;
            // 
            // passwordListView
            // 
            this.passwordListView.Location = new System.Drawing.Point(523, 64);
            this.passwordListView.Name = "passwordListView";
            this.passwordListView.Size = new System.Drawing.Size(357, 370);
            this.passwordListView.TabIndex = 18;
            this.passwordListView.UseCompatibleStateImageBehavior = false;
            // 
            // logoutPWButton
            // 
            this.logoutPWButton.BackColor = System.Drawing.Color.DeepPink;
            this.logoutPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutPWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutPWButton.Location = new System.Drawing.Point(521, 452);
            this.logoutPWButton.Name = "logoutPWButton";
            this.logoutPWButton.Size = new System.Drawing.Size(136, 35);
            this.logoutPWButton.TabIndex = 17;
            this.logoutPWButton.Text = "Ausloggen";
            this.logoutPWButton.UseVisualStyleBackColor = false;
            this.logoutPWButton.Click += new System.EventHandler(this.logoutPWButton_Click);
            // 
            // closePWButton
            // 
            this.closePWButton.BackColor = System.Drawing.Color.DeepPink;
            this.closePWButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closePWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closePWButton.Location = new System.Drawing.Point(744, 452);
            this.closePWButton.Name = "closePWButton";
            this.closePWButton.Size = new System.Drawing.Size(136, 35);
            this.closePWButton.TabIndex = 16;
            this.closePWButton.Text = "Beenden";
            this.closePWButton.UseVisualStyleBackColor = false;
            this.closePWButton.Click += new System.EventHandler(this.closePWButton_Click);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hintLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.hintLabel.Location = new System.Drawing.Point(32, 361);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(60, 18);
            this.hintLabel.TabIndex = 15;
            this.hintLabel.Text = "Hinweis";
            // 
            // pWLabel
            // 
            this.pWLabel.AutoSize = true;
            this.pWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pWLabel.Location = new System.Drawing.Point(30, 250);
            this.pWLabel.Name = "pWLabel";
            this.pWLabel.Size = new System.Drawing.Size(115, 48);
            this.pWLabel.TabIndex = 14;
            this.pWLabel.Text = "Passwort \r\nwiederholen";
            // 
            // passwordWdhBox
            // 
            this.passwordWdhBox.Location = new System.Drawing.Point(167, 259);
            this.passwordWdhBox.Name = "passwordWdhBox";
            this.passwordWdhBox.ReadOnly = true;
            this.passwordWdhBox.Size = new System.Drawing.Size(244, 30);
            this.passwordWdhBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(30, 201);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 25);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Passwort";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(167, 201);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(244, 30);
            this.passwordBox.TabIndex = 11;
            // 
            // changePWButton
            // 
            this.changePWButton.BackColor = System.Drawing.Color.DeepPink;
            this.changePWButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePWButton.Location = new System.Drawing.Point(21, 20);
            this.changePWButton.Name = "changePWButton";
            this.changePWButton.Size = new System.Drawing.Size(106, 35);
            this.changePWButton.TabIndex = 10;
            this.changePWButton.Text = "Ändern";
            this.changePWButton.UseVisualStyleBackColor = false;
            // 
            // createButtonPW
            // 
            this.createButtonPW.BackColor = System.Drawing.Color.DeepPink;
            this.createButtonPW.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButtonPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButtonPW.Location = new System.Drawing.Point(167, 20);
            this.createButtonPW.Name = "createButtonPW";
            this.createButtonPW.Size = new System.Drawing.Size(106, 35);
            this.createButtonPW.TabIndex = 9;
            this.createButtonPW.Text = "Erstellen";
            this.createButtonPW.UseVisualStyleBackColor = false;
            this.createButtonPW.Click += new System.EventHandler(this.createButtonPW_Click);
            // 
            // initButton
            // 
            this.initButton.BackColor = System.Drawing.Color.DeepPink;
            this.initButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.initButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initButton.Location = new System.Drawing.Point(21, 74);
            this.initButton.Name = "initButton";
            this.initButton.Size = new System.Drawing.Size(106, 35);
            this.initButton.TabIndex = 8;
            this.initButton.Text = "Init";
            this.initButton.UseVisualStyleBackColor = false;
            this.initButton.Click += new System.EventHandler(this.initButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DeepPink;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(167, 74);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(106, 35);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Löschen";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // confirmPWButton
            // 
            this.confirmPWButton.BackColor = System.Drawing.Color.DeepPink;
            this.confirmPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmPWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPWButton.Location = new System.Drawing.Point(35, 452);
            this.confirmPWButton.Name = "confirmPWButton";
            this.confirmPWButton.Size = new System.Drawing.Size(155, 35);
            this.confirmPWButton.TabIndex = 6;
            this.confirmPWButton.Text = "Bestätigen";
            this.confirmPWButton.UseVisualStyleBackColor = false;
            // 
            // showPWButton
            // 
            this.showPWButton.BackColor = System.Drawing.Color.DeepPink;
            this.showPWButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showPWButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPWButton.Location = new System.Drawing.Point(774, 15);
            this.showPWButton.Name = "showPWButton";
            this.showPWButton.Size = new System.Drawing.Size(106, 35);
            this.showPWButton.TabIndex = 5;
            this.showPWButton.Text = "Anzeigen";
            this.showPWButton.UseVisualStyleBackColor = false;
            this.showPWButton.Click += new System.EventHandler(this.showPWButton_Click);
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(516, 25);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(182, 25);
            this.listLabel.TabIndex = 3;
            this.listLabel.Text = "Liste der Mitarbeiter";
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "hi";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1330, 727);
            this.Controls.Add(this.Passwörter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Partner Employee";
            this.Passwörter.ResumeLayout(false);
            this.Mitarbeiter.ResumeLayout(false);
            this.Mitarbeiter.PerformLayout();
            this.Passwoerter.ResumeLayout(false);
            this.Passwoerter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Passwörter;
        private System.Windows.Forms.TabPage Mitarbeiter;
        private System.Windows.Forms.TabPage Passwoerter;
        private System.Windows.Forms.Label listEmployeeLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button getListButton;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button changePWButton;
        private System.Windows.Forms.Button createButtonPW;
        private System.Windows.Forms.Button initButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button confirmPWButton;
        private System.Windows.Forms.Button showPWButton;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label pWLabel;
        private System.Windows.Forms.TextBox passwordWdhBox;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button closePWButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button logoutPWButton;
        private System.Windows.Forms.ListView employeeListView;
        private System.Windows.Forms.ListView passwordListView;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox faxBox;
        private System.Windows.Forms.TextBox persNrBox;
        private System.Windows.Forms.TextBox functionBox;
        private System.Windows.Forms.TextBox plzBox;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label faxLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.Label persNrLabel;
        private System.Windows.Forms.ComboBox titleBox;
        private System.Windows.Forms.Label plzLabel;
        private System.Windows.Forms.Label adressCodeLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox adressCodeBox;
        private System.Windows.Forms.TextBox regionBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label infoLabel;
    }
}