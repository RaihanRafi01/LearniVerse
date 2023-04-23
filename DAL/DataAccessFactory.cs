using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;

namespace DAL
{
    public class DataAccessFactory
    {
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


        public static IRepo<Student, int, Student> StudentData()
        {
            return new StudentRepo();
        }

        public static IRepo<Guardian, int, Guardian> GuardianData()
        {
            return new GuardianRepo();
        }

    }
}
