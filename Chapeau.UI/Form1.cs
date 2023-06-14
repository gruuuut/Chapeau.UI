using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Chapeau.UI.Model;

namespace Chapeau.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            if (LoadingUtil.LoadDataFromSource())
            {
                foreach (var club in Singleton.Instance.Clubs)
                {
                    ListViewItem item = new ListViewItem(new[] { club.Nom, club.Coefficient.ToString() });
                    lvClubs.Items.Add(item);
                }

                foreach (var match in Singleton.Instance.Matches)
                {
                    ListViewItem item = new ListViewItem(new[] {
                        match.Competition,
                        match.ClubDomicile.Nom,
                        match.ClubDomicile.Coefficient.ToString(),
                        match.ClubExterieur.Nom,
                        match.ClubExterieur.Coefficient.ToString(),
                        string.Concat(match.NbButAllerDomicile, '-', match.NbButAllerExterieur) });
                    lvMatches.Items.Add(item);
                }
            }
        }

        private void btnGenererPireMieuxSrfc_Click(object sender, EventArgs e)
        {
            List<MatchModel> matchesAuPire = Singleton.Instance.Matches;
            lvMatches.Items.Clear();

            foreach (var match in Singleton.Instance.Matches)
            {
                var prono = TirageUtil.Tirer();

                ListViewItem item = new ListViewItem(new[] {
                        match.Competition,
                        match.ClubDomicile.Nom,
                        match.ClubDomicile.Coefficient.ToString(),
                        match.ClubExterieur.Nom,
                        match.ClubExterieur.Coefficient.ToString(),
                        string.Concat(match.NbButAllerDomicile, '-', match.NbButAllerExterieur),
                        string.Concat(prono.NbButsDomicile, '-', prono.NbButsExterieur)});
                lvMatches.Items.Add(item);
            }
        }
    }
}
