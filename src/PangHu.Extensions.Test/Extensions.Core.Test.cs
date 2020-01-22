using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using System.Collections.Generic;

namespace PangHu.Extensions.Test
{
    [TestClass]
    public class ExtensionsCoreTest
    {
        [TestMethod]
        public void DateTimeIsBetween_Test()
        {
            DateTime time = DateTime.Now;
            DateTime startTime = time.AddDays(-5);
            DateTime endTime = time.AddDays(5);

            bool result = time.IsBetween(startTime, endTime);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ModelToFields_Test()
        {
            var student = new Student()
            {
                Id= 1,
                Name = "liufei",
                CreateTime = DateTime.Now
            };
            var fields = student.ToFields();

            List<Student> list = new List<Student>();
            list.Add(student);

            fields = list.ToFields();

            Assert.IsTrue(fields.Count > 0);
        }

        [TestMethod]
        public void StringSerieral_Test()
        {
            var student1 = new Student()
            {
                Id = 1,
                Name = "liufei",
                CreateTime = DateTime.Now
            };

            var student2 = new Student()
            {
                Id = 1,
                Name = "liufei",
                CreateTime = DateTime.Now
            };

            var list = new List<Student>();
            list.Add(student1, student2);

            string json = list.TrySerialize();

            var obj = json.TryDeserialize<List<Student>>();
        }
    }

    class Student
    {
        private int age = 0;
        protected int sex = 1;
        public string address = "";

        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
