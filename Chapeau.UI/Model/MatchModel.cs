namespace Chapeau.UI.Model
{
    public class MatchModel
    {
        public ClubModel ClubDomicile { get; set; }

        public ClubModel ClubExterieur { get; set; }

        public int NbButAllerDomicile { get; set; }

        public int NbButAllerExterieur { get; set; }

        public string Competition { get; set; }

        public int NbButAllerDomicileProno { get; set; }

        public int NbButAllerExterieurProno { get; set; }
    }
}
