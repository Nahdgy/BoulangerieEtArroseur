
namespace BoulangerieEtArroseur.Comparaisons.Source
{
    class ComparateurBoulangeries
    {
        /**
         * Chaque case du tableau représente une boulangerie
         * Chaque valeur du tableau représente le prix d'une baguette dans la boulangerie donnée
         * Exemple :
         * 
         *      0       1       2
         *      0.6     0.8     1.0
         */
        float[] boulangeries;

        public ComparateurBoulangeries(float[] boulangeries)
        {
            this.boulangeries = boulangeries;
        }

        /**
         * Renvoie la position dans le tableau de la boulangerie 
         * dont le prix est le plus bas
         * Pour l'exemple ci-dessous :
         *      0       1       2
         *      0.6     0.8     1.0
         * Le meilleur prix est "0.6", on renvoie donc la position 0
         */
        public int GetMeilleureBoulangerie()
        {
            return 0;
        }

        /**
         * Pour un montant donné, 
         * renvoie le nombre maximum de baguettes que l'on peut acheter.
         * Par exemple :
         * monnaie = 6.0
         * La liste des boulangeries est celle ci-dessous :
         *      0       1       2
         *      0.6     0.8     1.0
         * On peut acheter au maximum 10 baguettes.
         * Avec 6e, je peux acheter 10 baguettes à 0.6e.
         * On renvoie donc le chiffre 10.
         */
        public int GetNombreMaxBaguettes(float monnaie)
        {
            return 0;
        }
    }
}
