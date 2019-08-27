using System.Collections.Generic;
using Chapeau.UI.Model;

namespace Chapeau.UI
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        public List<ClubModel> Clubs;

        public List<MatchModel> Matches;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
