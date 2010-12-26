using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TR_MATERIALTest and is intended
    ///to contain all TR_MATERIALTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TR_MATERIALTest
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
        ///A test for TR_MATERIAL Constructor
        ///</summary>
        [TestMethod()]
        public void TR_MATERIALConstructorTest()
        {
            TR_MATERIAL target = new TR_MATERIAL();
            Assert.IsInstanceOfType(target, typeof(TR_MATERIAL));
        }

        /// <summary>
        ///A test for CreateTR_MATERIAL
        ///</summary>
        [TestMethod()]
        public void CreateTR_MATERIALTest()
        {
            int mAT_ID = 1;
            TR_MATERIAL mat = TR_MATERIAL.CreateTR_MATERIAL(mAT_ID);
            Assert.IsTrue(mat.MAT_ID== mAT_ID);
        }

        /// <summary>
        ///A test for MAT_BEZEICHNUNG
        ///</summary>
        [TestMethod()]
        public void MAT_BEZEICHNUNGTest()
        {
            string bez = "Piaggio";
            TR_MATERIAL mat = TR_MATERIAL.CreateTR_MATERIAL(1);
            mat.MAT_BEZEICHNUNG = bez;
            Assert.IsTrue(mat.MAT_BEZEICHNUNG.Equals(bez));
        }

        /// <summary>
        ///A test for MAT_ID
        ///</summary>
        [TestMethod()]
        public void MAT_IDTest()
        {
            TR_MATERIAL mat = new TR_MATERIAL();
            int expected = 1;
            mat.MAT_ID = expected;
            Assert.AreEqual(expected, mat.MAT_ID);
        }

        /// <summary>
        ///A test for MAT_MARGE
        ///</summary>
        [TestMethod()]
        public void MAT_MARGETest()
        {
            TR_MATERIAL mat = new TR_MATERIAL();
            decimal expected = new Decimal(2.0);
            mat.MAT_MARGE = expected;
            Assert.AreEqual(expected, mat.MAT_MARGE);
        }

        /// <summary>
        ///A test for MAT_PREIS
        ///</summary>
        [TestMethod()]
        public void MAT_PREISTest()
        {
            TR_MATERIAL mat = new TR_MATERIAL();
            decimal expected = new Decimal(2.0);
            mat.MAT_PREIS = expected;
            Assert.AreEqual(expected, mat.MAT_PREIS);
        }

        /*
        /// <summary>
        ///A test for TZ_MATERIALLISTE
        ///</summary>
        [TestMethod()]
        public void TZ_MATERIALLISTETest()
        {
            TR_MATERIAL target = new TR_MATERIAL(); // TODO: Initialize to an appropriate value
            EntityCollection<TZ_MATERIALLISTE> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<TZ_MATERIALLISTE> actual;
            target.TZ_MATERIALLISTE = expected;
            actual = target.TZ_MATERIALLISTE;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         

        /// <summary>
        ///A test for isNew
        ///</summary>
        [TestMethod()]
        public void isNewTest()
        {
            TR_MATERIAL target = new TR_MATERIAL(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.isNew;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */
    }
}
