using BusinessLogicalLayer;
using Common;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesktopApplicationTest
{
    [TestClass]
    public class SpaceCoffeeTest
    {
        SpaceCoffeeBLL spaceCBLL = new SpaceCoffeeBLL();

        [TestInitialize]
        public void StartTest()
        {

        }

        [TestMethod]
        public void TestInsert()
        {
            SpaceCoffee spaceC1 = new SpaceCoffee();
            spaceC1.Name = "Sala um";
            Response response = spaceCBLL.Insert(spaceC1);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetAllTable()
        {
            TableResponse response = spaceCBLL.GetAllTable();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetByName()
        {
            SpaceCoffee spaceC2 = new SpaceCoffee();
            spaceC2.Name = "Sala";
            TableResponse response = spaceCBLL.GetByName(spaceC2);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetAllList()
        {
            QueryResponse<SpaceCoffee> response = spaceCBLL.GetAllList();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGet()
        {
            SpaceCoffee spaceC2 = new SpaceCoffee();
            spaceC2.Name = "Sala dois";
            spaceCBLL.Insert(spaceC2);
            SingleResponse<SpaceCoffee> response = spaceCBLL.Get(spaceC2);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestExistTwoSpaces()
        {
            SpaceCoffee spaceC3 = new SpaceCoffee();
            spaceC3.Name = "Sala três";
            spaceCBLL.Insert(spaceC3);

            SpaceCoffee spaceC4 = new SpaceCoffee();
            spaceC4.Name = "Sala quatro";
            spaceCBLL.Insert(spaceC4);

            Response response = spaceCBLL.ExistTwoSpaces();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestDeleteAll()
        {
            Response response = spaceCBLL.DeleteAll();
            Assert.AreEqual(true, response.Success);
        }

        [TestCleanup]
        public void EndTest()
        {
            spaceCBLL.DeleteAll();
        }

    }
}
