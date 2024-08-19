using GraphQLApi.Model;

namespace GraphQLApi.GraphQL
{
    public class Query
    {
        private List<Book> _books = new List<Book>()
        {
            new Book(){Id=1,Title="Secret Wars",Author="Stan Lee"},
            new Book(){Id=2,Title="Dawn of Justice",Author="Kevin"}
        };

        private List<Student> _students = new List<Student>()
        {
            new Student(){RollNo=039,Name="Ramz",Dept="MCA",Cgpa=8.5f},
            new Student(){RollNo=040,Name="Rheya",Dept="MCA",Cgpa=8.7f}
        };

        public IEnumerable<Book> GetBooks() => _books;
        public Book GetBookById(int id) => _books.FirstOrDefault(b => b.Id == id);

        public IEnumerable<Student> GetStudents() => _students;
        public Student GetStudentByRollNo(int rollno) => _students.FirstOrDefault(s => s.RollNo == rollno);
    }
}
