using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TR_FAHRZEUGMARKETest and is intended
    ///to contain all TR_FAHRZEUGMARKETest Unit Tests
    ///</summary>
    [TestClass()]
    public class TR_FAHRZEUGMARKETest
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
        ///A test for TR_FAHRZEUGMARKE Constructor
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGMARKEConstructorTest()
        {
            TR_FAHRZEUGMARKE target = new TR_FAHRZEUGMARKE();
            Assert.IsInstanceOfType(target, typeof(TR_FAHRZEUGMARKE));
        }

        /// <summary>
        ///A test for CreateTR_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void CreateTR_FAHRZEUGMARKETest()
        {
            int fZM_ID = 1;
            string fZM_Bezeichnung = "Piaggio";
            TR_FAHRZEUGMARKE fzgMarke = TR_FAHRZEUGMARKE.CreateTR_FAHRZEUGMARKE(fZM_ID,fZM_Bezeichnung);
            Assert.IsTrue(fzgMarke.FZM_BEZEICHNUNG.Equals(fZM_Bezeichnung) && fzgMarke.FZM_ID == fZM_ID);
        }

        /// <summary>
        ///A test for FZM_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZM_BEZEICHNUNGTest()
        {
            TR_FAHRZEUGMARKE fzgMarke = new TR_FAHRZEUGMARKE();
            string expected = "Vespa";
            fzgMarke.FZM_BEZEICHNUNG = expected;
            Assert.AreEqual(expected, fzgMarke.FZM_BEZEICHNUNG);
        }

        /// <summary>
        ///A test for FZM_ID
        ///</summary>
        [TestMethod()]
        public void FZM_IDTest()
        {
            TR_FAHRZEUGMARKE fzgMarke = new TR_FAHRZEUGMARKE();
            int expected = 1;
            fzgMarke.FZM_ID = expected;
            Assert.AreEqual(expected, fzgMarke.FZM_ID);
        }

        /*
        /// <summary>
        ///A test for isNew
        ///</summary>
        [TestMethod()]
        public void isNewTest()
        {
            TR_FAHRZEUGMARKE target = new TR_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isNew;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */
    }
}
