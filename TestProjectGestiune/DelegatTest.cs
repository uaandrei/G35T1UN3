using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Enums;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for DelegatTest and is intended
    ///to contain all DelegatTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DelegatTest
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
        public void InsertDelegatTest()
        {
            var x = new Delegat
            {
                Cnp = "12912912939",
                Nume = "Mihai",
                Serie = "123123"
            };
            var r = x.Save();
            if (r.Status != StatusEnum.Errors)
                Assert.Fail();
        }

        [TestMethod()]
        public void UpdateDelegatTest()
        {
            var x = new Delegat
            {
                Cnp = "Modificat",
                Nume = "Mihai Modificat",
                Serie = "Modificat",
                ID = 11
            };
            var r = x.Save();
            if (r.Status == StatusEnum.Errors)
                Assert.Fail();
        }

        [TestMethod]
        public void GetAllDelegatiTest()
        {
            var x = Delegat.GetAll();
            if (x == null)
                Assert.Fail();
        }
    }
}
