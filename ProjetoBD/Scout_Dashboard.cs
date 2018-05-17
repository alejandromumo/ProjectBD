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
        List<Person> people = new List<Person>();
        List<Report> reports = new List<Report>();
        DataAccess db;

        public Form1()
        {
            InitializeComponent();
            this.db = new DataAccess();
            updateBinding(Lista_Jogadores_Encontrados , this.people, "FullInfo");
            updateBinding(Lista_Observações, this.reports, "FullInfo");
        }

        private void updateBinding<T>(ListBox listBox, List<T> list, string info)
        {
            listBox.DataSource = list;
            listBox.DisplayMember = info;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.people = db.getPeople(NameText.Text);

            updateBinding(Lista_Jogadores_Encontrados, this.people, "FullInfo");
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
                            db.insertLeague(values[0], values[1], values[3], values[4]);
                            break;
                        case "Club":
                            db.insertClub(values[0],values[2],values[3],values[1]);
                            break;
                        case "Person":
                            break;
                        case "Player":
                            db.insertPlayer(values[0], values[2], values[1], values[5], int.Parse(values[6]));
                            break;
                        case "Scout":
                            break;
                        case "Report":
                            break;
                    }
                }
            }
        }
    }
}
