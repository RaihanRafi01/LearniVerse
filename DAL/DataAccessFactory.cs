using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;

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

    }
}
