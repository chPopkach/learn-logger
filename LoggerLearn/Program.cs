using System;

namespace LoggerLearn
{
    public class Program
    {
        static User AddUser(int id, string name, DateOnly birthDay, string login, string password)
        {
            LogHelper.Log(LogTarget.File, $"Дата: {DateTime.Now.ToString("dd/MM/yyyy")}, Время: {DateTime.Now.ToString("HH:mm:ss")}" +
                $"\nCreate user {name} with login <{login}> and password <{password}>\n");

            return new User()
            {
                Id = id,
                Name = name,
                BirthDay = birthDay,
                Login = login,
                Password = password
            };
        }

        static void Main(string[] args)
        {
            User user = AddUser(1, "Artem", new DateOnly(2004, 12, 9), "qweasd123", "123rtY56");
        }
    }
}