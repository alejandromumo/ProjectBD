using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ProjetoBD
{
    public partial class Form1 : Form
    {
        List<Jogador> player = new List<Jogador>();
        List<Club> club = new List<Club>();
        List<Report> reports = new List<Report>();
        DataAccess db;

        public Form1()
        {
            InitializeComponent();
            this.db = new DataAccess();
            updateBinding(Lista_Jogadores_Encontrados , this.player, "FullInfo");
            updateBinding(Lista_Observações, this.reports, "FullInfo");
            updateBinding(Lista_Clubes_Encontrados, this.club, "FullInfo");
        }

        private void updateBinding<T>(ListBox listBox, List<T> list, string info)
        {
            listBox.DataSource = list;
            listBox.DisplayMember = info;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.player = db.getPlayerByName(PlayerNameTB.Text);

            updateBinding(Lista_Jogadores_Encontrados, this.player, "FullInfo");
        }

        private void getReportsButton_Click(object sender, EventArgs e)
        {
            this.reports = db.getReports();
            updateBinding(Lista_Observações, this.reports, "FullInfo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            using (var reader = new StreamReader(InsertFromTextBox.Text))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    switch (insertionTypeCheck.SelectedItem)
                    {
                        case "Sport":
                            break;
                        case "League":
                            db.insertLeague(values[0], DateTime.Today, values[1], values[4], values[3], int.Parse(values[5]));
                            break;
                        case "Club":
                            db.insertClub(values[0], values[1], DateTime.Today, null, values[3], int.Parse(values[4]));
                            break;
                        case "Person":
                            break;
                        case "Player":
                            // Nome;URL_Externo;Nome_Clube;Nome_Liga;Nome_Desporto;Designação_Posição;ID_Externo;BirthDay;Height;Weight;Nation
                            // 23/03/1991
                            DateTime? birthDate = null;
                            int? height = null;
                            int? weight = null;
                            String nation = null;

                            if (values[7] != "None")
                            {
                                birthDate = (DateTime?) DateTime.ParseExact(values[7], "dd/MM/yyyy", null);
                            }
                            if(values[10] != "None")
                            {
                                nation = values[10];
                            }
                            if(values[8] != "None")
                            {
                                height = (int?) int.Parse(values[8]);
                            }
                            if (values[9] != "None")
                            {
                                weight = (int?) int.Parse(values[9]);

                            }
                            db.insertPlayer(values[0], values[2], values[5], values[1], nation , birthDate, height, weight, int.Parse(values[6]));
                            break;
                        case "Scout":
                            break;
                        case "Report":
                            break;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            db.insertSport(sportNameTB.Text, sportURLTB.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clubSearchButton_Click(object sender, EventArgs e)
        {
            this.club = db.getClubByName(clubNameTB.Text);
            updateBinding(Lista_Clubes_Encontrados, this.club, "FullInfo");

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void addPositionButton_Click(object sender, EventArgs e)
        {
            db.insertPosition(addPositionTB.Text, "Football");
        }
    }
}
