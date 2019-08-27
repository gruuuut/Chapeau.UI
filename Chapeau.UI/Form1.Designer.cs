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
            this.btnGenererMinMaxSrfc = new System.Windows.Forms.Button();
            this.btnImporter = new System.Windows.Forms.Button();
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
            // btnGenererMinMaxSrfc
            // 
            this.btnGenererMinMaxSrfc.Location = new System.Drawing.Point(336, 214);
            this.btnGenererMinMaxSrfc.Name = "btnGenererMinMaxSrfc";
            this.btnGenererMinMaxSrfc.Size = new System.Drawing.Size(169, 25);
            this.btnGenererMinMaxSrfc.TabIndex = 4;
            this.btnGenererMinMaxSrfc.Text = "Générer min max Stade Rennais";
            this.btnGenererMinMaxSrfc.UseVisualStyleBackColor = true;
            // 
            // btnImporter
            // 
            this.btnImporter.Location = new System.Drawing.Point(12, 59);
            this.btnImporter.Name = "btnImporter";
            this.btnImporter.Size = new System.Drawing.Size(128, 23);
            this.btnImporter.TabIndex = 5;
            this.btnImporter.Text = "Importer";
            this.btnImporter.UseVisualStyleBackColor = true;
            this.btnImporter.Click += new System.EventHandler(this.btnImporter_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImporter);
            this.Controls.Add(this.btnGenererMinMaxSrfc);
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
        private System.Windows.Forms.Button btnGenererMinMaxSrfc;
        private System.Windows.Forms.Button btnImporter;
    }
}

