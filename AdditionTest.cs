using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomListAndTDD;
using System.Collections.Generic;

namespace CustomListTDD
{
    [TestClass]
    public class AdditionTest
    {
        //}

        [TestMethod]
        public void Add_ThreePostiveIntegers_Count3()
        {
            //Arrange variables to test method
            CustomList<int> AdditionList = new CustomList<int>();
            int expected = 3;
            int actual;
            int x = 1;
            int y = 2;
            int z = 3;
            
            //act
            AdditionList.Add(x);
            AdditionList.Add(y);
            AdditionList.Add(z);
            actual = AdditionList.Count();


            //assert
            Assert.AreEqual(expected, actual);
        }

        //change this to add five integers, Count 5

        [TestMethod]
        public void Add_FivePostiveIntegers_Count5()
        {
            // Arrange variables to test method
            CustomListList<int> AdditionList = new CustomList<int>();
            int expected = 5;
            int actual;
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            

            //act
            AdditionList.Add(a);
            AdditionList.Add(b);
            AdditionList.Add(c);
            AdditionList.Add(d);
            AdditionList.Add(e);

            actual = AdditionList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void CustomListAdd_ThreeStrings_Count3()
        {
            //Arrange variables to test method
            CustomList<string> AdditionList = new CustomList<string>();
            string expected = 3;
            string actual;
            string x = "Robot";
            string y = "Dinosaur";
            string z = "BattleShip";

            //act
            AdditionList.Add(x);
            AdditionList.Add(y);
            AdditionList.Add(z);
            actual = AdditionList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_FiveItems_CheckForItemAtIndex3()
        {
            //Arrange variables to test method
            CustomList<string> AdditionList = new CustomList<string>();
            string Signal1 = "Alpha";
            string Signal2 = "Bravo";
            string Signal3 = "Charlie";
            string Signal4 = "Delta";
            string Signal5 = "Echo";

            string expected = "Delta";
            string actual = AdditionList[3];
            

            //act
            AdditionList.Add(Signal1);
            AdditionList.Add(Signal2);
            AdditionList.Add(Signal3);
            AdditionList.Add(Signal4);
            AdditionList.Add(Signal5);

        
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_TenItems_CheckForItemAtIndex9()
        {
            //Arrange variables to test method
            CustomList<string> AdditionList = new CustomList<string>();
            string CallSign1 = "Allen";
            string CallSign2 = "Barbara";
            string CallSign3 = "Chuck";
            string CallSign4 = "Dan";
            string CallSign5 = "Eddy";
            string CallSign6 = "Franco";
            string CallSign7 = "Gary";
            string CallSign8 = "Helen";
            string CallSign9 = "Issac";
            string CallSign10 = "Jenny";

            string expected = "Jenny";
            string actual = AdditionList[9];

            //act
            AdditionList.Add(CallSign1);
            AdditionList.Add(CallSign2;
            AdditionList.Add(CallSign3);
            AdditionList.Add(CallSign4);
            AdditionList.Add(CallSign4);
            AdditionList.Add(CallSign5);
            AdditionList.Add(CallSign6);
            AdditionList.Add(CallSign7);
            AdditionList.Add(CallSign8);
            AdditionList.Add(CallSign9);
            AdditionList.Add(CallSign10);



            //assert
            Assert.AreEqual(expected, actual);
        }



    }
}
