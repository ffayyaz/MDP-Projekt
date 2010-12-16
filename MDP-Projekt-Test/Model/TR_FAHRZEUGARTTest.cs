using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TR_FAHRZEUGARTTest and is intended
    ///to contain all TR_FAHRZEUGARTTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TR_FAHRZEUGARTTest
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
        ///A test for TR_FAHRZEUGART Constructor
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGARTConstructorTest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGART target = new MDP_Projekt.Model.TR_FAHRZEUGART();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateTR_FAHRZEUGART
        ///</summary>
        [TestMethod()]
        public void CreateTR_FAHRZEUGARTTest()
        {
            int fZA_ID = 0; // TODO: Initialize to an appropriate value
            string fZA_BEZEICHNUNG = string.Empty; // TODO: Initialize to an appropriate value
            string fZA_KEY = string.Empty; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGART expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGART actual;
            actual = MDP_Projekt.Model.TR_FAHRZEUGART.CreateTR_FAHRZEUGART(fZA_ID, fZA_BEZEICHNUNG, fZA_KEY);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZA_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZA_BEZEICHNUNGTest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGART target = new MDP_Projekt.Model.TR_FAHRZEUGART(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZA_BEZEICHNUNG = expected;
            actual = target.FZA_BEZEICHNUNG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZA_ID
        ///</summary>
        [TestMethod()]
        public void FZA_IDTest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGART target = new MDP_Projekt.Model.TR_FAHRZEUGART(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.FZA_ID = expected;
            actual = target.FZA_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZA_KEY
        ///</summary>
        [TestMethod()]
        public void FZA_KEYTest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGART target = new MDP_Projekt.Model.TR_FAHRZEUGART(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZA_KEY = expected;
            actual = target.FZA_KEY;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGTest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGART target = new MDP_Projekt.Model.TR_FAHRZEUGART(); // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityCollection<MDP_Projekt.Model.T_FAHRZEUG> expected = null; // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityCollection<MDP_Projekt.Model.T_FAHRZEUG> actual;
            target.T_FAHRZEUG = expected;
            actual = target.T_FAHRZEUG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
