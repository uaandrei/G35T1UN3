using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestiuneBusiness.DataHelper.Kernel;
using GestiuneBusiness.Enums;

namespace TestProjectGestiune
{
    
    
    /// <summary>
    ///This is a test class for PlataFacturaTest and is intended
    ///to contain all PlataFacturaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PlataFacturaTest
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
            var target = new PlataFactura
            {
                IdPlata = 2,
                IdFactura = 1,
                TipFactura="Iesire"
            };
            var r = target.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void UpdatePlataFacturaTest()
        {
            var target = new PlataFactura
            {
                IdPlata = 1,
                IdFactura = 4,
                TipFactura="Iesire",
                ID = 3
            };
            var r = target.Save();
            if (r.Status == StatusEnum.Errors)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void GetAllPlataFacturaTest()
        {
            var target = PlataFactura.GetAll();
            if (target == null)
            {
                Assert.Fail();
            }
        }
    }
}
