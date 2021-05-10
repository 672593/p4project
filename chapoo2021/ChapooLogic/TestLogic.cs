using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class TestLogic
    {
        TestDAO dao = new TestDAO();

        public List<TestModel> GetAllTest()
        {
            return dao.GetAllNames();
        }
    }
}