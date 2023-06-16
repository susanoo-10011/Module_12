using _12._1._5;
using System;

public class Program
{
    static void Main(string[] args)
    {
        User[] arrayUsers = new User[3];
        Users.ListUsers(ref arrayUsers);

        for(int i = 0; i < arrayUsers.Length; i++)
        {
            if (arrayUsers[i].IsPremium == true)
            {
                Console.WriteLine($"\nЗдравствуйте, {arrayUsers[i].Name}! Ваш логин {arrayUsers[i].Login}. У вас есть подписка!\n");
            }
            else
            {
                Advertisement.ShowAds();
                Console.WriteLine($"\nЗдравствуйте, {arrayUsers[i].Name}! Ваш логин {arrayUsers[i].Login}.\n");
            }
        }
        Console.ReadKey();
    }
}
