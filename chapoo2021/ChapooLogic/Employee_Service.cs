﻿using System;
using ChapooDAL;
using ChapooModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Employee_Service
    {
        Employee_DAO Employee_DAO = new Employee_DAO();

        public Employee GetWorkerLogin(string username, string password)
        {
            return Employee_DAO.GetWorkerLogin(username, password);
        }


    }
    
}