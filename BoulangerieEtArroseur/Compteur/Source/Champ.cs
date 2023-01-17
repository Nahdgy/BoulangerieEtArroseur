
namespace BoulangerieEtArroseur.Compteur.Source
{
    class Champ
    {
        /**
         * Une parcelle contient soit : 
         * - un plant, noté "x"
         * - un arroseur, noté "o"
         * Exemple pour une parcelle 3*3 :
         *      x x x
         *      x o x
         *      x x x
         * Cette parcelle contient 8 plants et 1 arroseur
         * 
         * Pour obtenir l'élément à la position [0, 0] : parcelle[0, 0]
         * Pour obtenir le nombre de lignes : parcelle.GetLength(0)
         * Pour obtenir le nombre de colonnes : parcelle.GetLength(1)
         */
        char[,] parcelle;

        public Champ(char[,] parcelle)
        {
            this.parcelle = parcelle;
        }

        /**
         * Renvoie le nombre d'arroseurs présents dans la parcelle
         * Les arroseurs sont représentés par la lette "o"
         */
        public int GetNombreArroseurs()
        {
            return 0;
        }

        /**
         * Renvoie le nombre de plants présents dans la parcelle
         * Les plants sont représentés par la lettre "x"
         */
        public int GetNombrePlants()
        {
            return 0;
        }

        /**
         * Renvoie le nombre de plants arrosés dans la parcelle
         * Les plants sont représentés par la lettre "x"
         * On considère qu'un plant est arrosé s'il se trouve dans une case
         * adjacente à un arroseur.
         * Les diagonales comptent, donc un arroseur peut arroser jusqu'à 8 plants
         */
        public int GetNombrePlantsArroses()
        {
            return 0;
        }
    }
}
