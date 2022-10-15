using Models;

namespace LogBook.Repositories;

public class FakeRepos{
    public static List<Student> GetStudents()
    {
        return new()
        {
            new Student(1,"User.png","Vasif","Babazade","Asif",new DateTime(2022,10,9),null),
            new Student(2,"User.png","Emin","Novruz","Zaur",new DateTime(2022,10,13),null),
            new Student(3,"User.png","Royal","Beledli","Qudret",new DateTime(2022,10,12),null),
            new Student(4,"User.png","Huseyn","Hemidov","Resadet",new DateTime(2022,10,11),null)
        };
    }
}
