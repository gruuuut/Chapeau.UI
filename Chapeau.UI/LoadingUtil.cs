using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau.UI.Model;

namespace Chapeau.UI
{
    public static class LoadingUtil
    {
        public static bool LoadDataFromSource()
        {
            List<ClubModel> Clubs = new List<ClubModel>();
            List<MatchModel> Matches = new List<MatchModel>();

            // Récupération de toutes les lignes de Source.txt
            string solutionPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

            string[] linesQualifiesChapeauCertain = File.ReadAllLines(Path.Combine(solutionPath, "Input/QualifiesChapeauCertain.csv"));
            foreach (string line in linesQualifiesChapeauCertain)
            {
                string[] arrayClub = line.Split(',');
                Clubs.Add(new ClubModel { Nom = arrayClub[0], Coefficient = int.Parse(arrayClub[1]), IsQualified = true });
            }

            string[] linesQualifiesChapeauIncertain = File.ReadAllLines(Path.Combine(solutionPath, "Input/QualifiesChapeauIncertain.csv"));
            foreach (string line in linesQualifiesChapeauIncertain)
            {
                string[] arrayClub = line.Split(',');
                Clubs.Add(new ClubModel { Nom = arrayClub[0], Coefficient = int.Parse(arrayClub[1]), IsQualified = true });
            }

            string[] linesMatches = File.ReadAllLines(Path.Combine(solutionPath, "Input/Matches.csv"));
            foreach (string line in linesMatches)
            {
                string[] arrayMatch = line.Split(',');
                MatchModel match = new MatchModel();                
                match.Competition = arrayMatch[0];

                ClubModel clubDomicile = new ClubModel();
                clubDomicile.Nom = arrayMatch[1];
                clubDomicile.Coefficient = int.Parse(arrayMatch[2]);
                clubDomicile.IsQualified = false;
                match.ClubDomicile = clubDomicile;

                ClubModel clubExterieur = new ClubModel();
                clubExterieur.Nom = arrayMatch[3];
                clubExterieur.Coefficient = int.Parse(arrayMatch[4]);
                clubExterieur.IsQualified = false;
                match.ClubExterieur = clubExterieur;

                match.NbButAllerDomicile = int.Parse(arrayMatch[5]);
                match.NbButAllerExterieur = int.Parse(arrayMatch[6]);

                Matches.Add(match);
            }

            Singleton.Instance.Clubs = Clubs;
            Singleton.Instance.Matches = Matches;

            //MessageBox.Show("Import effectué avec succès." + Environment.NewLine + string.Format("Clubs : {0}, Matches {1}", Singleton.Instance.Clubs.Count, Singleton.Instance.Matches.Count), "Information");

            return true;
        }
    }
}
