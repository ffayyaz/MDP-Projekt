using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

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
            TR_FAHRZEUGART fzgArt = new TR_FAHRZEUGART();
            Assert.IsInstanceOfType(fzgArt, typeof(TR_FAHRZEUGART));
        }

        /// <summary>
        ///A test for CreateTR_FAHRZEUGART
        ///</summary>
        [TestMethod()]
        public void CreateTR_FAHRZEUGARTTest()
        {
            int fZA_ID = 1; 
            string fZA_BEZEICHNUNG = "Roller"; 
            string fZA_KEY = "ROL"; 
            TR_FAHRZEUGART fzgArt = TR_FAHRZEUGART.CreateTR_FAHRZEUGART(fZA_ID, fZA_BEZEICHNUNG, fZA_KEY);
            Assert.IsTrue(fzgArt.FZA_ID == fZA_ID && fzgArt.FZA_BEZEICHNUNG.Equals(fZA_BEZEICHNUNG) && fzgArt.FZA_KEY.Equals(fZA_KEY));
        }

        /// <summary>
        ///A test for FZA_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZA_BEZEICHNUNGTest()
        {
            TR_FAHRZEUGART fzgArt = new TR_FAHRZEUGART(); 
            string expected = "Roller"; 
            fzgArt.FZA_BEZEICHNUNG = expected;
            Assert.AreEqual(expected, fzgArt.FZA_BEZEICHNUNG);
        }

        /// <summary>
        ///A test for FZA_ID
        ///</summary>
        [TestMethod()]
        public void FZA_IDTest()
        {
            TR_FAHRZEUGART fzgArt = new TR_FAHRZEUGART();
            int expected = 1; 
            fzgArt.FZA_ID = expected;
            Assert.AreEqual(expected, fzgArt.FZA_ID);
        }

        /// <summary>
        ///A test for FZA_KEY
        ///</summary>
        [TestMethod()]
        public void FZA_KEYTest()
        {
            TR_FAHRZEUGART fzgArt = new TR_FAHRZEUGART(); 
            string expected = "ROL"; 
            fzgArt.FZA_KEY = expected;
            Assert.AreEqual(expected, fzgArt.FZA_KEY);
        }

        /// <summary>
        ///A test for T_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGTest()
        {
            TR_FAHRZEUGART fzgArt = new TR_FAHRZEUGART(); // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> actual;
            fzgArt.T_FAHRZEUG = expected;
            actual = fzgArt.T_FAHRZEUG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
