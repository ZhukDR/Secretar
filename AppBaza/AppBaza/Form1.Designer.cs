namespace AppBaza
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxAuthorization = new System.Windows.Forms.GroupBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.buttonAuthorization = new System.Windows.Forms.Button();
            this.panelAuthorization = new System.Windows.Forms.Panel();
            this.panelSideBarTeacher = new System.Windows.Forms.Panel();
            this.buttonGrade = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.textBoxGroupName = new System.Windows.Forms.TextBox();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.buttonChangeGroup = new System.Windows.Forms.Button();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.labelStudentTelephone = new System.Windows.Forms.Label();
            this.labelStudentCity = new System.Windows.Forms.Label();
            this.labelStudentBirth_year = new System.Windows.Forms.Label();
            this.labelStudentGender = new System.Windows.Forms.Label();
            this.labelStudentFathername = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelStudentSurname = new System.Windows.Forms.Label();
            this.textBoxStudentTelephone = new System.Windows.Forms.TextBox();
            this.textBoxStudentCity = new System.Windows.Forms.TextBox();
            this.textBoxStudentBirth_year = new System.Windows.Forms.TextBox();
            this.textBoxStudentGender = new System.Windows.Forms.TextBox();
            this.textBoxStudentFathername = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.textBoxStudentSurname = new System.Windows.Forms.TextBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.buttonNewStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.panelGrade = new System.Windows.Forms.Panel();
            this.labelGrade = new System.Windows.Forms.Label();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.dataGridViewGrade = new System.Windows.Forms.DataGridView();
            this.buttonChangeGrade = new System.Windows.Forms.Button();
            this.groupBoxAuthorization.SuspendLayout();
            this.panelAuthorization.SuspendLayout();
            this.panelSideBarTeacher.SuspendLayout();
            this.panelGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.panelGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(61, 90);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(141, 22);
            this.textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(61, 149);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(141, 22);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAuthorizationPassword_KeyPress);
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthorization.Location = new System.Drawing.Point(39, 18);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(182, 38);
            this.labelAuthorization.TabIndex = 2;
            this.labelAuthorization.Text = "Авторизация";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(89, 56);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(77, 31);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(84, 115);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 31);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // groupBoxAuthorization
            // 
            this.groupBoxAuthorization.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBoxAuthorization.Controls.Add(this.buttonShowPassword);
            this.groupBoxAuthorization.Controls.Add(this.labelPassword);
            this.groupBoxAuthorization.Controls.Add(this.labelLogin);
            this.groupBoxAuthorization.Controls.Add(this.labelAuthorization);
            this.groupBoxAuthorization.Controls.Add(this.textBoxPassword);
            this.groupBoxAuthorization.Controls.Add(this.textBoxLogin);
            this.groupBoxAuthorization.Location = new System.Drawing.Point(263, 47);
            this.groupBoxAuthorization.Name = "groupBoxAuthorization";
            this.groupBoxAuthorization.Size = new System.Drawing.Size(254, 200);
            this.groupBoxAuthorization.TabIndex = 0;
            this.groupBoxAuthorization.TabStop = false;
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonShowPassword.FlatAppearance.BorderSize = 0;
            this.buttonShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPassword.Location = new System.Drawing.Point(45, 167);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(161, 27);
            this.buttonShowPassword.TabIndex = 5;
            this.buttonShowPassword.Text = "Показать пароль";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // buttonAuthorization
            // 
            this.buttonAuthorization.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAuthorization.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthorization.Location = new System.Drawing.Point(329, 253);
            this.buttonAuthorization.Name = "buttonAuthorization";
            this.buttonAuthorization.Size = new System.Drawing.Size(100, 46);
            this.buttonAuthorization.TabIndex = 6;
            this.buttonAuthorization.Text = "Вход";
            this.buttonAuthorization.UseVisualStyleBackColor = false;
            this.buttonAuthorization.Click += new System.EventHandler(this.buttonAuthorizationEnter_Click);
            // 
            // panelAuthorization
            // 
            this.panelAuthorization.Controls.Add(this.groupBoxAuthorization);
            this.panelAuthorization.Controls.Add(this.buttonAuthorization);
            this.panelAuthorization.Location = new System.Drawing.Point(0, 0);
            this.panelAuthorization.Name = "panelAuthorization";
            this.panelAuthorization.Size = new System.Drawing.Size(802, 452);
            this.panelAuthorization.TabIndex = 7;
            // 
            // panelSideBarTeacher
            // 
            this.panelSideBarTeacher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSideBarTeacher.Controls.Add(this.buttonGrade);
            this.panelSideBarTeacher.Controls.Add(this.buttonLogout);
            this.panelSideBarTeacher.Controls.Add(this.buttonStudent);
            this.panelSideBarTeacher.Controls.Add(this.buttonGroup);
            this.panelSideBarTeacher.Location = new System.Drawing.Point(0, 0);
            this.panelSideBarTeacher.Name = "panelSideBarTeacher";
            this.panelSideBarTeacher.Size = new System.Drawing.Size(235, 452);
            this.panelSideBarTeacher.TabIndex = 7;
            // 
            // buttonGrade
            // 
            this.buttonGrade.FlatAppearance.BorderSize = 0;
            this.buttonGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrade.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGrade.Location = new System.Drawing.Point(44, 192);
            this.buttonGrade.Name = "buttonGrade";
            this.buttonGrade.Size = new System.Drawing.Size(113, 64);
            this.buttonGrade.TabIndex = 3;
            this.buttonGrade.Text = "Oценки";
            this.buttonGrade.UseVisualStyleBackColor = true;
            this.buttonGrade.Click += new System.EventHandler(this.buttonGrade_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogout.Location = new System.Drawing.Point(12, 361);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(183, 77);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Выход из аккаунта";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.FlatAppearance.BorderSize = 0;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.buttonStudent.Location = new System.Drawing.Point(34, 103);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(133, 81);
            this.buttonStudent.TabIndex = 1;
            this.buttonStudent.Text = "Ученики";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonGroup
            // 
            this.buttonGroup.FlatAppearance.BorderSize = 0;
            this.buttonGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroup.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.buttonGroup.Location = new System.Drawing.Point(44, 31);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(113, 51);
            this.buttonGroup.TabIndex = 0;
            this.buttonGroup.Text = "Группы";
            this.buttonGroup.UseVisualStyleBackColor = true;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // panelTeacher
            // 
            this.panelTeacher.Location = new System.Drawing.Point(0, 0);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(567, 453);
            this.panelTeacher.TabIndex = 8;
            // 
            // panelGroup
            // 
            this.panelGroup.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelGroup.Controls.Add(this.labelGroupName);
            this.panelGroup.Controls.Add(this.textBoxGroupName);
            this.panelGroup.Controls.Add(this.dataGridViewGroup);
            this.panelGroup.Controls.Add(this.buttonChangeGroup);
            this.panelGroup.Controls.Add(this.buttonDeleteGroup);
            this.panelGroup.Location = new System.Drawing.Point(0, 0);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(797, 453);
            this.panelGroup.TabIndex = 0;
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroupName.Location = new System.Drawing.Point(573, 323);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(49, 17);
            this.labelGroupName.TabIndex = 4;
            this.labelGroupName.Text = "Группа";
            // 
            // textBoxGroupName
            // 
            this.textBoxGroupName.Location = new System.Drawing.Point(553, 342);
            this.textBoxGroupName.Name = "textBoxGroupName";
            this.textBoxGroupName.Size = new System.Drawing.Size(100, 22);
            this.textBoxGroupName.TabIndex = 3;
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Location = new System.Drawing.Point(261, 31);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.RowHeadersWidth = 51;
            this.dataGridViewGroup.RowTemplate.Height = 24;
            this.dataGridViewGroup.Size = new System.Drawing.Size(491, 286);
            this.dataGridViewGroup.TabIndex = 0;
            // 
            // buttonChangeGroup
            // 
            this.buttonChangeGroup.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeGroup.Location = new System.Drawing.Point(669, 338);
            this.buttonChangeGroup.Name = "buttonChangeGroup";
            this.buttonChangeGroup.Size = new System.Drawing.Size(83, 31);
            this.buttonChangeGroup.TabIndex = 1;
            this.buttonChangeGroup.Text = "Изменить";
            this.buttonChangeGroup.UseVisualStyleBackColor = true;
            this.buttonChangeGroup.Click += new System.EventHandler(this.buttonChangeGroup_Click);
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteGroup.Location = new System.Drawing.Point(669, 381);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(83, 31);
            this.buttonDeleteGroup.TabIndex = 2;
            this.buttonDeleteGroup.Text = "Удалить";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelStudent.Controls.Add(this.labelStudentTelephone);
            this.panelStudent.Controls.Add(this.labelStudentCity);
            this.panelStudent.Controls.Add(this.labelStudentBirth_year);
            this.panelStudent.Controls.Add(this.labelStudentGender);
            this.panelStudent.Controls.Add(this.labelStudentFathername);
            this.panelStudent.Controls.Add(this.labelStudentName);
            this.panelStudent.Controls.Add(this.labelStudentSurname);
            this.panelStudent.Controls.Add(this.textBoxStudentTelephone);
            this.panelStudent.Controls.Add(this.textBoxStudentCity);
            this.panelStudent.Controls.Add(this.textBoxStudentBirth_year);
            this.panelStudent.Controls.Add(this.textBoxStudentGender);
            this.panelStudent.Controls.Add(this.textBoxStudentFathername);
            this.panelStudent.Controls.Add(this.textBoxStudentName);
            this.panelStudent.Controls.Add(this.textBoxStudentSurname);
            this.panelStudent.Controls.Add(this.dataGridViewStudent);
            this.panelStudent.Controls.Add(this.buttonNewStudent);
            this.panelStudent.Controls.Add(this.buttonDeleteStudent);
            this.panelStudent.Location = new System.Drawing.Point(0, 0);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(797, 453);
            this.panelStudent.TabIndex = 8;
            // 
            // labelStudentTelephone
            // 
            this.labelStudentTelephone.AutoSize = true;
            this.labelStudentTelephone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentTelephone.Location = new System.Drawing.Point(599, 371);
            this.labelStudentTelephone.Name = "labelStudentTelephone";
            this.labelStudentTelephone.Size = new System.Drawing.Size(60, 17);
            this.labelStudentTelephone.TabIndex = 18;
            this.labelStudentTelephone.Text = "Телефон";
            // 
            // labelStudentCity
            // 
            this.labelStudentCity.AutoSize = true;
            this.labelStudentCity.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.labelStudentCity.Location = new System.Drawing.Point(498, 371);
            this.labelStudentCity.Name = "labelStudentCity";
            this.labelStudentCity.Size = new System.Drawing.Size(45, 17);
            this.labelStudentCity.TabIndex = 17;
            this.labelStudentCity.Text = "Город";
            // 
            // labelStudentBirth_year
            // 
            this.labelStudentBirth_year.AutoSize = true;
            this.labelStudentBirth_year.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.labelStudentBirth_year.Location = new System.Drawing.Point(372, 371);
            this.labelStudentBirth_year.Name = "labelStudentBirth_year";
            this.labelStudentBirth_year.Size = new System.Drawing.Size(93, 17);
            this.labelStudentBirth_year.TabIndex = 16;
            this.labelStudentBirth_year.Text = "Год рождения";
            // 
            // labelStudentGender
            // 
            this.labelStudentGender.AutoSize = true;
            this.labelStudentGender.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.labelStudentGender.Location = new System.Drawing.Point(294, 371);
            this.labelStudentGender.Name = "labelStudentGender";
            this.labelStudentGender.Size = new System.Drawing.Size(32, 17);
            this.labelStudentGender.TabIndex = 15;
            this.labelStudentGender.Text = "Пол";
            // 
            // labelStudentFathername
            // 
            this.labelStudentFathername.AutoSize = true;
            this.labelStudentFathername.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.labelStudentFathername.Location = new System.Drawing.Point(494, 323);
            this.labelStudentFathername.Name = "labelStudentFathername";
            this.labelStudentFathername.Size = new System.Drawing.Size(63, 17);
            this.labelStudentFathername.TabIndex = 13;
            this.labelStudentFathername.Text = "Отчество";
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.labelStudentName.Location = new System.Drawing.Point(406, 323);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(34, 17);
            this.labelStudentName.TabIndex = 12;
            this.labelStudentName.Text = "Имя";
            // 
            // labelStudentSurname
            // 
            this.labelStudentSurname.AutoSize = true;
            this.labelStudentSurname.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.labelStudentSurname.Location = new System.Drawing.Point(284, 323);
            this.labelStudentSurname.Name = "labelStudentSurname";
            this.labelStudentSurname.Size = new System.Drawing.Size(61, 17);
            this.labelStudentSurname.TabIndex = 11;
            this.labelStudentSurname.Text = "Фамилия";
            // 
            // textBoxStudentTelephone
            // 
            this.textBoxStudentTelephone.Location = new System.Drawing.Point(581, 390);
            this.textBoxStudentTelephone.Name = "textBoxStudentTelephone";
            this.textBoxStudentTelephone.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentTelephone.TabIndex = 10;
            // 
            // textBoxStudentCity
            // 
            this.textBoxStudentCity.Location = new System.Drawing.Point(475, 390);
            this.textBoxStudentCity.Name = "textBoxStudentCity";
            this.textBoxStudentCity.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentCity.TabIndex = 9;
            // 
            // textBoxStudentBirth_year
            // 
            this.textBoxStudentBirth_year.Location = new System.Drawing.Point(369, 390);
            this.textBoxStudentBirth_year.Name = "textBoxStudentBirth_year";
            this.textBoxStudentBirth_year.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentBirth_year.TabIndex = 8;
            // 
            // textBoxStudentGender
            // 
            this.textBoxStudentGender.Location = new System.Drawing.Point(261, 390);
            this.textBoxStudentGender.Name = "textBoxStudentGender";
            this.textBoxStudentGender.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentGender.TabIndex = 7;
            // 
            // textBoxStudentFathername
            // 
            this.textBoxStudentFathername.Location = new System.Drawing.Point(475, 342);
            this.textBoxStudentFathername.Name = "textBoxStudentFathername";
            this.textBoxStudentFathername.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentFathername.TabIndex = 5;
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(369, 342);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentName.TabIndex = 4;
            // 
            // textBoxStudentSurname
            // 
            this.textBoxStudentSurname.Location = new System.Drawing.Point(261, 342);
            this.textBoxStudentSurname.Name = "textBoxStudentSurname";
            this.textBoxStudentSurname.Size = new System.Drawing.Size(100, 22);
            this.textBoxStudentSurname.TabIndex = 3;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(261, 31);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(491, 286);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // buttonNewStudent
            // 
            this.buttonNewStudent.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.buttonNewStudent.Location = new System.Drawing.Point(705, 333);
            this.buttonNewStudent.Name = "buttonNewStudent";
            this.buttonNewStudent.Size = new System.Drawing.Size(83, 31);
            this.buttonNewStudent.TabIndex = 1;
            this.buttonNewStudent.Text = "Добавить";
            this.buttonNewStudent.UseVisualStyleBackColor = true;
            this.buttonNewStudent.Click += new System.EventHandler(this.buttonNewStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.buttonDeleteStudent.Location = new System.Drawing.Point(705, 386);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(83, 31);
            this.buttonDeleteStudent.TabIndex = 2;
            this.buttonDeleteStudent.Text = "Удалить";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // panelGrade
            // 
            this.panelGrade.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelGrade.Controls.Add(this.labelGrade);
            this.panelGrade.Controls.Add(this.textBoxGrade);
            this.panelGrade.Controls.Add(this.dataGridViewGrade);
            this.panelGrade.Controls.Add(this.buttonChangeGrade);
            this.panelGrade.Location = new System.Drawing.Point(0, 0);
            this.panelGrade.Name = "panelGrade";
            this.panelGrade.Size = new System.Drawing.Size(797, 453);
            this.panelGrade.TabIndex = 9;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGrade.Location = new System.Drawing.Point(324, 324);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(52, 17);
            this.labelGrade.TabIndex = 3;
            this.labelGrade.Text = "Оценка";
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(307, 346);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(96, 22);
            this.textBoxGrade.TabIndex = 2;
            // 
            // dataGridViewGrade
            // 
            this.dataGridViewGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrade.Location = new System.Drawing.Point(261, 31);
            this.dataGridViewGrade.Name = "dataGridViewGrade";
            this.dataGridViewGrade.RowHeadersWidth = 51;
            this.dataGridViewGrade.RowTemplate.Height = 24;
            this.dataGridViewGrade.Size = new System.Drawing.Size(491, 286);
            this.dataGridViewGrade.TabIndex = 0;
            // 
            // buttonChangeGrade
            // 
            this.buttonChangeGrade.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeGrade.Location = new System.Drawing.Point(409, 342);
            this.buttonChangeGrade.Name = "buttonChangeGrade";
            this.buttonChangeGrade.Size = new System.Drawing.Size(83, 31);
            this.buttonChangeGrade.TabIndex = 1;
            this.buttonChangeGrade.Text = "Изменить";
            this.buttonChangeGrade.UseVisualStyleBackColor = true;
            this.buttonChangeGrade.Click += new System.EventHandler(this.buttonChangeGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAuthorization);
            this.Controls.Add(this.panelSideBarTeacher);
            this.Controls.Add(this.panelGrade);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panelTeacher);
            this.Name = "Form1";
            this.Text = "АИС Секретарь";
            this.groupBoxAuthorization.ResumeLayout(false);
            this.groupBoxAuthorization.PerformLayout();
            this.panelAuthorization.ResumeLayout(false);
            this.panelSideBarTeacher.ResumeLayout(false);
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.panelGrade.ResumeLayout(false);
            this.panelGrade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.GroupBox groupBoxAuthorization;
        private System.Windows.Forms.Button buttonAuthorization;
        private System.Windows.Forms.Panel panelAuthorization;
        private System.Windows.Forms.Panel panelSideBarTeacher;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonChangeGroup;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Button buttonNewStudent;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonGrade;
        private System.Windows.Forms.Panel panelGrade;
        private System.Windows.Forms.DataGridView dataGridViewGrade;
        private System.Windows.Forms.Button buttonChangeGrade;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Label labelStudentTelephone;
        private System.Windows.Forms.Label labelStudentCity;
        private System.Windows.Forms.Label labelStudentBirth_year;
        private System.Windows.Forms.Label labelStudentGender;
        private System.Windows.Forms.Label labelStudentFathername;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelStudentSurname;
        private System.Windows.Forms.TextBox textBoxStudentTelephone;
        private System.Windows.Forms.TextBox textBoxStudentCity;
        private System.Windows.Forms.TextBox textBoxStudentBirth_year;
        private System.Windows.Forms.TextBox textBoxStudentGender;
        private System.Windows.Forms.TextBox textBoxStudentFathername;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.TextBox textBoxStudentSurname;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.TextBox textBoxGroupName;
        private System.Windows.Forms.Label labelGrade;
    }
}

