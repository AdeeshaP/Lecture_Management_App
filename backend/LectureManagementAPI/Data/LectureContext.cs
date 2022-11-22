using LecturersWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LectureManagementAPI.Data
{
    public class LectureContext : DbContext
    {
        public LectureContext(DbContextOptions<LectureContext> options) : base(options) { }

        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Module> Modules { get; set; }
    }
}
