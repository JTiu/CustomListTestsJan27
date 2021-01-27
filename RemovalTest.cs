using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CustomListAndTDD;


namespace CustomListTDD
{
    [TestClass]
    class RemovalTest

    {
        [TestMethod]
        public void CustomList_CheckC_Sharp_RemoveMethodCheckCount()

        {
            //Arrange variables to test count
            CustomList <string>list = new CustomList<string>();
            string name1 = "Packers";
            string name2 = "Browns";
            string name3 = "SeaHawks";
            int expected = 2;
            int actual;

            //Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Remove(name1);
            actual = list.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void CustomList_CheckC_Sharp_RemoveMethodCheckIndex_atThree()
        {
            //Arrange variables to test index
            CustomList<string> list = new CustomList<string>();
            string name1 = "Able";
            string name2 = "Brown";
            string name3 = "Candy";
            string name4 = "Dingo";
            string name5 = "Elly";

            string expected = "Elly";
            string actual; = list[3];

            //Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Add(name4);
            list.Add(name5);
            list.Remove(name1);
            actual = list.[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckC_Sharp_RemoveTwoItemsMethodCheckCount()

        {
            //Arrange variables to test count
            CustomList<string> list = new CustomList<string>();
            string name1 = "Packers";
            string name2 = "Browns";
            string name3 = "SeaHawks";
            string name4 = "Lions";
            string name5 = "Bears";
            int expected = 3;
            int actual;

            //Act
            list.Add(name1);
            list.Add(name2);
            list.Add(name3);
            list.Add(name4);
            list.Add(name5);
            list.Remove(name1);
            list.Remove(name2);

            actual = list.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void CustomList_RemoveIntegersCheckCount()

        {
            //Arrange variables to test count
            CustomList<int> list = new CustomList<int>();
            int x = 1;
            int y = 2;
            int z = 3;
            int expected = 2;
            int actual;

            //Act
            list.Add(x);
            list.Add(y);
            list.Add(z);
            list.Remove(x);
            actual = list.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void CustomList_RemoveTwoIntegersCheckIndex()

        {
            //Arrange variables to test index
            CustomList<int> list = new CustomList<int>();
            int v = 1;
            int w = 2;
            int x = 3;
            int y = 4;
            int z = 5;
            int expected = 5;
            int actual;

            //Act
            list.Add(v);
            list.Add(w);
            list.Add(x);
            list.Add(y);
            list.Add(z);
            list.Remove(x);
            list.Remove(y);
            actual = list.[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
