namespace Chapeau.UI
{
    partial class frmMain
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
            this.btnGenerer = new System.Windows.Forms.Button();
            this.cbPriseEnCompteAller = new System.Windows.Forms.CheckBox();
            this.cbPriseEnCompteCoeff = new System.Windows.Forms.CheckBox();
            this.tbNbGenerations = new System.Windows.Forms.TextBox();
            this.btnGenererPireMieuxSrfc = new System.Windows.Forms.Button();
            this.btnImporter = new System.Windows.Forms.Button();
            this.lvClubs = new System.Windows.Forms.ListView();
            this.columnNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCoefficient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMatches = new System.Windows.Forms.ListView();
            this.columnCompetition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEquipeDomicile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCoefficientDomicile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEquipeExterieur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCoefficientExterieur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnScoreAller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(12, 8);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(128, 23);
            this.btnGenerer.TabIndex = 0;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            // 
            // cbPriseEnCompteAller
            // 
            this.cbPriseEnCompteAller.AutoSize = true;
            this.cbPriseEnCompteAller.Location = new System.Drawing.Point(158, 12);
            this.cbPriseEnCompteAller.Name = "cbPriseEnCompteAller";
            this.cbPriseEnCompteAller.Size = new System.Drawing.Size(156, 17);
            this.cbPriseEnCompteAller.TabIndex = 1;
            this.cbPriseEnCompteAller.Text = "Prise en compte match aller";
            this.cbPriseEnCompteAller.UseVisualStyleBackColor = true;
            // 
            // cbPriseEnCompteCoeff
            // 
            this.cbPriseEnCompteCoeff.AutoSize = true;
            this.cbPriseEnCompteCoeff.Location = new System.Drawing.Point(320, 12);
            this.cbPriseEnCompteCoeff.Name = "cbPriseEnCompteCoeff";
            this.cbPriseEnCompteCoeff.Size = new System.Drawing.Size(185, 17);
            this.cbPriseEnCompteCoeff.TabIndex = 2;
            this.cbPriseEnCompteCoeff.Text = "Prise en compte coefficient UEFA";
            this.cbPriseEnCompteCoeff.UseVisualStyleBackColor = true;
            // 
            // tbNbGenerations
            // 
            this.tbNbGenerations.Location = new System.Drawing.Point(511, 9);
            this.tbNbGenerations.Name = "tbNbGenerations";
            this.tbNbGenerations.Size = new System.Drawing.Size(118, 20);
            this.tbNbGenerations.TabIndex = 3;
            this.tbNbGenerations.Text = "10000";
            // 
            // btnGenererPireMieuxSrfc
            // 
            this.btnGenererPireMieuxSrfc.Location = new System.Drawing.Point(12, 37);
            this.btnGenererPireMieuxSrfc.Name = "btnGenererPireMieuxSrfc";
            this.btnGenererPireMieuxSrfc.Size = new System.Drawing.Size(169, 25);
            this.btnGenererPireMieuxSrfc.TabIndex = 4;
            this.btnGenererPireMieuxSrfc.Text = "Générer pire mieux Stade Rennais";
            this.btnGenererPireMieuxSrfc.UseVisualStyleBackColor = true;
            this.btnGenererPireMieuxSrfc.Click += new System.EventHandler(this.btnGenererPireMieuxSrfc_Click);
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(12, 68);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(128, 23);
            this.btnImporter.TabIndex = 5;
            this.btnImporter.Text = "Importer";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // lvClubs
            // 
            this.lvClubs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNom,
            this.columnCoefficient});
            this.lvClubs.Location = new System.Drawing.Point(13, 98);
            this.lvClubs.Name = "lvClubs";
            this.lvClubs.Size = new System.Drawing.Size(220, 174);
            this.lvClubs.TabIndex = 6;
            this.lvClubs.UseCompatibleStateImageBehavior = false;
            this.lvClubs.View = System.Windows.Forms.View.Details;
            // 
            // columnNom
            // 
            this.columnNom.Text = "Club";
            this.columnNom.Width = 100;
            // 
            // columnCoefficient
            // 
            this.columnCoefficient.Text = "Coeff.";
            // 
            // lvMatches
            // 
            this.lvMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCompetition,
            this.columnEquipeDomicile,
            this.columnCoefficientDomicile,
            this.columnEquipeExterieur,
            this.columnCoefficientExterieur,
            this.columnScoreAller,
            this.columnProno});
            this.lvMatches.Location = new System.Drawing.Point(239, 98);
            this.lvMatches.Name = "lvMatches";
            this.lvMatches.Size = new System.Drawing.Size(549, 340);
            this.lvMatches.TabIndex = 7;
            this.lvMatches.UseCompatibleStateImageBehavior = false;
            this.lvMatches.View = System.Windows.Forms.View.Details;
            // 
            // columnCompetition
            // 
            this.columnCompetition.Text = "Comp.";
            // 
            // columnEquipeDomicile
            // 
            this.columnEquipeDomicile.Text = "Domicile";
            this.columnEquipeDomicile.Width = 100;
            // 
            // columnCoefficientDomicile
            // 
            this.columnCoefficientDomicile.Text = "Coeff.";
            // 
            // columnEquipeExterieur
            // 
            this.columnEquipeExterieur.Text = "Ext.";
            this.columnEquipeExterieur.Width = 100;
            // 
            // columnCoefficientExterieur
            // 
            this.columnCoefficientExterieur.Text = "Coeff.";
            // 
            // columnScoreAller
            // 
            this.columnScoreAller.Text = "Aller";
            // 
            // columnProno
            // 
            this.columnProno.Text = "Prono";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvMatches);
            this.Controls.Add(this.lvClubs);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.btnGenererPireMieuxSrfc);
            this.Controls.Add(this.tbNbGenerations);
            this.Controls.Add(this.cbPriseEnCompteCoeff);
            this.Controls.Add(this.cbPriseEnCompteAller);
            this.Controls.Add(this.btnGenerer);
            this.Name = "frmMain";
            this.Text = "Génération de chapeaux pour tirage au sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.CheckBox cbPriseEnCompteAller;
        private System.Windows.Forms.CheckBox cbPriseEnCompteCoeff;
        private System.Windows.Forms.TextBox tbNbGenerations;
        private System.Windows.Forms.Button btnGenererPireMieuxSrfc;
        private System.Windows.Forms.Button btnImporter;
        private System.Windows.Forms.ListView lvClubs;
        private System.Windows.Forms.ListView lvMatches;
        private System.Windows.Forms.ColumnHeader columnNom;
        private System.Windows.Forms.ColumnHeader columnCoefficient;
        private System.Windows.Forms.ColumnHeader columnCompetition;
        private System.Windows.Forms.ColumnHeader columnEquipeDomicile;
        private System.Windows.Forms.ColumnHeader columnCoefficientDomicile;
        private System.Windows.Forms.ColumnHeader columnEquipeExterieur;
        private System.Windows.Forms.ColumnHeader columnCoefficientExterieur;
        private System.Windows.Forms.ColumnHeader columnScoreAller;
        private System.Windows.Forms.ColumnHeader columnProno;
    }
}

