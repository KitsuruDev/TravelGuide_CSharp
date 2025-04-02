using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;

namespace TravelGuide
{
    public partial class FormEdit : Form
    {
        private NpgsqlCommand command = new NpgsqlCommand();
        private DataTable dt = new DataTable();
        private ImageConverter imageConverter = new ImageConverter();
        private NpgsqlParameter pictureBytea = null;
        private string choice_city;
        private int row_id;
        private bool img_1_change = false;
        private bool img_2_change = false;

        public FormEdit(NpgsqlConnection connection)
        {
            InitializeComponent();

            command.Connection = connection;
            pictureBytea = command.CreateParameter();
            pictureBytea.NpgsqlDbType = NpgsqlDbType.Bytea;   
        }

        public FormEdit(NpgsqlConnection connection, string choice_city)
        {
            InitializeComponent();

            command.Connection = connection;
            pictureBytea = command.CreateParameter();
            pictureBytea.NpgsqlDbType = NpgsqlDbType.Bytea;
            this.choice_city = choice_city;
        }

        private static byte[] ImageToBytea(Image image)
        {
            byte[] convert_image;
            MemoryStream memory = new MemoryStream();

            image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);
            convert_image = memory.ToArray();
            memory.Close();

            return convert_image;
        }

        private void MessageWarning(string label, string text)
        {
            MessageBox.Show(text, label, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            if (this.Text == "Редактирование записи о городе")
            {
                command.CommandText = $"select * from cities where name = \'{choice_city}\'";
                NpgsqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

                TextBoxEditName.Text = choice_city;
                TextBoxEditDescription.Text = dt.Rows[0]["Description"].ToString();
                if (!Convert.IsDBNull(dt.Rows[0]["img_1"]))
                {
                    PictureBox1.Image = imageConverter.ConvertFrom(dt.Rows[0]["img_1"]) as Image;
                    ButtonEditPictureDelete1.Enabled = true;
                }
                if (!Convert.IsDBNull(dt.Rows[0]["img_2"]))
                {
                    PictureBox2.Image = imageConverter.ConvertFrom(dt.Rows[0]["img_2"]) as Image;
                    ButtonEditPictureDelete2.Enabled = true;
                }
                row_id = Convert.ToInt32(dt.Rows[0]["id"]);

                ButtonEditAccept.Text = "Изменить";

                dt.Rows.Clear();
                reader.Close();
                reader.Dispose();
            }
            else
                ButtonEditAccept.Text = "Добавить";
        }

        private void ButtonEditPicture1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Выберите изображение...";
            dlg.Filter = "Изображения(*.png)|*.png|Изображения(*.jpg)|*.jpg";
            dlg.FilterIndex = 1;

            dlg.ShowDialog();

            if (File.Exists(dlg.FileName))
            {
                PictureBox1.Image = Image.FromFile(dlg.FileName);
                ButtonEditPictureDelete1.Enabled = true;
                if (img_1_change == false)
                    img_1_change = true;
            }

            dlg.Dispose();
        }

        private void ButtonEditPicture2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Выберите изображение...";
            dlg.Filter = "Изображения(*.png)|*.png|Изображения(*.jpg)|*.jpg";
            dlg.FilterIndex = 1;

            dlg.ShowDialog();

            if (File.Exists(dlg.FileName))
            {
                PictureBox2.Image = Image.FromFile(dlg.FileName);
                ButtonEditPictureDelete2.Enabled = true;
                if (img_2_change == false)
                    img_2_change = true;
            }

            dlg.Dispose();
        }

        private void ButtonEditPictureDelete1_Click(object sender, EventArgs e)
        {
            PictureBox1.Image = null;
            ButtonEditPictureDelete1.Enabled = false;
        }

        private void ButtonEditPictureDelete2_Click(object sender, EventArgs e)
        {
            PictureBox2.Image = null;
            ButtonEditPictureDelete2.Enabled = false;
        }

        private void ButtonEditAccept_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxEditName.Text) && !string.IsNullOrEmpty(TextBoxEditDescription.Text))
            {
                string raw_name_city = TextBoxEditName.Text.Trim();

                if (raw_name_city.Length > 1)
                {
                    string[] raw_name_city_mass = raw_name_city.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string name_city = string.Join(" ", raw_name_city_mass.Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));

                    if (this.Text == "Редактирование записи о городе")
                        command.CommandText = $"select count(name) from cities where name = \'{name_city}\' and id <> {row_id} limit 1";
                    else
                        command.CommandText = $"select count(name) from cities where name = \'{name_city}\' limit 1";
                    if (Convert.ToInt32(command.ExecuteScalar()) == 0)
                    {
                        if (this.Text == "Редактирование записи о городе")
                        {
                            command.CommandText = $"update cities set name = \'{name_city}\', " +
                                $"description = \'{TextBoxEditDescription.Text}\'";

                            if (img_1_change == true)
                            {
                                if (PictureBox1.Image != null)
                                {
                                    command.CommandText += $", img_1 = :img1";
                                    pictureBytea.ParameterName = ":img1";
                                    pictureBytea.Value = ImageToBytea(PictureBox1.Image);
                                    command.Parameters.Add(pictureBytea);
                                }
                                else
                                    command.CommandText += $", img_1 = null";
                            }
                            if (img_2_change == true)
                            {
                                if (PictureBox2.Image != null)
                                {
                                    command.CommandText += $", img_2 = :img2";
                                    pictureBytea.ParameterName = ":img2";
                                    pictureBytea.Value = ImageToBytea(PictureBox2.Image);
                                    command.Parameters.Add(pictureBytea);
                                }
                                else
                                    command.CommandText += $", img_2 = null";
                            }

                            command.CommandText += $" where id = \'{row_id}\'";

                            command.ExecuteNonQuery();
                            Close();
                        }
                        else
                        {
                            command.CommandText = $"insert into cities values (\'{name_city}\', " +
                                $"\'{TextBoxEditDescription.Text}\'";

                            if (PictureBox1.Image != null)
                            {
                                command.CommandText += $", :img1";
                                pictureBytea.ParameterName = ":img1";
                                pictureBytea.Value = ImageToBytea(PictureBox1.Image);
                                command.Parameters.Add(pictureBytea);
                            }
                            else
                                command.CommandText += ", null";

                            if (PictureBox2.Image != null)
                            {
                                command.CommandText += $", :img2";
                                pictureBytea.ParameterName = ":img2";
                                pictureBytea.Value = ImageToBytea(PictureBox2.Image);
                                command.Parameters.Add(pictureBytea);
                            }
                            else
                                command.CommandText += ", null";

                            command.CommandText += ")";

                            command.ExecuteNonQuery();
                            Close();
                        }
                    }
                    else
                        MessageWarning("Существующая запись", "Запись о городе с таким названием уже внесена в список!");
                }
                else
                    MessageWarning("Название из одного символа", "Название города не может состоять из одной буквы!");
            }
            else
                MessageWarning("Пустые значения", "Заполните обязательные поля \"Название\" и \"Описание\"!");
        }

        private void FormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            command.Dispose();
            dt.Dispose();
        }
    }
}
