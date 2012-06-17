using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Enums;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for PlataTest and is intended
    ///to contain all PlataTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlataTest
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
        public void InsertPlataTest()
        {
            var target = new Plata
            {
                Data = DateTime.Now,
                Numar = "Testing",
                Serie = "Testing",
                Suma = 123.312m,
                TipPlata = "Testing"
            };
            var r = target.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void UpdatePlataTest()
        {
            var target = new Plata
            {
                Data = DateTime.Now,
                Numar = "Modificat",
                Serie = "Testing",
                Suma = 123.3m,
                TipPlata = "Modificat",
                ID = 1
            };
            var r = target.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetAllPlataTest()
        {
            var target = Plata.GetAll();
            if (target==null)
            {
                Assert.Fail();
            }
        }
    }
}
