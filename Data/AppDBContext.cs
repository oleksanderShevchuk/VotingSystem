using Microsoft.EntityFrameworkCore;
using VotingSystem.Models;

namespace VotingSystem.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<VoteCastingInfo> VoteCastingInfo { get; set; }
        public DbSet<Voter> Voter { get; set; }
    }
}
