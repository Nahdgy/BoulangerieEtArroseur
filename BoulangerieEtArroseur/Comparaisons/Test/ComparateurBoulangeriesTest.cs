using BoulangerieEtArroseur.Comparaisons.Source;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BoulangerieEtArroseur.Comparaisons.Test
{
    [TestClass]
    public class ComparateurBoulangeriesTest
    {
        [TestMethod]
        public void ComparaisonExemple()
        {
            float[] boulangeries = { 0.6f, 0.8f, 1.0f };
            ComparateurBoulangeries comparateur = new ComparateurBoulangeries(boulangeries);

            int positionMeilleureBoulangerie = comparateur.GetMeilleureBoulangerie();
            Assert.AreEqual(0, positionMeilleureBoulangerie);

            float monnaie = 6.0f;
            int nbMaxBaguettes = comparateur.GetNombreMaxBaguettes(monnaie);
            Assert.AreEqual(10, nbMaxBaguettes);
        }

        [TestMethod]
        public void ComparaisonExempleMoinsDArgent()
        {
            float[] boulangeries = { 0.6f, 0.8f, 1.0f };
            ComparateurBoulangeries comparateur = new ComparateurBoulangeries(boulangeries);

            int positionMeilleureBoulangerie = comparateur.GetMeilleureBoulangerie();
            Assert.AreEqual(0, positionMeilleureBoulangerie);

            float monnaie = 1.0f;
            int nbMaxBaguettes = comparateur.GetNombreMaxBaguettes(monnaie);
            Assert.AreEqual(1, nbMaxBaguettes);
        }

        [TestMethod]
        public void Comparaison10Boulangeries()
        {
            float[] boulangeries = { 0.6f, 0.8f, 0.3f, 1.1f, 0.2f, 0.2f, 2.0f, 0.2f, 0.6f, 1.0f };
            ComparateurBoulangeries comparateur = new ComparateurBoulangeries(boulangeries);

            int positionMeilleureBoulangerie = comparateur.GetMeilleureBoulangerie();
            Assert.AreEqual(4, positionMeilleureBoulangerie);

            float monnaie = 6.0f;
            int nbMaxBaguettes = comparateur.GetNombreMaxBaguettes(monnaie);
            Assert.AreEqual(30.0f, nbMaxBaguettes);
        }

        [TestMethod]
        public void ComparaisonPasAssezDArgent()
        {
            float[] boulangeries = { 1.6f, 1.8f, 1.5f };
            ComparateurBoulangeries comparateur = new ComparateurBoulangeries(boulangeries);

            int positionMeilleureBoulangerie = comparateur.GetMeilleureBoulangerie();
            Assert.AreEqual(2, positionMeilleureBoulangerie);

            float monnaie = 0.5f;
            int nbMaxBaguettes = comparateur.GetNombreMaxBaguettes(monnaie);
            Assert.AreEqual(0.0f, nbMaxBaguettes);
        }

        [TestMethod]
        public void ComparaisonPasDArgent()
        {
            float[] boulangeries = { 1.6f, 1.8f, 1.5f };
            ComparateurBoulangeries comparateur = new ComparateurBoulangeries(boulangeries);

            int positionMeilleureBoulangerie = comparateur.GetMeilleureBoulangerie();
            Assert.AreEqual(2, positionMeilleureBoulangerie);

            float monnaie = 0.0f;
            int nbMaxBaguettes = comparateur.GetNombreMaxBaguettes(monnaie);
            Assert.AreEqual(0.0f, nbMaxBaguettes);
        }

        [TestMethod]
        public void ComparaisonGratuit()
        {
            float[] boulangeries = { 0.6f, 0.8f, 0.0f };
            ComparateurBoulangeries comparateur = new ComparateurBoulangeries(boulangeries);

            int positionMeilleureBoulangerie = comparateur.GetMeilleureBoulangerie();
            Assert.AreEqual(2, positionMeilleureBoulangerie);

            float monnaie = 6.0f;
            int nbMaxBaguettes = comparateur.GetNombreMaxBaguettes(monnaie);
            Assert.AreEqual(int.MaxValue, nbMaxBaguettes);
        }

    }
}
