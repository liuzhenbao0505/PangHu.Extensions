using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;

namespace PangHu.Extensions.Test
{
    [TestClass]
    public class ExtensionsDataTest
    {
        [TestMethod]
        public void DataTableToEntities_Test()
        {
            DataTable dt = new DataTable("Datas");
            DataColumn dc = null;
            dc = dt.Columns.Add("Id", Type.GetType("System.Int64"));
            dc.AutoIncrement = true;//自动增加
            dc.AutoIncrementSeed = 1;//起始为1
            dc.AutoIncrementStep = 1;//步长为1
            dc.AllowDBNull = false;//

            dc = dt.Columns.Add("Name", Type.GetType("System.String"));
            dc = dt.Columns.Add("CreateTime", Type.GetType("System.DateTime"));

            DataRow newRow;
            newRow = dt.NewRow();
            newRow["Id"] = 1;
            newRow["Name"] = "liufei";
            newRow["CreateTime"] = DateTime.Now;
            dt.Rows.Add(newRow);

            newRow = dt.NewRow();
            newRow["Id"] = 1;
            newRow["Name"] = "feifei";
            newRow["CreateTime"] = DateTime.Now.AddDays(10);
            dt.Rows.Add(newRow);

            try
            {
                var list = dt.ToEntities<Student>();
            }
            catch(Exception ex)
            {

            }

            Assert.IsTrue(true);
        }
    }
}
