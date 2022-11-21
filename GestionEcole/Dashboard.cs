using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEcole
{
    public partial class Dashboard : Form
    {
        //Utilisateurs u;
        //Professeurs p;
        //Etudiants etud;
        //Classes c;
        //Filieres f;
        //InfoEcole i;
        Form CurrentForm;
        private void Show(Form f)
        {
            if (f.GetType() != CurrentForm.GetType())
            {
                CurrentForm.Close();
                f.MdiParent = ActiveForm;
                f.Show();
                CurrentForm = f;
            }

        }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Others u = new Others();
            Show(u);
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            Professeurs p = new Professeurs();
            Show(p);
        }

        private void btnEtud_Click(object sender, EventArgs e)
        {
            Etudiants etud = new Etudiants();
            Show(etud);

        }

        private void btnFiliere_Click(object sender, EventArgs e)
        {
            Filieres f = new Filieres();
            Show(f);
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Classes c = new Classes();
            Show(c);
        }

        private void btnEcole_Click(object sender, EventArgs e)
        {
            InfoEcole i = new InfoEcole();
            Show(i);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            LOGO lg = new LOGO()
            {
                MdiParent = this
            };
            CurrentForm = lg;
            lg.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
