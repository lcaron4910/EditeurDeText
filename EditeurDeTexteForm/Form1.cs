using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditeurDeTexteForm
{
    public partial class fm_principal : Form
    {
        bool enregistrer = false;

        public fm_principal()
        {
            InitializeComponent();
            m_fichier.Click += new EventHandler(m_fichier_Click);
            mi_quitter.Click += new EventHandler(mi_quitter_Click);
            mi_ouvrir.Click += new EventHandler(mi_ouvrir_Click);
            mi_enregistrerSous.Click += new EventHandler(mi_enregistrerSous_Click);
            mi_nouveau.Click += new EventHandler(mi_nouveau_Click);
            m_edition.Click += new EventHandler(m_edition_Click);
            mi_annuler.Click += new EventHandler(mi_annuler_Click);
            mi_retablir.Click += new EventHandler(mi_retablir_Click);
            mi_couper.Click += new EventHandler(mi_couper_Click);
            mi_coller.Click += new EventHandler(mi_coller_Click);
            mi_copier.Click += new EventHandler(mi_copier_Click);
            tb_recherche.TextChanged += new EventHandler(tb_recherche_TextChanged);
            tb_recherche.Click += new EventHandler(tb_recherche_Click);
        }

        private void m_fichier_Click(object sender, EventArgs e)
        {
            
        }

        private void m_edition_Click(object sender, EventArgs e)
        {

        }

        private void mi_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mi_ouvrir_Click(object sender, EventArgs e)
        {
            if (od_ouvrir.ShowDialog() == DialogResult.OK)
            {
                rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void od_ouvrir_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            rt_texte.LoadFile(od_ouvrir.FileName, RichTextBoxStreamType.PlainText);
            enregistrer = true;
        }

        private void mi_enregistrerSous_Click(object sender, EventArgs e)
        {
            if (sf_save.ShowDialog() == DialogResult.OK)
            {
                rt_texte.SaveFile(sf_save.FileName, RichTextBoxStreamType.PlainText);
                enregistrer = true;
            }
        }

        private void sf_save_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            rt_texte.SaveFile(sf_save.FileName, RichTextBoxStreamType.PlainText);
        }

        private void mi_nouveau_Click(object sender, EventArgs e)
        {
            rt_texte.Clear();
            enregistrer = false;
        }

        private void mi_enregistrer_Click(object sender, EventArgs e)
        {
            if (enregistrer == false)
            {
                if (sf_save.ShowDialog() == DialogResult.OK)
                {
                    rt_texte.SaveFile(sf_save.FileName, RichTextBoxStreamType.PlainText);
                    enregistrer = true;
                }
            }
            else
            {
                rt_texte.SaveFile(sf_save.FileName, RichTextBoxStreamType.PlainText);
                enregistrer = true;
            }
        }

        private void mi_copier_Click(object sender, EventArgs e)
        {
            rt_texte.Copy();
        }

        private void mi_couper_Click(object sender, EventArgs e)
        {
            rt_texte.Cut();
        }

        private void mi_coller_Click(object sender, EventArgs e)
        {
            rt_texte.Paste();
        }

        private void mi_annuler_Click(object sender, EventArgs e)
        {
            rt_texte.Undo();
        }

        private void mi_retablir_Click(object sender, EventArgs e)
        {
            rt_texte.Redo();
        }

        private void tb_recherche_TextChanged(object sender, EventArgs e)
        {
            int index = 0;
            string s = rt_texte.Text;
            rt_texte.Text = "";
            rt_texte.Text = s;
            while (index < rt_texte.Text.LastIndexOf(tb_recherche.Text))
            {
                rt_texte.Find(tb_recherche.Text, index, rt_texte.TextLength, RichTextBoxFinds.None);
                rt_texte.SelectionBackColor = Color.Red;
                index = rt_texte.Text.IndexOf(tb_recherche.Text, index) + 1;
            }
            /*if (tb_recherche.Text == "")
            {
            }*/
            
       
        }

        private void tb_recherche_Click(object sender, EventArgs e)
        {
            tb_recherche.Text = "";
        }

    }
}
