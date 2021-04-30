using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ChapooDAL
{
    public class TestDAO : Base
    {
        public List<TestModel> GetAllNames()
        {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDataTable(ExecuteSelectQuery("GetAllTest", sqlParameters));
        }
        public List<TestModel> ReadDataTable(DataTable dt)
        {
            List<TestModel> modelList = new List<TestModel>();
            foreach (DataRow item in dt.Rows)
            {
                TestModel model = new TestModel();
                model.Id = (int)item["id"];
                model.Name = (string)item["name"];
                modelList.Add(model);
            }
            return modelList;
        }
    }
}