using UniversityProject.Models;

namespace UniversityProject
{
    public static class Data
    {
        public static List<Student> sls = new List<Student>()
        {
            new Student { Id = 1,Name="Murad",Surname="Mammadzada",
            Group=new Group { Id = 1,Name="P137"}},
            new Student { Id = 2,Name="Murad1",Surname="Mammadzada1",
            Group=new Group { Id = 1,Name="P137"}},
            new Student { Id = 3,Name="Murad2",Surname="Mammadzada2",
            Group=new Group { Id = 1,Name="P137"}},
            new Student { Id = 4,Name="Murad3",Surname="Mammadzada3",
            Group=new Group { Id = 1,Name="P137"}},

        };
        public static List<Group> gpls = new List<Group>()
        {
            new Group { Id = 1,Name="P137"},
            new Group { Id = 2,Name="P-500"},
            new Group { Id = 3,Name="Ak-47"}
        };
    }
}
