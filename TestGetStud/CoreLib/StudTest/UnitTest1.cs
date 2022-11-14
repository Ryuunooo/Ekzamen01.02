using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CoreLib;
using static CoreLib.utils;

namespace StudTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod()
        {
            //Arrange
            Students students1 = new Students();
            Students students2 = new Students();
            Students students3 = new Students();
            students1.group = 195;
            students1.year = 2021;
            students1.fio = "Gashev Vyacheslav Ivanovich";
            students2.fio = "Veselkov Adam Magomedenovich";
            students3.fio = "Alibekov Mustafa Magomedenovich";
            string GetStudN = "2022_195_Gashev V.I.";
            //Act
            string a = GetStudNumber(2022, 195, students1.fio);
            //Assert
            Assert.AreEqual(GetStudN, a);
        }
    }
}
