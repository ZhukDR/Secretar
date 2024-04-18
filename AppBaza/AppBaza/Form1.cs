using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void hide_all_windows()
        {
            panelAuthorization.Visible = false;
            panelTeacher.Visible = false;
            panelSideBarTeacher.Visible = false;
            panelGrade.Visible = false;
            panelGroup.Visible = false;
            panelStudent.Visible = false;
        }

        private void buttonAuthorizationEnter_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM authorization WHERE `Login` = @login and `Password` = @password", conn);
            conn.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            cmd.Parameters.AddWithValue("login", textBoxLogin.Text);
            cmd.Parameters.AddWithValue("password", textBoxPassword.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                hide_all_windows();
                string welcomemsg;
                using (MySqlCommand fetchNames = new MySqlCommand("SELECT * FROM teacher WHERE `ID_teacher`=" + Convert.ToString(table.Rows[0].ItemArray[0])))
                {
                    fetchNames.Connection = conn;
                    fetchNames.CommandType = CommandType.Text;
                    using (DataTable tableNames = new DataTable())
                    {
                        using (MySqlDataAdapter sdaNames = new MySqlDataAdapter(fetchNames))
                        {
                            sdaNames.Fill(tableNames);
                            welcomemsg = "Добро пожаловать, " + Convert.ToString(tableNames.Rows[0].ItemArray[2]) + " " + Convert.ToString(tableNames.Rows[0].ItemArray[3]);
                        }
                    }
                }
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                MessageBox.Show(welcomemsg, "Приветствие", MessageBoxButtons.OK);
                panelSideBarTeacher.Visible = true; panelTeacher.Visible = true; panelSideBarTeacher.BringToFront();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                hide_all_windows();
                panelAuthorization.Visible = true;
                panelAuthorization.BringToFront();
            }
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
        private void textBoxAuthorizationPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && panelAuthorization.Visible == true)
            {
                buttonAuthorization.PerformClick();
            }
        }
        private void buttonGrade_Click(object sender, EventArgs e) //Кнопка действия на вывод базы данных оценок и их панелей
        {
            hide_all_windows();
            panelGrade.Visible = true;
            panelSideBarTeacher.Visible = true;
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT student.ID_student,theme.ID_theme,student.name,student.Surname,student.Fathername, theme.Theme, evaluation.Grade FROM student INNER JOIN evaluation ON student.ID_student = evaluation.ID_student INNER JOIN theme on evaluation.ID_theme = theme.ID_theme", conn);
            conn.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dataGridViewGrade.DataSource = table;
            dataGridViewGrade.Columns[0].Visible = false;
            dataGridViewGrade.Columns[1].Visible = false;
        }
        private void buttonStudent_Click(object sender, EventArgs e)//Кнопка действия на вывод бызы данных студентов и их панелей
        {
            hide_all_windows();
            panelSideBarTeacher.Visible = true;
            panelStudent.Visible = true;
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM student LEFT OUTER JOIN theme ON student.ID_student = theme.ID_theme UNION SELECT * FROM student RIGHT OUTER JOIN theme ON student.ID_student = theme.ID_theme\r\n", conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dataGridViewStudent.DataSource = table;
        }
        private void buttonGroup_Click(object sender, EventArgs e)//Кнопка действия на вывод бызы данных групп и их панелей
        {
            hide_all_windows();
            panelSideBarTeacher.Visible = true;
            panelGroup.Visible = true;
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT student.name, student.Surname,student.Fathername,group.Group FROM student INNER JOIN `group` ON student.ID_group = group.ID_group", conn);
            conn.Open();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            dataGridViewGroup.DataSource = table;
            dataGridViewGroup.Columns[0].Visible = false;
        }
        private void buttonChangeGrade_Click(object sender, EventArgs e)//Кнопка при помощи которой можно изменить оценку
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить выбранную оценку?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE evaluation SET Grade=@grade WHERE ID_student=@studentID AND ID_theme=@id", conn);
                cmd.Parameters.AddWithValue("grade", textBoxGrade.Text);
                cmd.Parameters.AddWithValue("studentID", Convert.ToString(dataGridViewGrade.CurrentRow.Cells[0].Value));
                cmd.Parameters.AddWithValue("ID", Convert.ToString(dataGridViewGrade.CurrentRow.Cells[1].Value));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonGrade.PerformClick();
            }
        }

        private void buttonNewStudent_Click(object sender, EventArgs e)//Кнопка при помощи которой можно добавить студента
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите добавить нового студента используя введенные данные?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO student (surname,name,fathername,gender,birth_year,city,telephone) VALUES (@surname,@name,@fathername,@gender,@birth_year,@city,@telephone)", conn);
                cmd.Parameters.AddWithValue("surname", textBoxStudentSurname.Text);
                cmd.Parameters.AddWithValue("name", textBoxStudentName.Text);
                cmd.Parameters.AddWithValue("fathername", textBoxStudentFathername.Text);
                cmd.Parameters.AddWithValue("gender", textBoxStudentGender.Text);
                cmd.Parameters.AddWithValue("birth_year", textBoxStudentBirth_year.Text);
                cmd.Parameters.AddWithValue("city", textBoxStudentCity.Text);
                cmd.Parameters.AddWithValue("telephone", textBoxStudentTelephone.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonStudent.PerformClick();
            }
        }
        private void buttonDeleteStudent_Click(object sender, EventArgs e)// Кнопка при помощи которой можно удалить студента
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранного студента", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM student WHERE ID_student = @id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewStudent.CurrentRow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                buttonStudent.PerformClick();
            }
        }
        private void buttonChangeGroup_Click(object sender, EventArgs e)//Кнопка при помощи которой можно поменять группу
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить группу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE `group` SET `Group` = @group WHERE ID_group = @id", conn);
                cmd.Parameters.AddWithValue("group", textBoxGroupName.Text);
                cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewGroup.CurrentRow.Cells[0].Value));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                buttonGroup.PerformClick();
            }
        }
        private void buttonDeleteGroup_Click(object sender, EventArgs e)//Кнопка при помощи которой можно удалить группу
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить выбранную группу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM group WHERE ID_group = @id", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("id", Convert.ToString(dataGridViewGroup.CurrentRow.Cells[0].Value));
            cmd.ExecuteNonQuery();
            buttonGroup.PerformClick();
            }
        }
    }
}
