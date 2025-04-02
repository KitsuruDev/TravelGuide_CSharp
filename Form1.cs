using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace TravelGuide
{
    public partial class FormMain : Form
    {
        private NpgsqlConnection connection = new NpgsqlConnection("Server = Server; Port = Port; Database = Database; User ID = User; Password = Password");
        private NpgsqlCommand command = new NpgsqlCommand();
        private DataTable dt = new DataTable();
        private ImageConverter imageConverter = new ImageConverter();

        public FormMain()
        {
            InitializeComponent();

            command.CommandType = CommandType.Text;
        }

        private void MenuItemCitiesConnect_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                command.Connection = connection;

                TableAllRows();

                LabelMainWelcome.Visible = false;
                LabelMain.Visible = true;
                TextBox.Visible = true;
                PictureBox1.Visible = true;
                PictureBox2.Visible = true;
                MenuItemEdit.Enabled = true;
                MenuItemCitiesConnect.Enabled = false;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItem != null) // при нажатии на пустую область
            {
                MenuItemEditModify.Enabled = true;
                MenuItemEditDelete.Enabled = true;

                TableOneRow();
            }
            else
            {
                MenuItemEditModify.Enabled = false;
                MenuItemEditDelete.Enabled = false;
            }
        }

        private void MenuItemEditModify_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedItem != null) // при нажатии на пустую область
            {
                int index = ListBox.SelectedIndex;
                FormEdit form_editing = new FormEdit(connection, ListBox.SelectedItem.ToString());
                form_editing.Text = "Редактирование записи о городе";
                form_editing.ShowDialog();
                form_editing.Dispose();

                TableOneRow();
            }
        }

        private void MenuItemEditDelete_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedItem != null) // при нажатии на пустую область
            {
                if (MessageBox.Show($"Вы уверены, что хотите удалить запись \"{ListBox.SelectedItem}\"?",
                        "Удаление записи о городе",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LabelMain.Text = "Выберите город";
                    TextBox.Text = "";
                    PictureBox1.Image = null;
                    PictureBox2.Image = null;
                    MenuItemEditModify.Enabled = false;
                    MenuItemEditDelete.Enabled = false;

                    command.CommandText = $"delete from cities where name = \'{ListBox.SelectedItem}\'";
                    command.ExecuteNonQuery();

                    TableAllRows();
                }
                
            }
        }

        private void MenuItemEditAdd_Click(object sender, EventArgs e)
        {
            FormEdit form_editing = new FormEdit(connection);
            form_editing.Text = "Добавление записи о городе";
            form_editing.ShowDialog();
            form_editing.Dispose();

            TableAllRows();
        }

        private void MenuItemProgramAbout_Click(object sender, EventArgs e)
        {
            FormAbout form_about = new FormAbout();
            form_about.ShowDialog();
            form_about.Dispose();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();

            connection.Dispose();
            command.Dispose();
            dt.Dispose();
        }

        private void TableOneRow()
        {
            command.CommandText = $"select * from cities where name = \'{ListBox.SelectedItem}\'";
            NpgsqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);

            LabelMain.Text = ListBox.SelectedItem.ToString();
            TextBox.Text = dt.Rows[0]["Description"].ToString();

            if (!Convert.IsDBNull(dt.Rows[0]["img_1"]))
                PictureBox1.Image = imageConverter.ConvertFrom(dt.Rows[0]["img_1"]) as Image;
            else
                PictureBox1.Image = null;

            if (!Convert.IsDBNull(dt.Rows[0]["img_2"]))
                PictureBox2.Image = imageConverter.ConvertFrom(dt.Rows[0]["img_2"]) as Image;
            else
                PictureBox2.Image = null;

            dt.Rows.Clear();
            reader.Close();
            reader.Dispose();
        }

        private void TableAllRows()
        {
            command.CommandText = "select * from cities";
            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                ListBox.Items.Clear();
                
                dt.Load(reader);

                foreach (DataRow row in dt.Rows)
                    ListBox.Items.Add(row["name"].ToString());

                dt.Rows.Clear();
            }
            else
                MessageBox.Show("В данный момент в таблице нет городов!\nНо вы можете внести их самостоятельно.",
                    "Пустая таблица",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            reader.Close();
            reader.Dispose();
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
                MenuItemProgramAbout_Click(null, null);
        }
    }
}
