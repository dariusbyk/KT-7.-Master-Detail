using System.Collections.ObjectModel;

namespace MasterDetailDemo
{
    public class MainViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public MainViewModel()
        {
            Users = new ObservableCollection<User>();

            Users.Add(new User
            {
                Name = "Алексей",
                Email = "alexey@example.com",
                Age = 22
            });

            Users.Add(new User
            {
                Name = "Мария",
                Email = "maria@example.com",
                Age = 25
            });

            Users.Add(new User
            {
                Name = "Иван",
                Email = "ivan@example.com",
                Age = 20
            });
        }
    }
}