using MDP_Projekt.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MDP_Projekt_Test
{
    
    
    /// <summary>
    ///This is a test class for FahrzeugDatenUIFahrzeugDatenUI and is intended
    ///to contain all FahrzeugDatenUIFahrzeugDatenUI Unit Tests
    ///</summary>
    [TestClass()]
    public class FahrzeugDatenUITest
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

        /*
        /// <summary>
        ///A test for NutzerDatenUI Constructor
        ///</summary>
        [TestMethod()]
        public void FahrzeugDatenUIConstructorTest()
        {
            MDP_Projekt.UI.FahrzeugDatenUI target = new MDP_Projekt.UI.FahrzeugDatenUI();
            Assert.IsInstanceOfType(target, typeof(FahrzeugDatenUI));
        }

        /// <summary>
        ///A test for getFahrzeuge
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MDP-Projekt.exe")]
        public void getFahrzeugeTest()
        {
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target1 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target2 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            System.Collections.Generic.List<MDP_Projekt.Model.T_FAHRZEUG> expected;
            System.Collections.Generic.List<MDP_Projekt.Model.T_FAHRZEUG> actual;
            actual = target1.getFahrzeuge();
            expected = target2.getFahrzeuge();
            
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(target1, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsInstanceOfType(target2, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsTrue(actual.Capacity > 0);
            Assert.IsTrue(actual.Capacity == expected.Capacity);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getFahrzeugarten
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MDP-Projekt.exe")]
        public void getFahrzeugartenTest()
        {
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target1 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target2 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor(); 
            System.Collections.Generic.List<MDP_Projekt.Model.TR_FAHRZEUGART> expected;
            System.Collections.Generic.List<MDP_Projekt.Model.TR_FAHRZEUGART> actual;
            actual = target1.getFahrzeugarten();
            expected = target2.getFahrzeugarten();
            
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(target1, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsInstanceOfType(target2, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsTrue(actual.Capacity > 0);
            Assert.IsTrue(actual.Capacity == expected.Capacity);
            Assert.AreEqual(expected, actual);            
        }

        /// <summary>
        ///A test for getFahrzeugmarkeCombo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MDP-Projekt.exe")]
        public void getFahrzeugmarkeComboTest()
        {
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target1 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target2 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor(); 
            System.Collections.Generic.List<MDP_Projekt.Model.TR_FAHRZEUGMARKE> expected;
            System.Collections.Generic.List<MDP_Projekt.Model.TR_FAHRZEUGMARKE> actual;
            actual = target1.getFahrzeugmarkeCombo();
            expected = target2.getFahrzeugmarkeCombo();
            
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(target1, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsInstanceOfType(target2, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsTrue(actual.Capacity > 0);
            Assert.IsTrue(actual.Capacity == expected.Capacity);
            Assert.AreEqual(expected, actual);
        }

        
        /// <summary>
        ///A test for getFahrzeugtypCombo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MDP-Projekt.exe")]
        public void getFahrzeugtypComboTest()
        {
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target1 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target2 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            System.Collections.Generic.List<MDP_Projekt.Model.TZ_FAHRZEUGTYP> expected;
            System.Collections.Generic.List<MDP_Projekt.Model.TZ_FAHRZEUGTYP> actual;
            actual = target1.getFahrzeugtypCombo();
            expected = target2.getFahrzeugtypCombo();
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(target1, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsInstanceOfType(target2, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsTrue(actual.Capacity > 0);
            Assert.IsTrue(actual.Capacity == expected.Capacity);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for getFahrzeugtypCombo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MDP-Projekt.exe")]
        public void getFahrzeugnutzerComboTest()
        {
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target1 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            MDP_Projekt.UI.FahrzeugDatenUI_Accessor target2 = new MDP_Projekt.UI.FahrzeugDatenUI_Accessor();
            System.Collections.Generic.List<MDP_Projekt.Model.T_NUTZER> expected;
            System.Collections.Generic.List<MDP_Projekt.Model.T_NUTZER> actual;
            actual = target1.getFahrzeugnutzerCombo();
            expected = target2.getFahrzeugnutzerCombo();
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(target1, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsInstanceOfType(target2, typeof(FahrzeugDatenUI_Accessor));
            Assert.IsTrue(actual.Capacity > 0);
            Assert.IsTrue(actual.Capacity == expected.Capacity);
            Assert.AreEqual(expected, actual);
        }
         */
    }
}
