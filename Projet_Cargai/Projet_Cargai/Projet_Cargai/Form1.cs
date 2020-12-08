using Projet_Carg.dao.liste;
using Projet_Carg.models;
using Projet_Carg.services;
using Projet_Carg.services.liste;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Cargai
{
    public partial class Form1 : Form
    {
        private readonly Service service = new Service(dao: new CargaisonDao());
        private Cargaison cargaisonSelect;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCargaison_Click(object sender, EventArgs e)
        {
            Cargaison cargaison = null;
            if (string.IsNullOrEmpty(txtDistance.Text))
            {
                MessageBox.Show("Veuillez saisir la distance", "Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (cboType.Text.CompareTo(TYPE_CARGAISON.AERIENNE.ToString()) == 0)
                {
                    cargaison = new Aerienne()
                    {
                        Distance = int.Parse(txtDistance.Text)
                    };
                }
                else
                {
                    cargaison = new Routiere()
                    {
                        Distance = int.Parse(txtDistance.Text)
                    };
                }

                if (service.addCargaison(cargaison))
                {
                    listViewCargaison.Items.Add(cargaison.ToString());
                    txtDistance.Clear();
                    MessageBox.Show("Cargaison ajoutée avec succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Cargaison ajoutée avec succes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var cargaison in service.listerCargaison())
            {
                listViewCargaison.Items.Add(cargaison);
            }
            listViewCargaison.SelectedIndex = 0;
            
            
        }

        private void listViewCargaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaisonSelect =(Cargaison) listViewCargaison.SelectedItem;
            dgvMarchandise.DataSource = cargaisonSelect.Marchandises;
        }

        private void btnAddMarchandise_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPoids.Text) || (string.IsNullOrEmpty(txtVolume.Text)))
            {
                MessageBox.Show("Veuillez saisir le poids ou le volume", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Marchandise march = new Marchandise()
                {
                    Poids = double.Parse(txtPoids.Text),
                    Volume = double.Parse(txtVolume.Text)
                };
                cargaisonSelect.addMarchandise(march);
                //dgvMarchandise.DataSource = cargaisonSelect.Marchandises;
            }
        }
    }
}
