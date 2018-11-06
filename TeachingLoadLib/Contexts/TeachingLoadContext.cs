
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace TeachingLoadCore
{
    public partial class TeachingLoadContext
    {
        public TeachingLoadContext()
        {
            Task<int> disciplinesTask = Disciplines.CountAsync();

            Task<int> teachersTask = Teachers.CountAsync();

            Task<int> groupsTask = Groups.CountAsync();

            //Task<int> disciplinesTeachersTask = DisciplinesTeachers.CountAsync();

            //Task<int> disciplinesGroupsTask = DisciplinesGroups.CountAsync();

            //Task<int> classTypesTask = ClassTypes.CountAsync();

            TeachingLoadCore.Disciplines.Count = disciplinesTask.Result;
            TeachingLoadCore.Teachers.Count = teachersTask.Result;
            TeachingLoadCore.Groups.Count = groupsTask.Result;
            //ClassTypes.Count = classTypesTask.Result;
            //DisciplineTeachers.Count = disciplinesTeachersTask.Result;
            //DisciplineGroups.Count = disciplinesGroupsTask.Result;
        }

    }
}