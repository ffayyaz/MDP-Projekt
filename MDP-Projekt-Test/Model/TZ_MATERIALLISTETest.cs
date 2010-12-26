using MDP_Projekt.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.Objects.DataClasses;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for TZ_MATERIALLISTETest and is intended
    ///to contain all TZ_MATERIALLISTETest Unit Tests
    ///</summary>
    [TestClass()]
    public class TZ_MATERIALLISTETest
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
        ///A test for TZ_MATERIALLISTE Constructor
        ///</summary>
        [TestMethod()]
        public void TZ_MATERIALLISTEConstructorTest()
        {
            TZ_MATERIALLISTE target = new TZ_MATERIALLISTE();
            Assert.IsInstanceOfType(target, typeof(TZ_MATERIALLISTE));
        }

        /// <summary>
        ///A test for CreateTZ_MATERIALLISTE
        ///</summary>
        [TestMethod()]
        public void CreateTZ_MATERIALLISTETest()
        {
            int mTL_ID = 1;
            TZ_MATERIALLISTE fzgTyp = TZ_MATERIALLISTE.CreateTZ_MATERIALLISTE(mTL_ID);
            Assert.IsTrue(fzgTyp.MTL_ID == mTL_ID);
        }

        /// <summary>
        ///A test for MTL_ID
        ///</summary>
        [TestMethod()]
        public void MTL_IDTest()
        {
            TZ_MATERIALLISTE matlist = new TZ_MATERIALLISTE();
            int expected = 1;
            matlist.MTL_ID = expected;
            Assert.AreEqual(expected, matlist.MTL_ID);
        }

        /// <summary>
        ///A test for MTL_MAT_ID
        ///</summary>
        [TestMethod()]
        public void MTL_MAT_IDTest()
        {
            TZ_MATERIALLISTE matlist = new TZ_MATERIALLISTE();
            int expected = 1;
            matlist.MTL_MAT_ID = expected;
            Assert.AreEqual(expected, matlist.MTL_MAT_ID);
        }

        /// <summary>
        ///A test for MTL_MENGE
        ///</summary>
        [TestMethod()]
        public void MTL_MENGETest()
        {
            TZ_MATERIALLISTE matlist = new TZ_MATERIALLISTE();
            decimal expected = new Decimal(2.0);
            matlist.MTL_MENGE = expected;
            Assert.AreEqual(expected, matlist.MTL_MENGE);
        }

        /// <summary>
        ///A test for TR_MATERIAL
        ///</summary>
        [TestMethod()]
        public void TR_MATERIALTest()
        {
            TZ_MATERIALLISTE matlist = new TZ_MATERIALLISTE();
            TR_MATERIAL expected = new TR_MATERIAL();
            expected.MAT_ID = 1;
            matlist.TR_MATERIAL = expected;
            Assert.AreEqual(expected, matlist.TR_MATERIAL);
        }

        /*
        /// <summary>
        ///A test for TR_MATERIALReference
        ///</summary>
        [TestMethod()]
        public void TR_MATERIALReferenceTest()
        {
            TZ_MATERIALLISTE target = new TZ_MATERIALLISTE(); // TODO: Initialize to an appropriate value
            EntityReference<TR_MATERIAL> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<TR_MATERIAL> actual;
            target.TR_MATERIALReference = expected;
            actual = target.TR_MATERIALReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for T_REPARATUR
        ///</summary>
        [TestMethod()]
        public void T_REPARATURTest()
        {
            TZ_MATERIALLISTE target = new TZ_MATERIALLISTE(); // TODO: Initialize to an appropriate value
            EntityCollection<T_REPARATUR> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<T_REPARATUR> actual;
            target.T_REPARATUR = expected;
            actual = target.T_REPARATUR;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
         */
    }
}
