using JenkinsDemo;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sayJenkins_1()
        {
            TestClass testClass = new TestClass();
            string result=testClass.sayJenkins(3);
            Assert.AreEqual("Jenkins Jenkins Jenkins ", result);
        }
        [Test]
        public void Test_sayJenkins_2()
        {
            TestClass testClass = new TestClass();
            string result = testClass.sayJenkins(1);
            Assert.AreEqual("Jenkins ", result);
        }
    }
}