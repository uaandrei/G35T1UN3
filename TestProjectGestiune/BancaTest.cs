﻿using GestiuneBusiness.Poco;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using GestiuneBusiness.DataHelper.Kernel;
using System.Collections.Generic;

namespace TestProjectGestiune
{


    /// <summary>
    ///This is a test class for BancaTest and is intended
    ///to contain all BancaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BancaTest
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

        [TestMethod]
        public void GetErrorsBancaTest()
        {
            var banca = new Banca();
            banca.Adresa = "x";
            banca.Nume= "x";
            banca.RC= "x";
            var errors = banca.GetErrorString();
            Assert.IsNotNull(errors);
        }
    }
}
