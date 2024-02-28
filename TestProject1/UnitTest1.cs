using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstTask1()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3};
            string actual = prog.Task1(test);
            string expected = "1,2,fizz";

            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestFirstTask2()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3, 4, 5 };
            string actual = prog.Task1(test);
            string expected = "1,2,fizz,4,buzz";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFirstTask3()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            string actual = prog.Task1(test);
            string expected = "1,2,fizz,4,buzz,fizz,7,8,fizz,buzz,11,fizz,13,14,fizz-buzz";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSecondTask1()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3 };
            string actual = prog.Task2(test);
            string expected = "1,2,fizz";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSecondTask2()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3, 4, 5 };
            string actual = prog.Task2(test);
            string expected = "1,2,fizz,muzz,buzz";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSecondTask3()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            string actual = prog.Task2(test);
            string expected = "1,2,fizz,muzz,buzz,fizz,guzz,muzz,fizz,buzz,11,fizz-muzz,13,guzz,fizz-buzz,fizz-buzz-muzz,fizz-buzz-guzz,fizz-buzz-muzz-guzz";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestThirdTask1()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3 };
            string actual = prog.Task3(test);
            string expected = "1,2,dog";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestThirdTask2()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3, 4, 5 };
            string actual = prog.Task3(test);
            string expected = "1,2,dog,muzz,cat";

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestThirdTask3()
        {
            Program prog = new Program();

            int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            string actual = prog.Task3(test);
            string expected = "1,2,dog,muzz,cat,dog,guzz,muzz,dog,cat,11,fizz-muzz,13,guzz,good-boy,good-boy-muzz,good-boy-guzz,good-boy-muzz-guzz";

            Assert.AreEqual(expected, actual);
        }

    }
}
