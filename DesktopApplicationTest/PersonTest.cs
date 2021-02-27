using BusinessLogicalLayer;
using Common;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesktopApplicationTest
{
    [TestClass]
    public class PersonTest
    {
        PersonBLL personBLL = new PersonBLL();

        [TestInitialize]
        public void StartTest()
        {
        }

        [TestMethod]
        public void TestInsert()
        {
            Person person1 = new Person();
            person1.Name = "Janaina";
            person1.Surname = "Mai";
            Response response = personBLL.Insert(person1);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetByNameViewModel()
        {
            Person p1 = new Person();
            p1.FullName = "Janaina Mai";
            TableResponse tableResponse = personBLL.GetByNameViewModel(p1);
            Assert.AreEqual(true, tableResponse.Success);
        }

        [TestMethod]
        public void TestGetViewModel()
        {
            TableResponse tableResponse = personBLL.GetViewModel();
            Assert.AreEqual(true, tableResponse.Success);
        }

        [TestMethod]
        public void TestUpdateStage1ID()
        {
            Person p2 = new Person();
            p2.ID = 1;
            SpaceTraining spaceT1 = new SpaceTraining();
            spaceT1.ID = 1;
            Response response = personBLL.UpdateStage1ID(spaceT1, p2);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestUpdateStage2()
        {
            Person p3 = new Person();
            p3.ID = 1;
            SpaceTraining spaceT2 = new SpaceTraining();
            spaceT2.ID = 1;
            Response response = personBLL.UpdateStage2ID(spaceT2, p3);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestUpdateStage2IDInformingInt()
        {
            Person p4 = new Person();
            p4.ID = 1;
            int newID = 1;
            Response response = personBLL.UpdateStage2IDInformingInt(newID, p4);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestUpdateCoffeeID()
        {
            Person p5 = new Person();
            p5.ID = 1;
            int newID = 1;
            Response response = personBLL.UpdateCoffeeID(newID, p5);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetAllTable()
        {
            TableResponse response = personBLL.GetAllTable();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetByName()
        {
            Person p6 = new Person();
            p6.Name = "Janaina";
            TableResponse response = personBLL.GetByName(p6);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetAllByStage1IDASC()
        {
            Person person2 = new Person();
            person2.Name = "Pessoa";
            person2.Surname = "Dois";
            personBLL.Insert(person2);
            TableResponse response = personBLL.GetAllByStage1IDASC();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetAllList()
        {
            QueryResponse<Person> response = personBLL.GetAllList();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetNamesOnly()
        {
            TableResponse response = personBLL.GetNamesOnly();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetPeopleByStage1ID()
        {
            SpaceTraining spaceT3 = new SpaceTraining();
            spaceT3.ID = 1;
            QueryResponse<Person> response = personBLL.GetPeopleByStage1ID(spaceT3);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetByStage1ID()
        {
            SpaceTraining spaceT4 = new SpaceTraining();
            spaceT4.ID = 1;
            TableResponse response = personBLL.GetAllByStage1ID(spaceT4);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetByStage2ID()
        {
            SpaceTraining spaceT5 = new SpaceTraining();
            spaceT5.ID = 1;
            TableResponse response = personBLL.GetAllByStage2ID(spaceT5);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestGetByCoffeeID()
        {
            SpaceCoffee spaceC1 = new SpaceCoffee();
            spaceC1.ID = 1;
            TableResponse response = personBLL.GetAllByCoffeeID(spaceC1);
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestOrganizaFirstStage()
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

            SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();
            SpaceTraining spaceT1 = new SpaceTraining();
            spaceT1.Name = "Sala Um";
            spaceT1.MaxCapacity = 6;
            spaceBLL.Insert(spaceT1);

            SpaceTraining spaceT2 = new SpaceTraining();
            spaceT2.Name = "Sala Dois";
            spaceT2.MaxCapacity = 6;
            spaceBLL.Insert(spaceT2);

            SpaceTraining spaceT3 = new SpaceTraining();
            spaceT3.Name = "Sala Três";
            spaceT3.MaxCapacity = 6;
            spaceBLL.Insert(spaceT3);

            Response response = personBLL.OrganizeFirstStage();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestOrganizeSecondStage()
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

            SpaceTrainingBLL spaceBLL = new SpaceTrainingBLL();
            SpaceTraining spaceT1 = new SpaceTraining();
            spaceT1.Name = "Sala Um";
            spaceT1.MaxCapacity = 6;
            spaceBLL.Insert(spaceT1);

            SpaceTraining spaceT2 = new SpaceTraining();
            spaceT2.Name = "Sala Dois";
            spaceT2.MaxCapacity = 6;
            spaceBLL.Insert(spaceT2);

            SpaceTraining spaceT3 = new SpaceTraining();
            spaceT3.Name = "Sala Três";
            spaceT3.MaxCapacity = 6;
            spaceBLL.Insert(spaceT3);

            personBLL.OrganizeFirstStage();

            Response response = personBLL.OrganizeSecondStage();
            Assert.AreEqual(true, response.Success);
        }

        [TestMethod]
        public void TestOrganizeBreakTime()
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

            Response response = personBLL.OrganizeBreakTime();
            Assert.AreEqual(true, response.Success);
        }


        [TestMethod]
        public void TestDeleteAll()
        {
            Response response = personBLL.DeleteAll();
            Assert.AreEqual(true, response.Success);
        }

        [TestCleanup]
        public void EndTest()
        {
            personBLL.DeleteAll();
        }

    }
}
