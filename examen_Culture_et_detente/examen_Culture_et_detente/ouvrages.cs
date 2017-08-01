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


namespace examen_Culture_et_detente
{
    public partial class ouvrages : Form
    {
        private string authorSelected;
        private string titleSelected;
        public ouvrages()
        {
            InitializeComponent();
            MySqlConnection connection;
            string connectionString;
            connectionString = "SERVER=127.0.0.1;DATABASE=culture_et_detente;UID=root;PASSWORD=";
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                MessageBox.Show("connexion à la base de données réussie");
                MySqlCommand mysql = connection.CreateCommand();
                mysql.CommandText = "SELECT * from ouvrage_auteurs ORDER BY Cote_Ouvrage";
                MySqlDataAdapter sda = new MySqlDataAdapter(mysql);
                DataTable table = new DataTable();
                sda.Fill(table); 
                dataGridViewOuvrage.DataSource = table;

                MySqlCommand authors = connection.CreateCommand();
                authors.CommandText = "SELECT `Nom_Auteur` FROM `ouvrage_auteurs` GROUP BY Nom_Auteur";
                MySqlDataAdapter Author = new MySqlDataAdapter(authors);
                DataTable AuthorsTable = new DataTable();
                Author.Fill(AuthorsTable);
                comboBoxAuthor.DataSource = AuthorsTable;                
                comboBoxAuthor.DisplayMember = "Nom_Auteur";
                comboBoxAuthor.SelectedIndex = -1;               

                MySqlCommand Title = connection.CreateCommand();
                Title.CommandText = "SELECT `Titre_Ouvrage` FROM `ouvrage_auteurs`";
                MySqlDataAdapter Titles = new MySqlDataAdapter(Title);
                DataTable TitlesTable = new DataTable();
                Titles.Fill(TitlesTable);
                comboBoxTitle.DataSource = TitlesTable;
                comboBoxTitle.DisplayMember = "Titre_Ouvrage";
                comboBoxTitle.SelectedIndex = -1;

                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de connection :" + "\r\n" + ex.Message);
            }

        }

        private void comboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleSelected = comboBoxTitle.Text;
        }

        private void buttonTestEmail_Click(object sender, EventArgs e)
        {
            FormeEmail fenetre = new FormeEmail();
            fenetre.Show();
        }

        private void buttonValidChoice_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionSelect;
            string connectionString;
            connectionString = "SERVER=127.0.0.1;DATABASE=culture_et_detente;UID=root;PASSWORD=";
            if (comboBoxAuthor.SelectedIndex == -1)
                if (comboBoxTitle.SelectedIndex!= -1)
                    try
                    {
                        connectionSelect = new MySqlConnection();
                        connectionSelect.ConnectionString = connectionString;
                        connectionSelect.Open();
                        MySqlCommand mysql = connectionSelect.CreateCommand();
                        mysql.CommandText = "SELECT * from ouvrage_auteurs Where Titre_Ouvrage = '" + titleSelected + "'";
                        MySqlDataAdapter sda = new MySqlDataAdapter(mysql);
                        DataTable table = new DataTable();
                        sda.Fill(table);
                        dataGridViewOuvrage.DataSource = table;

                        connectionSelect.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur de connection :" + "\r\n" + ex.Message);
                    }
                else
                    try
                    {
                        connectionSelect = new MySqlConnection();
                        connectionSelect.ConnectionString = connectionString;
                        connectionSelect.Open();
                        MySqlCommand mysql = connectionSelect.CreateCommand();
                        mysql.CommandText = "SELECT * from ouvrage_auteurs ORDER BY Titre_Ouvrage ";
                        MySqlDataAdapter sda = new MySqlDataAdapter(mysql);
                        DataTable table = new DataTable();
                        sda.Fill(table);
                        dataGridViewOuvrage.DataSource = table;

                        connectionSelect.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erreur de connection :" + "\r\n" + ex.Message);
                    }
            else
                try
                {
                    connectionSelect = new MySqlConnection();
                    connectionSelect.ConnectionString = connectionString;
                    connectionSelect.Open();
                    MySqlCommand mysql = connectionSelect.CreateCommand();
                    mysql.CommandText = "SELECT * from ouvrage_auteurs Where Nom_Auteur = '" + authorSelected + "' ORDER BY Titre_Ouvrage";
                    MySqlDataAdapter sda = new MySqlDataAdapter(mysql);
                    DataTable table = new DataTable();
                    sda.Fill(table);
                    dataGridViewOuvrage.DataSource = table;

                    connectionSelect.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur de connection :" + "\r\n" + ex.Message);
                }
        }
        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            authorSelected = comboBoxAuthor.Text;
        }
    }
}
