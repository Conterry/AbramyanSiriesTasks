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
    }
}
