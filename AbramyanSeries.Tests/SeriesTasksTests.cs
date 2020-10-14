using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbramyanSeries.Tests
{
    [TestClass]
    public class SeriesTasksTests
    {
        [TestMethod]
        public void Series1_1234567891_46()
        {

            double[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            double expected = 46;

            SeriesTasks c = new SeriesTasks();
            double actual = c.Series1(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Series3_1234567891_4dot6()
        {
            double[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            double expected = 4.6;

            SeriesTasks c = new SeriesTasks();
            double actual = c.Series3(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Series15_MasAAnd2_4()
        {
            int[] a = { 1, 2, -3, 4, 5, -7, 0 };
            int k = 5;
            int expected = 0;

            SeriesTasks c = new SeriesTasks();
            double actual = c.Series15(a, k);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Series21_NandMasA_4()
        {
            int n = 4;
            double[] a = { 1.2, 2.3, 3.4, 5.4 };
            bool expected = false;

            SeriesTasks c = new SeriesTasks();
            bool actual = c.Series21(n, a);

            Assert.AreEqual(expected, actual);
        }
    }
}
