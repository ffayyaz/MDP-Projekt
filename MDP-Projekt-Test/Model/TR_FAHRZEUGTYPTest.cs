using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            MDP_Projekt.Model.TR_FAHRZEUGTYP target = new MDP_Projekt.Model.TR_FAHRZEUGTYP();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateTR_FAHRZEUGTYP
        ///</summary>
        [TestMethod()]
        public void CreateTR_FAHRZEUGTYPTest()
        {
            int fZT_ID = 0; // TODO: Initialize to an appropriate value
            string fZT_BEZEICHNUNG = string.Empty; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGTYP expected = null; // TODO: Initialize to an appropriate value
            MDP_Projekt.Model.TR_FAHRZEUGTYP actual;
            actual = MDP_Projekt.Model.TR_FAHRZEUGTYP.CreateTR_FAHRZEUGTYP(fZT_ID, fZT_BEZEICHNUNG);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZT_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void FZT_BEZEICHNUNGTest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGTYP target = new MDP_Projekt.Model.TR_FAHRZEUGTYP(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FZT_BEZEICHNUNG = expected;
            actual = target.FZT_BEZEICHNUNG;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FZT_ID
        ///</summary>
        [TestMethod()]
        public void FZT_IDTest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGTYP target = new MDP_Projekt.Model.TR_FAHRZEUGTYP(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.FZT_ID = expected;
            actual = target.FZT_ID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TZ_FAHRZEUGMARKE
        ///</summary>
        [TestMethod()]
        public void TZ_FAHRZEUGMARKETest()
        {
            MDP_Projekt.Model.TR_FAHRZEUGTYP target = new MDP_Projekt.Model.TR_FAHRZEUGTYP(); // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityCollection<MDP_Projekt.Model.TZ_FAHRZEUGMARKE> expected = null; // TODO: Initialize to an appropriate value
            System.Data.Objects.DataClasses.EntityCollection<MDP_Projekt.Model.TZ_FAHRZEUGMARKE> actual;
            target.TZ_FAHRZEUGMARKE = expected;
            actual = target.TZ_FAHRZEUGMARKE;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
