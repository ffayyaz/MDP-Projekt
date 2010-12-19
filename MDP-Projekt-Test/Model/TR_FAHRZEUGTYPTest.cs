using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TR_FAHRZEUGTYPTest and is intended
    ///to contain all TR_FAHRZEUGTYPTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TR_FAHRZEUGTYPTest
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
        ///A test for TR_FAHRZEUGTYP Constructor
        ///</summary>
        [TestMethod()]
        public void TR_FAHRZEUGTYPConstructorTest()
        {
            TR_FAHRZEUGTYP fzgTyp = new TR_FAHRZEUGTYP();
            Assert.IsInstanceOfType(fzgTyp, typeof(TR_FAHRZEUGTYP));
        }

        /// <summary>
        ///A test for CreateTR_FAHRZEUGTYP
        ///</summary>
        [TestMethod()]
        public void CreateTR_FAHRZEUGTYPTest()
        {
            int fZT_ID = 1;
            string fZT_BEZEICHNUNG = "Liberty";
            TR_FAHRZEUGTYP fzgTyp = TR_FAHRZEUGTYP.CreateTR_FAHRZEUGTYP(fZT_ID, fZT_BEZEICHNUNG);
            Assert.IsTrue(fzgTyp.FZT_ID == fZT_ID && fzgTyp.FZT_BEZEICHNUNG.Equals(fZT_BEZEICHNUNG));
        }

        /// <summary>
        ///A test for FZT_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZT_BEZEICHNUNGTest()
        {
            TR_FAHRZEUGTYP fzgTyp = new TR_FAHRZEUGTYP();
            string expected = "Liberty"; 
            fzgTyp.FZT_BEZEICHNUNG = expected;
            Assert.AreEqual(expected, fzgTyp.FZT_BEZEICHNUNG);
        }

        /// <summary>
        ///A test for FZT_ID
        ///</summary>
        [TestMethod()]
        public void FZT_IDTest()
        {
            TR_FAHRZEUGTYP fzgTyp = new TR_FAHRZEUGTYP(); 
            int expected = 1; 
            fzgTyp.FZT_ID = expected;
            Assert.AreEqual(expected, fzgTyp.FZT_ID);
        }

        /// <summary>
        ///A test for TZ_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKETest()
        {
            TR_FAHRZEUGTYP fzgTyp = new TR_FAHRZEUGTYP(); // TODO: Initialize to an appropriate value
            EntityCollection<TZ_FAHRZEUGMARKE> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<TZ_FAHRZEUGMARKE> actual;
            fzgTyp.TZ_FAHRZEUGMARKE = expected;
            actual = fzgTyp.TZ_FAHRZEUGMARKE;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
