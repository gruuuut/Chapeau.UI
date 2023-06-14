using System;
using System.Collections.Generic;
using Chapeau.UI.Model;

namespace Chapeau.UI
{
    public static class TirageUtil
    {
        public static List<MatchModel> TirerAusort(List<MatchModel> matches, bool prendreEnCompteMatchAller, bool prendreEnCompteCoeff)
        {
            foreach (var match in matches)
            {
                TirerAusort(match, prendreEnCompteMatchAller, prendreEnCompteCoeff);
            }
            return matches;
        }

        public static MatchModel TirerAusort(MatchModel match, bool prendreEnCompteMatchAller, bool prendreEnCompteCoeff)
        {
            ScoreModel score = Tirer();
            match.NbButAllerDomicileProno = score.NbButsDomicile;
            match.NbButAllerExterieurProno = score.NbButsExterieur;
            return match;
        }

        public static ScoreModel Tirer()
        {
            Random r = new Random();
            int randomNumber = r.Next(1, 1000);

            if (randomNumber < 133)
                return new ScoreModel { NbButsDomicile = 1, NbButsExterieur = 1 };
            else if (randomNumber < 244)
                return new ScoreModel { NbButsDomicile = 1, NbButsExterieur = 0 };
            else if (randomNumber < 336)
                return new ScoreModel { NbButsDomicile = 0, NbButsExterieur = 1 };
            else if (randomNumber < 420)
                return new ScoreModel { NbButsDomicile = 0, NbButsExterieur = 0 };
            else if (randomNumber < 504)
                return new ScoreModel { NbButsDomicile = 2, NbButsExterieur = 1 };
            else if (randomNumber < 578)
                return new ScoreModel { NbButsDomicile = 2, NbButsExterieur = 0 };
            else if (randomNumber < 644)
                return new ScoreModel { NbButsDomicile = 2, NbButsExterieur = 2 };
            else if (randomNumber < 702)
                return new ScoreModel { NbButsDomicile = 1, NbButsExterieur = 2 };
            else if (randomNumber < 749)
                return new ScoreModel { NbButsDomicile = 3, NbButsExterieur = 0 };
            else if (randomNumber < 781)
                return new ScoreModel { NbButsDomicile = 3, NbButsExterieur = 1 };
            else if (randomNumber < 810)
                return new ScoreModel { NbButsDomicile = 0, NbButsExterieur = 2 };
            else if (randomNumber < 836)
                return new ScoreModel { NbButsDomicile = 1, NbButsExterieur = 3 };
            else if (randomNumber < 860)
                return new ScoreModel { NbButsDomicile = 2, NbButsExterieur = 3 };
            else if (randomNumber < 884)
                return new ScoreModel { NbButsDomicile = 3, NbButsExterieur = 2 };
            else if (randomNumber < 908)
                return new ScoreModel { NbButsDomicile = 4, NbButsExterieur = 0 };
            else if (randomNumber < 924)
                return new ScoreModel { NbButsDomicile = 0, NbButsExterieur = 3 };
            else if (randomNumber < 937)
                return new ScoreModel { NbButsDomicile = 5, NbButsExterieur = 0 };
            else if (randomNumber < 948)
                return new ScoreModel { NbButsDomicile = 0, NbButsExterieur = 4 };
            else if (randomNumber < 959)
                return new ScoreModel { NbButsDomicile = 2, NbButsExterieur = 4 };
            else if (randomNumber < 967)
                return new ScoreModel { NbButsDomicile = 4, NbButsExterieur = 1 };
            else if (randomNumber < 975)
                return new ScoreModel { NbButsDomicile = 3, NbButsExterieur = 3 };
            else if (randomNumber < 983)
                return new ScoreModel { NbButsDomicile = 5, NbButsExterieur = 1 };
            else if (randomNumber < 986)
                return new ScoreModel { NbButsDomicile = 3, NbButsExterieur = 4 };
            else if (randomNumber < 989)
                return new ScoreModel { NbButsDomicile = 0, NbButsExterieur = 5 };
            else if (randomNumber < 992)
                return new ScoreModel { NbButsDomicile = 2, NbButsExterieur = 5 };
            else if (randomNumber < 995)
                return new ScoreModel { NbButsDomicile = 1, NbButsExterieur = 4 };
            else if (randomNumber < 998)
                return new ScoreModel { NbButsDomicile = 4, NbButsExterieur = 3 };
            else if (randomNumber < 1000)
                return new ScoreModel { NbButsDomicile = 4, NbButsExterieur = 2 };
            else if (randomNumber < 1001)
                return new ScoreModel { NbButsDomicile = 1, NbButsExterieur = 5 };
            else
                return new ScoreModel { NbButsDomicile = 10, NbButsExterieur = 10 };
        }
    }
}
