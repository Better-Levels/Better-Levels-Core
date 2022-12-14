using Better_Levels_Core.Models;

namespace Better_Levels_Core.Services
{
    public static class UserService
    {
        static List<User> Users { get; }

        static UserService()
        {
            Users = new List<User>
            {
                new User { Id = 217819569354571776, CurrentLevel = 43, RemainingXP = 387428},
                new User { Id = 615337821309239337, CurrentLevel = 2, RemainingXP = 22}
            };
        }

        public static List<User> GetAll() => Users;

        public static User? Get(long id) => Users.FirstOrDefault(u => u.Id == id);
        
        public static void Add(User user)
        {
            Users.Add(user);
        }

        public static void Delete(long id)
        {
            User user = Get(id);
            if (user is null) return;

            Users.Remove(user);
        }

        public static void Update(User user)
        {
            int index = Users.FindIndex(u => u.Id == user.Id);

            if (index == -1) return;

            Users[index] = user;
        }
    }
}
