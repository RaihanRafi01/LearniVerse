using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;

namespace DAL
{
    public class DataAccessFactory
    {
        //Rafi
        public static IRepo<Teacher, int, Teacher> TeacherData()
        {
            return new TeacherRepo();
        }

        public static IRepo<Course, int, Course> CourseData()
        {
            return new CourseRepo();
        }
        public static IRepo<Ques, int, Ques> QuesData()
        {
            return new QuesRepo();
        }



        //Sufian
        public static IRepo<Student, int, Student> StudentData()
        {
            return new StudentRepo();
        }

        public static IRepo<Payment, int, Payment> PaymentData()
        {
            return new PaymentRepo();
        }

        public static IRepo<Salary, int, Salary> SalaryData()
        {
            return new SalaryRepo();
        }


        //mushfiq
        public static IRepo<Guardian, int, Guardian> GuardianData()
        {
            return new GuardianRepo();
        }

        public static IRepo<Result, int, Result> ResultData()
        {
            return new ResultRepo();
        }
        public static IRepo<Admin, int, Admin> AdminData()
        {
            return new AdminRepo();
        }

        // AUTH
        public static IAuthTeacher<bool> AuthTeacherData() 
        {
            return new TeacherRepo();
        }
        public static IRepo<TokenTeacher, string, TokenTeacher> TokenDataTeacher() 
        {
            return new TokenTeacherRepo();
        }

        //MOHOK
        public static IRepo<StudentGuardianTeacher, int, StudentGuardianTeacher> StGuData()
        {
            return new StGuTeRepo();
        }
        public static IRepo<QuizResult, int, QuizResult> QuizResultData()
        {
            return new QuizResultRepo();
        }

    }
}
