/*
 * Filename: AssignmentContext.cs
 * Description: Serves as the context for the access to database.
 * 
 */

using Microsoft.EntityFrameworkCore;

namespace GradeBook.Model
{
    public class AssignmentContext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }

        public AssignmentContext(DbContextOptions<AssignmentContext> options)
            : base(options)
        {
        }

    } // End of class AssignmentContext

} // End of namespace GradeBook.Model
