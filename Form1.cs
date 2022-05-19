using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculMoyenne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Etudiant etud = new Etudiant();
        string nom = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Add(txt_NomPrenom.Text + "                                " + txt_Moyenne.Text);



            etud.NomCom = txt_NomPrenom.Text;
            etud.NoteDS = txt_NoteDS.Text;
            etud.NoteEx = txt_NoteExamen.Text;
            etud.NoteTP = txt_NoteTP.Text;
            etud.Moyenne = txt_Moyenne.Text;

            bool success = etud.Insert(etud);

            if(success == true)
            {
                MessageBox.Show("Student Added Successfully");
            }
            else
            {
                MessageBox.Show("Error, Mybe your informations is false!!");
            }


            nom = txt_NomPrenom.Text;
            txt_NomPrenom.Text = "";
            txt_NoteDS.Text = "";
            txt_NoteExamen.Text = "";
            txt_NoteTP.Text = "";
            txt_Moyenne.Clear();
            btn_Ajouter.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Remove(lst_Moyenne.SelectedItem);
            etud.NomCom = nom;

            bool success = etud.Delete(etud);
            if (success == true)
            {
                MessageBox.Show("Student Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Error, Student not found!!");
            }
            btn_Supprimer.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {




            string noteDs = txt_NoteDS.Text;
            string noteTp = txt_NoteTP.Text;
            string noteExaman = txt_NoteExamen.Text;
            Etudiant e1 = new Etudiant(txt_NomPrenom.Text, noteDs, noteTp, noteExaman);
            double moyenne = e1.calculMoy();
            txt_Moyenne.Text = moyenne.ToString();

            btn_Ajouter.Enabled = true;
           
        }

        private void txt_NomPrenom_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text != "" && txt_NoteExamen.Text != "" && txt_NoteDS.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }

        }

        private void txt_Moyenne_TextChanged(object sender, EventArgs e)
        {
            if (txt_Moyenne.Text != "")
            {
                btn_Calculer.Enabled = false;
                btn_Ajouter.Enabled = true;
            }
        }

        private void txt_NoteDS_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text != "" && txt_NoteExamen.Text != "" && txt_NoteDS.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }
        }

        private void txt_NoteExamen_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text != "" && txt_NoteExamen.Text != "" && txt_NoteDS.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }
        }

        private void lst_Moyenne_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Supprimer.Enabled = true;
        }

        private void txt_NoteTP_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text != "" && txt_NoteExamen.Text != "" && txt_NoteDS.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }
        }
    }
}
