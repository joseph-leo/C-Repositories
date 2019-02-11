using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private string _connectionString = @"Data Source=DESKTOP-RNTNJNE\SQLEXPRESS;
                                            Initial Catalog = School; Integrated Security = True; 
                                            Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;
                                            ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // GET: Student
        public ActionResult Index()
        {
            string queryString = "Select * From Students";
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student()
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString()
                    };
                    students.Add(student);
                }
            }

            return View(students);
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}