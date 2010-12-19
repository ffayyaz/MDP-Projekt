using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TZ_FAHRZEUGMARKETest and is intended
    ///to contain all TZ_FAHRZEUGMARKETest Unit Tests
    ///</summary>
    [TestClass()]
    public class TZ_FAHRZEUGMARKETest
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
        ///A test for TZ_FAHRZEUGMARKE Constructor
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKEConstructorTest()
        {
            TZ_FAHRZEUGMARKE fzgMarke = new TZ_FAHRZEUGMARKE();
            Assert.IsInstanceOfType(fzgMarke, typeof(TZ_FAHRZEUGMARKE));
        }

        /// <summary>
        ///A test for CreateTZ_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void CreateTZ_FAHRZEUGMARKETest()
        {
            int fZM_ID = 1;
            TZ_FAHRZEUGMARKE fzgMarke = TZ_FAHRZEUGMARKE.CreateTZ_FAHRZEUGMARKE(fZM_ID);
            Assert.IsTrue(fzgMarke.FZM_ID == fZM_ID);
        }

        /// <summary>
        ///A test for FZM_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZM_BEZEICHNUNGTest()
        {
            TZ_FAHRZEUGMARKE fzgMarke = new TZ_FAHRZEUGMARKE(); 
            string expected = "Vespa"; 
            fzgMarke.FZM_BEZEICHNUNG = expected;
            Assert.AreEqual(expected, fzgMarke.FZM_BEZEICHNUNG);
        }

        /// <summary>
        ///A test for FZM_FZT_ID
        ///</summary>
        [TestMethod()]
        public void FZM_FZT_IDTest()
        {
            TZ_FAHRZEUGMARKE fzgMarke = new TZ_FAHRZEUGMARKE(); 
            Nullable<int> expected = 1; 
            fzgMarke.FZM_FZT_ID = expected;
            Assert.AreEqual(expected, fzgMarke.FZM_FZT_ID);
        }

        /// <summary>
        ///A test for FZM_ID
        ///</summary>
        [TestMethod()]
        public void FZM_IDTest()
        {
            TZ_FAHRZEUGMARKE fzgMarke = new TZ_FAHRZEUGMARKE(); 
            int expected = 1; 
            fzgMarke.FZM_ID = expected;
            Assert.AreEqual(expected, fzgMarke.FZM_ID);
        }

        /// <summary>
        ///A test for TR_FAHRZEUGTYP
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGTYPTest()
        {
            TZ_FAHRZEUGMARKE fzgMarke = new TZ_FAHRZEUGMARKE(); 
            TR_FAHRZEUGTYP expected = new TR_FAHRZEUGTYP();
            expected.FZT_ID = 1;
            expected.FZT_BEZEICHNUNG = "Liberty";
            fzgMarke.TR_FAHRZEUGTYP = expected;
            Assert.AreEqual(expected, fzgMarke.TR_FAHRZEUGTYP);
        }

        /// <summary>
        ///A test for TR_FAHRZEUGTYPReference
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGTYPReferenceTest()
        {
            TZ_FAHRZEUGMARKE fzgMarke = new TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            EntityReference<TR_FAHRZEUGTYP> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TR_FAHRZEUGTYP> actual;
            fzgMarke.TR_FAHRZEUGTYPReference = expected;
            actual = fzgMarke.TR_FAHRZEUGTYPReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_FAHRZEUG
        ///</summary>
        [TestMethod()]
        public void T_FAHRZEUGTest()
        {
            TZ_FAHRZEUGMARKE fzgMarke = new TZ_FAHRZEUGMARKE(); // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<T_FAHRZEUG> actual;
            fzgMarke.T_FAHRZEUG = expected;
            actual = fzgMarke.T_FAHRZEUG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
