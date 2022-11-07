using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsForms_orszagok
{
    public partial class Form_Országok : Form
    {
        public Form_Országok()
        {
            InitializeComponent();
        }

        private void Form_Országok_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "orszagok";
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT `id`,`orszag`,`fovaros`,`terulet`,`allamforma`,`nepesseg` FROM `orszagok`";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        orszag orszag = new orszag(dr.GetInt32("id"), dr.GetString("orszag"), dr.GetString("fovaros"), dr.GetDouble("terulet"), dr.GetDouble("nepesseg"), dr.GetString("allamforma"));
                        listBox_Orszagok.Items.Add(orszag);
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
        }

        private void listBox_Orszagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Orszagok.SelectedIndex < 0)
            {
                return;
            }
            orszag kivalasztottorszag = (orszag) listBox_Orszagok.SelectedItem;
            textBox1_id.Text = kivalasztottorszag.Id.ToString();
            textBox1_orszagneve.Text = kivalasztottorszag.OrszagNev;
            textBox2_fovaros.Text = kivalasztottorszag.Fovaros;
            textBox3_terulet.Text = kivalasztottorszag.Terulet.ToString("#,##0");
            textBox4_nepesseg.Text = kivalasztottorszag.Nepesseg.ToString("#,##0");
            textBox5_allamforma.Text = kivalasztottorszag.Allamforma;
        }
    }
}
