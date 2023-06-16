namespace _12._1._5
{
    public class Users
    {
        public static void ListUsers(ref User[] users)
        {
            users[0] = new User();
            users[0].Name = "Алексей";
            users[0].Login = "sdjsdlal";
            users[0].IsPremium = true;

            users[1] = new User();
            users[1].Name = "Дмитрий";
            users[1].Login = "DSDFASFAS";
            users[1].IsPremium = false;

            users[2] = new User();
            users[2].Name = "Илья";
            users[2].Login = "sdaksdads";
            users[2].IsPremium = true;
        }
    }
}
