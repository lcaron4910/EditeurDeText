namespace EditeurDeTexteForm
{
    partial class fm_principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rt_texte = new System.Windows.Forms.RichTextBox();
            this.mn_principal = new System.Windows.Forms.MenuStrip();
            this.m_fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ouvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_enregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.m_edition = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_annuler = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_retablir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_copier = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_couper = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_coller = new System.Windows.Forms.ToolStripMenuItem();
            this.od_ouvrir = new System.Windows.Forms.OpenFileDialog();
            this.sf_save = new System.Windows.Forms.SaveFileDialog();
            this.tb_recherche = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.mn_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rt_texte
            // 
            this.rt_texte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rt_texte.Location = new System.Drawing.Point(0, 24);
            this.rt_texte.Name = "rt_texte";
            this.rt_texte.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rt_texte.Size = new System.Drawing.Size(502, 238);
            this.rt_texte.TabIndex = 0;
            this.rt_texte.Text = "";
            // 
            // mn_principal
            // 
            this.mn_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fichier,
            this.m_edition});
            this.mn_principal.Location = new System.Drawing.Point(0, 0);
            this.mn_principal.Name = "mn_principal";
            this.mn_principal.Size = new System.Drawing.Size(502, 24);
            this.mn_principal.TabIndex = 1;
            this.mn_principal.Text = "menuStrip1";
            // 
            // m_fichier
            // 
            this.m_fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_nouveau,
            this.mi_ouvrir,
            this.mi_enregistrer,
            this.mi_enregistrerSous,
            this.toolStripMenuItem1,
            this.mi_quitter});
            this.m_fichier.Name = "m_fichier";
            this.m_fichier.Size = new System.Drawing.Size(54, 20);
            this.m_fichier.Text = "&Fichier";
            this.m_fichier.Click += new System.EventHandler(this.m_fichier_Click);
            // 
            // mi_nouveau
            // 
            this.mi_nouveau.Name = "mi_nouveau";
            this.mi_nouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_nouveau.Size = new System.Drawing.Size(226, 22);
            this.mi_nouveau.Text = "Nouveau";
            this.mi_nouveau.Click += new System.EventHandler(this.mi_nouveau_Click);
            // 
            // mi_ouvrir
            // 
            this.mi_ouvrir.Name = "mi_ouvrir";
            this.mi_ouvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_ouvrir.Size = new System.Drawing.Size(226, 22);
            this.mi_ouvrir.Text = "&Ouvrir";
            this.mi_ouvrir.Click += new System.EventHandler(this.mi_ouvrir_Click);
            // 
            // mi_enregistrer
            // 
            this.mi_enregistrer.Name = "mi_enregistrer";
            this.mi_enregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_enregistrer.Size = new System.Drawing.Size(226, 22);
            this.mi_enregistrer.Text = "Enregistrer";
            this.mi_enregistrer.Click += new System.EventHandler(this.mi_enregistrer_Click);
            // 
            // mi_enregistrerSous
            // 
            this.mi_enregistrerSous.Name = "mi_enregistrerSous";
            this.mi_enregistrerSous.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.mi_enregistrerSous.Size = new System.Drawing.Size(226, 22);
            this.mi_enregistrerSous.Text = "Enregistrer sous..";
            this.mi_enregistrerSous.Click += new System.EventHandler(this.mi_enregistrerSous_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // mi_quitter
            // 
            this.mi_quitter.Name = "mi_quitter";
            this.mi_quitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mi_quitter.Size = new System.Drawing.Size(226, 22);
            this.mi_quitter.Text = "&Quitter";
            this.mi_quitter.Click += new System.EventHandler(this.mi_quitter_Click);
            // 
            // m_edition
            // 
            this.m_edition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_annuler,
            this.mi_retablir,
            this.mi_copier,
            this.mi_couper,
            this.mi_coller});
            this.m_edition.Name = "m_edition";
            this.m_edition.Size = new System.Drawing.Size(56, 20);
            this.m_edition.Text = "Edition";
            this.m_edition.Click += new System.EventHandler(this.m_edition_Click);
            // 
            // mi_annuler
            // 
            this.mi_annuler.Name = "mi_annuler";
            this.mi_annuler.Size = new System.Drawing.Size(116, 22);
            this.mi_annuler.Text = "Annuler";
            this.mi_annuler.Click += new System.EventHandler(this.mi_annuler_Click);
            // 
            // mi_retablir
            // 
            this.mi_retablir.Name = "mi_retablir";
            this.mi_retablir.Size = new System.Drawing.Size(116, 22);
            this.mi_retablir.Text = "Rétablir";
            this.mi_retablir.Click += new System.EventHandler(this.mi_retablir_Click);
            // 
            // mi_copier
            // 
            this.mi_copier.Name = "mi_copier";
            this.mi_copier.Size = new System.Drawing.Size(116, 22);
            this.mi_copier.Text = "Copier";
            this.mi_copier.Click += new System.EventHandler(this.mi_copier_Click);
            // 
            // mi_couper
            // 
            this.mi_couper.Name = "mi_couper";
            this.mi_couper.Size = new System.Drawing.Size(116, 22);
            this.mi_couper.Text = "Couper";
            this.mi_couper.Click += new System.EventHandler(this.mi_couper_Click);
            // 
            // mi_coller
            // 
            this.mi_coller.Name = "mi_coller";
            this.mi_coller.Size = new System.Drawing.Size(116, 22);
            this.mi_coller.Text = "Coller";
            this.mi_coller.Click += new System.EventHandler(this.mi_coller_Click);
            // 
            // od_ouvrir
            // 
            this.od_ouvrir.FileName = "openFileDialog1";
            // 
            // tb_recherche
            // 
            this.tb_recherche.Location = new System.Drawing.Point(335, 0);
            this.tb_recherche.Name = "tb_recherche";
            this.tb_recherche.Size = new System.Drawing.Size(100, 20);
            this.tb_recherche.TabIndex = 2;
            this.tb_recherche.Text = "Rechercher";
            this.tb_recherche.TextChanged += new System.EventHandler(this.tb_recherche_TextChanged);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(435, 4);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(0, 13);
            this.lblFind.TabIndex = 4;
            // 
            // fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 262);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.tb_recherche);
            this.Controls.Add(this.rt_texte);
            this.Controls.Add(this.mn_principal);
            this.MainMenuStrip = this.mn_principal;
            this.Name = "fm_principal";
            this.Text = "Mon petit éditeur";
            this.mn_principal.ResumeLayout(false);
            this.mn_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_texte;
        private System.Windows.Forms.MenuStrip mn_principal;
        private System.Windows.Forms.ToolStripMenuItem m_fichier;
        private System.Windows.Forms.ToolStripMenuItem mi_ouvrir;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem mi_quitter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog od_ouvrir;
        private System.Windows.Forms.SaveFileDialog sf_save;
        private System.Windows.Forms.ToolStripMenuItem mi_nouveau;
        private System.Windows.Forms.ToolStripMenuItem mi_enregistrer;
        private System.Windows.Forms.ToolStripMenuItem m_edition;
        private System.Windows.Forms.ToolStripMenuItem mi_annuler;
        private System.Windows.Forms.ToolStripMenuItem mi_retablir;
        private System.Windows.Forms.ToolStripMenuItem mi_copier;
        private System.Windows.Forms.ToolStripMenuItem mi_couper;
        private System.Windows.Forms.ToolStripMenuItem mi_coller;
        private System.Windows.Forms.TextBox tb_recherche;
        private System.Windows.Forms.Label lblFind;

    }
}

