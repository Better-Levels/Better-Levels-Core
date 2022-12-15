using Npgsql;

namespace Better_Levels_Core.Models
{
    public class Reward
    {
        public int Level { get; set; }
        public long RoleId { get; set; }
        public bool IsPersistent { get; set; }
    }
}
