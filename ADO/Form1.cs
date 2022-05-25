using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBox_num.Text);
            Magasin m = MagasinDAO.FindById(id);
            if (m == null)
            {
                MessageBox.Show("Ce magasin n'est pas répertorié");
            }
            else
            {
            txtBox_localite.Text = m.Localite;
            txtBox_gerant.Text = m.Gerant;
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            List<Magasin> mag = MagasinDAO.ReadAll();
            string info = "";
            foreach (Magasin m in mag)
            {
                info += m.Id + "-" + m.Localite + " " + m.Gerant + "\n";
            }
            MessageBox.Show(info);
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            Magasin m = new Magasin(int.Parse(txtBox_num.Text), txtBox_localite.Text, txtBox_gerant.Text);
            MagasinDAO.Create(m);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Magasin m = new Magasin(int.Parse(txtBox_num.Text), txtBox_localite.Text, txtBox_gerant.Text);
            bool ok = MagasinDAO.Update(m);
            if (ok)
            {
                MessageBox.Show("Mise à jour réalisée");
            }
            else
            {
                MessageBox.Show("Mise à jour échouée");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBox_num.Text);
            Magasin m = MagasinDAO.FindById(id);
            bool ok = MagasinDAO.Delete(m);
            if (ok)
            {
                MessageBox.Show("Suppression réalisée");
            }
            else
            {
                MessageBox.Show("Suppression échouée");
            }
        }
    }
}
