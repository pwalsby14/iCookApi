using System;
namespace iCookApi.Controllers
{
    public class UserManagement
    {
        public UserManagement()
        {
        }


    }

    public class User
    {
        public User(string username, string password, string firstName, string lastName, string dateOfBirth, string id) 
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Id = id;
        }

        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string DateOfBirth { get; set; }
        public static string Id { get; set; }
    }
}
