using BusinessLogicalLayer;
using Common;
using Entities;
using Entities.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesktopApplicationTest
{
    [TestClass]
    public class SpaceTrainingTest
    {
        PersonBLL personBLL = new PersonBLL();
        SpaceTrainingBLL spaceTBLL = new SpaceTrainingBLL();

        [TestInitialize]
        public void StartTest()
        {
            Person p1 = new Person();
            p1.Name = "Pessoa";
            p1.Surname = "Ummm";
            personBLL.Insert(p1);

            Person p2 = new Person();
            p2.Name = "Pessoa";
            p2.Surname = "Doiss";
            personBLL.Insert(p2);

            Person p3 = new Person();
            p3.Name = "Pessoa";
            p3.Surname = "Trêss";
            personBLL.Insert(p3);

            Person p4 = new Person();
            p4.Name = "Pessoa";
            p4.Surname = "Quatro";
            personBLL.Insert(p4);

            Person p5 = new Person();
            p5.Name = "Pessoa";
            p5.Surname = "Cinco";
            personBLL.Insert(p5);

            Person p6 = new Person();
            p6.Name = "Pessoa";
            p6.Surname = "Seis";
            personBLL.Insert(p6);

            Person p7 = new Person();
            p7.Name = "Pessoa";
            p7.Surname = "Sete";
            personBLL.Insert(p7);

            Person p8 = new Person();
            p8.Name = "Pessoa";
            p8.Surname = "Oito";
            personBLL.Insert(p8);

            Person p9 = new Person();
            p9.Name = "Pessoa";
            p9.Surname = "Nove";
            personBLL.Insert(p9);

            Person p10 = new Person();
            p10.Name = "Pessoa";
            p10.Surname = "Dezz";
            personBLL.Insert(p10);

            Person p11 = new Person();
            p11.Name = "Pessoa";
            p11.Surname = "Onze";
            personBLL.Insert(p11);

            Person p12 = new Person();
            p12.Name = "Pessoa";
            p12.Surname = "Doze";
            personBLL.Insert(p12);

            Person p13 = new Person();
            p13.Name = "Pessoa";
            p13.Surname = "Treze";
            personBLL.Insert(p13);

            Person p14 = new Person();
            p14.Name = "Pessoa";
            p14.Surname = "Quatorze";
            personBLL.Insert(p14);

            Person p15 = new Person();
            p15.Name = "Pessoa";
            p15.Surname = "Quinze";
            personBLL.Insert(p15);

            Person p16 = new Person();
            p16.Name = "Pessoa";
            p16.Surname = "Dezesseis";
            personBLL.Insert(p16);

            Person p17 = new Person();
            p17.Name = "Pessoa";
            p17.Surname = "Dezesete";
            personBLL.Insert(p17);

            Person p18 = new Person();
            p18.Name = "Pessoa";
            p18.Surname = "Dezoito";
            personBLL.Insert(p18);

        }

        [TestMethod]
        public void TestInsert()
        {
            SpaceTraining space3 = new SpaceTraining();
            space3.Name = "Sala três";
            space3.MaxCapacity = 6;
            Response response = spaceTBLL.Insert(space3);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetAllTable()
        {
            TableResponse response = spaceTBLL.GetAllTable();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetByName()
        {
            SpaceTraining s1 = new SpaceTraining();
            s1.Name = "Sala";
            TableResponse response = spaceTBLL.GetByName(s1);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetAllList()
        {
            QueryResponse<SpaceTraining> response = spaceTBLL.GetAllList();
            Assert.AreEqual(true, response.Success);
        }

       [TestMethod]
       public void TestGetSmallerSpace()
        {
            SpaceTraining space1 = new SpaceTraining();
            space1.Name = "Sala um";
            space1.MaxCapacity = 6;
            spaceTBLL.Insert(space1);

            SpaceTraining space2 = new SpaceTraining();
            space2.Name = "Sala dois";
            space2.MaxCapacity = 6;
            spaceTBLL.Insert(space2);

            SingleResponse<SpaceTraining> response = spaceTBLL.GetSmallerSpace();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetSpaceWithEmptySeat()
        {
            int value = 4;
            QueryResponse<SpaceTraining> response = spaceTBLL.GetSpaceWithEmptySeat(value);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGet()
        {
            SpaceTraining space4 = new SpaceTraining();
            space4.Name = "Sala quatro";
            space4.MaxCapacity = 6;
            spaceTBLL.Insert(space4);
            SingleResponse<SpaceTraining> response = spaceTBLL.Get(space4);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestUpdateMaxCapacity()
        {
            SpaceTraining s2 = new SpaceTraining();
            s2.ID = 1;
            s2.MaxCapacity = 6;
            Response response = spaceTBLL.UpdateMaxCapacity(s2);
        }

        [TestMethod]
        public void TestDeleteAll()
        {
            Response response = spaceTBLL.DeleteAll();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestCheckHowToCreate()
        {
            SpaceTraining spaceT = new SpaceTraining();
            spaceT.Name = "Sala teste";
            spaceT.MaxCapacity = 6;
            spaceTBLL.Insert(spaceT);

            SingleResponse<Operator> response = spaceTBLL.CheckHowToCreate(spaceT);
            Assert.AreEqual(true, response.Success);
        }

        [TestCleanup]
        public void EndTest()
        {
            personBLL.DeleteAll();
            spaceTBLL.DeleteAll();
        }

    }
}
