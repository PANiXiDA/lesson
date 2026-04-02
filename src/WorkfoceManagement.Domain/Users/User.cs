using System;
using System.Collections.Generic;
using System.Text;

namespace WorkfoceManagement.Domain.Users
{
    public sealed class User
    {
        private const int MinimalAge = 18;

        private User(
            string name,
            string email,
            string password,
            int age)
        {
            Name = name;
            Email = email;
            Password = password;
            Age = age;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int Age { get; private set; }

        public static User Create(
            string name,
            string email,
            string password,
            int age)
        {
            ValidateName(name);

            if (age < MinimalAge)
            {
                throw new Exception("Возраст меньше допустимого");
            }

            var user = new User(
                name: name,
                email: email,
                password: password,
                age: age);

            return user;
        }

        public void ChangeEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email не можем быть пустым");
            }

            Email = email;
        }

        private static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Имя не можем быть пустым");
            }
        }
    }
}
