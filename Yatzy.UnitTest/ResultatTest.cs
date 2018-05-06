using System;
using NUnit.Framework;
using WindowsFormsApp1;
using static WindowsFormsApp1.YatzyKategoriBeregner;

namespace Yatzy.UnitTest
{
    [TestFixture]
    public class ResultatTest
    {

        YatzyKategoriBeregner _yatzyKategoriBeregner;

        [OneTimeSetUp]
        public void OnStart() {
            _yatzyKategoriBeregner = new YatzyKategoriBeregner();
        }

        [Test]
        [TestCase(Kategori.Enere, new string[] {"1","2","3","4","5"},1)]
        [TestCase(Kategori.Toere, new string[] { "1", "2", "3", "4", "5" }, 2)]
        [TestCase(Kategori.Treere, new string[] { "1", "2", "3", "4", "5" }, 3)]
        [TestCase(Kategori.Firere, new string[] { "1", "2", "3", "4", "5" }, 4)]
        [TestCase(Kategori.Femmere, new string[] { "1", "2", "3", "4", "5" }, 5)]
        [TestCase(Kategori.Seksere, new string[] {  "2", "3", "4", "5","6" }, 6)]
        [TestCase(Kategori.Seksere, new string[] { "2", "3", "4", "5", "1" }, 0)]

        public void GetPoengSummeringsTest(Kategori kategori, string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.GetPoeng(kategori, kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "1", "2", "3", "4", "5" }, 0)]
        [TestCase(new string[] { "1", "1", "3", "6", "6" }, 12)]
        public void ParSummeringsTest(string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getPar(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "1", "2", "3", "4", "5" }, 0)]
        [TestCase(new string[] { "1", "1", "3", "6", "6" }, 14)]
        [TestCase(new string[] { "1", "1", "1", "1", "5" }, 0)]
        public void ToParSummeringsTest( string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getToPar(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "1", "2", "3", "4", "5" }, 0)]
        [TestCase(new string[] { "1", "1", "1", "6", "6" }, 3)]
        [TestCase(new string[] { "2", "2", "2", "2", "5" }, 6)]
       
        public void TreLikeSummeringsTest( string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getTreLike(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "1", "1", "1", "6", "6" }, 0)]
        [TestCase(new string[] { "2", "2", "2", "2", "5" }, 8)]
        [TestCase(new string[] { "2", "2", "2", "2", "2" }, 8)]
        public void FireLikeSummeringsTest(string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getFireLike(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "1", "2", "3", "4", "5" }, 15)]
        [TestCase(new string[] { "2", "3", "4", "5", "6" }, 0)]
        [TestCase(new string[] { "2", "2", "2", "2", "5" }, 0)]
        public void LitenStraightSummeringsTest(string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getLitenStraight(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "1", "2", "3", "4", "5" }, 0)]
        [TestCase(new string[] { "2", "3", "4", "5", "6" }, 20)]
        [TestCase(new string[] { "2", "2", "2", "2", "5" }, 0)]
        public void StorStraightSummeringsTest(string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getStorStraight(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "3", "3", "3", "5", "5" }, 19)]
        [TestCase(new string[] { "2", "3", "4", "5", "6" }, 0)]
        public void FulltHusSummeringsTest(string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getFulltHus(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "1", "2", "3", "4", "5" }, 15)]
        [TestCase(new string[] { "2", "3", "4", "5", "6" }, 20)]
        [TestCase(new string[] { "2", "2", "2", "2", "5" }, 13)]
        public void SjenseSummeringsTest(string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getSjanse(kast);
            Assert.AreEqual(expected, sum);
        }

        [Test]
        [TestCase(new string[] { "2", "2", "2", "2", "6" }, 0)]
        [TestCase(new string[] { "2", "2", "2", "2", "2" }, 50)]
        public void YatzyBeregningTest(string[] kast, int expected)
        {
            var sum = _yatzyKategoriBeregner.getYatzy(kast);
            Assert.AreEqual(expected, sum);
        }





    }
}
