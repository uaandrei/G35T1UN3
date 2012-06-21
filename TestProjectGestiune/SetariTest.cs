using GestiuneBusiness.Poco.Administration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for SetariTest and is intended
    ///to contain all SetariTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SetariTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Save
        ///</summary>
        [TestMethod()]
        public void UpdateSetariTest()
        {
            var setare = new Setare
            {
                AdminPassword = "admin1",
                MyFirmaId = 666
            };
            if (setare.Save().Status == GestiuneBusiness.Enums.StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetSetareTest()
        {
            var setare = Setare.GetSetare();
            Assert.IsNotNull(setare);
        }

        [TestMethod]
        public void DateTimeToStringComparerTest()
        {
            var dateNow = DateTime.Now;
            var dateInPast = DateTime.Now.AddDays(-1);
            var actual = dateInPast.ToString("MM/yyyy");
            var expected = dateNow.ToString("MM/yyyy");
            Assert.AreEqual(expected, actual);
        }
    }
}
