using BoulangerieEtArroseur.Compteur.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoulangerieEtArroseur.Compteur.Test
{
    [TestClass]
    public class ChampTest
    {
        [TestMethod]
        public void parcelleSansArroseurs()
        {
            char[,] parcelle = new char[3, 1]{
                                {'x'},
                                {'x'},
                                {'x'}
                            };
            Champ champ = new Champ(parcelle);

            int nbArrsoeurs = champ.GetNombreArroseurs();
            Assert.AreEqual(0, nbArrsoeurs);

            int nbPlants = champ.GetNombrePlants();
            Assert.AreEqual(3, nbPlants);

            int nbPlantsArroses = champ.GetNombrePlantsArroses();
            Assert.AreEqual(0, nbPlantsArroses);
        }

        [TestMethod]
        public void parcelleSansPlants()
        {
            char[,] parcelle = new char[3, 1]{
                                {'o'},
                                {'o'},
                                {'o'}
                            };
            Champ champ = new Champ(parcelle);

            int nbArrsoeurs = champ.GetNombreArroseurs();
            Assert.AreEqual(3, nbArrsoeurs);

            int nbPlants = champ.GetNombrePlants();
            Assert.AreEqual(0, nbPlants);

            int nbPlantsArroses = champ.GetNombrePlantsArroses();
            Assert.AreEqual(0, nbPlantsArroses);
        }

        [TestMethod]
        public void parcelle3x3()
        {
            char[,] parcelle = new char[3, 3]{
                                {'x', 'x', 'x'},
                                {'x', 'o', 'x'},
                                {'x', 'x', 'x'}
                            };
            Champ champ = new Champ(parcelle);

            int nbArrsoeurs = champ.GetNombreArroseurs();
            Assert.AreEqual(1, nbArrsoeurs);

            int nbPlants = champ.GetNombrePlants();
            Assert.AreEqual(8, nbPlants);

            int nbPlantsArroses = champ.GetNombrePlantsArroses();
            Assert.AreEqual(8, nbPlantsArroses);
        }

        [TestMethod]
        public void parcelle3x3Avec2Arroseurs()
        {
            char[,] parcelle = new char[3, 3]{
                                {'x', 'o', 'x'},
                                {'x', 'o', 'x'},
                                {'x', 'x', 'x'}
                            };
            Champ champ = new Champ(parcelle);

            int nbArrsoeurs = champ.GetNombreArroseurs();
            Assert.AreEqual(2, nbArrsoeurs);

            int nbPlants = champ.GetNombrePlants();
            Assert.AreEqual(7, nbPlants);

            int nbPlantsArroses = champ.GetNombrePlantsArroses();
            Assert.AreEqual(8, nbPlantsArroses);
        }

        [TestMethod]
        public void parcelle3x3Avec1ArroseurEnCoin()
        {
            char[,] parcelle = new char[3, 3]{
                                {'o', 'x', 'x'},
                                {'x', 'x', 'x'},
                                {'x', 'x', 'x'}
                            };
            Champ champ = new Champ(parcelle);

            int nbArrsoeurs = champ.GetNombreArroseurs();
            Assert.AreEqual(1, nbArrsoeurs);

            int nbPlants = champ.GetNombrePlants();
            Assert.AreEqual(8, nbPlants);

            int nbPlantsArroses = champ.GetNombrePlantsArroses();
            Assert.AreEqual(3, nbPlantsArroses);
        }

        [TestMethod]
        public void parcelle8x8()
        {
            char[,] parcelle = new char[8, 8]{
                                {'x', 'x', 'x', 'x', 'x', 'x', 'o', 'x'},
                                {'x', 'o', 'x', 'x', 'x', 'x', 'x', 'x'},
                                {'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x'},
                                {'x', 'x', 'x', 'x', 'o', 'o', 'x', 'x'},
                                {'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x'},
                                {'x', 'x', 'x', 'x', 'x', 'x', 'x', 'o'},
                                {'o', 'x', 'x', 'x', 'x', 'x', 'x', 'x'},
                                {'x', 'x', 'x', 'x', 'o', 'x', 'x', 'x'}
                            };
            Champ champ = new Champ(parcelle);

            int nbArrsoeurs = champ.GetNombreArroseurs();
            Assert.AreEqual(7, nbArrsoeurs);

            int nbPlants = champ.GetNombrePlants();
            Assert.AreEqual(57, nbPlants);

            int nbPlantsArroses = champ.GetNombrePlantsArroses();
            Assert.AreEqual(37, nbPlantsArroses);
        }
    }
}
