using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ChapooModel;

namespace ChapooDAL
{
    public class User_DAO : Base
    {
        //GetAllUsers
        public List<User> GetAllUsers()
        {
            List<User> userList = new List<User>();

            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable datatable = ExecuteSelectQuery("GetAllUsers", sqlParameters);

            foreach (DataRow dr in datatable.Rows)
            {
                User user = new User();
                user.Id = (int)dr["employeeId"];
                user.Name = (string)dr["employeeName"];
                user.EmployeeCode = dr["employeeCode"].ToString();
                user.FunctionId = (int)dr["functionId"];
                user.FunctionName = (string)dr["functionName"];
                user.SecretQuestion = (string)dr["secretQuestion"];
                user.SecretAnswer = (string)dr["secretAnswer"];

                userList.Add(user);
            }
            return userList;
        }
        public User GetUserById(int userId)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@userId", userId)
            };
            DataTable datatable = ExecuteSelectQuery("GetUserById", sqlParameters);

            User user = new User();
            foreach (DataRow item in datatable.Rows)
            {
                user.Id = (int)item["employeeId"];
                user.Name = (string)item["employeeName"];
                user.FunctionId = (int)item["functionId"];
                user.FunctionName = (string)item["functionName"];
                user.SecretQuestion = (string)item["secretQuestion"];
                user.SecretAnswer = (string)item["secretAnswer"];
                user.EmployeeCode = item["employeeCode"].ToString();
            }

            return user;
        }
        public void InsertUser(User user)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@functionId", user.FunctionId),
                new SqlParameter("@username", user.Name),
                new SqlParameter("@question", user.SecretQuestion),
                new SqlParameter("@answer", user.SecretAnswer),
                new SqlParameter("@hash", user.HashWithSalt.Digest),
                new SqlParameter("@salt", user.HashWithSalt.Salt),
                new SqlParameter("@code", user.EmployeeCode)
            };
            ExecuteEditQuery("CreateUser", sqlParameters);
        }
        public void UpdateUser(User user)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@userId", user.Id),
                new SqlParameter("@username", user.Name),
                new SqlParameter("@code", int.Parse(user.EmployeeCode)),
                new SqlParameter("@funcId", user.FunctionId),
                new SqlParameter("@question", user.SecretQuestion),
                new SqlParameter("@answer", user.SecretAnswer)
            };
            ExecuteEditQuery("UpdateEmployee", sqlParameters);
        }
        public void DeleteUser(int userId)
        {
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@userId", userId)
            };
            ExecuteEditQuery("DeleteEmployee", sqlParameters);
        }
        public List<string> GetAllFunctions()
        {
            List<string> functions = new List<string>();

            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable datatable = ExecuteSelectQuery("GetAllFunctions", sqlParameters);

            foreach (DataRow dt in datatable.Rows)
            {
                functions.Add((string)dt["functionName"]);
            }
            return functions;
        } 
    }
}