using System;
using System.Collections;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            User user1 = new User("Messi", "messi@gmail.com");
            User user2 = new User("Ronaldo", "ronaldo@gmail.com");

            ArrayList users= new ArrayList();

            users.Add(user1);
            users.Add(user2);

            Mongodb mongodb = new Mongodb("MongoCluster",2022,users);


            Console.WriteLine(mongodb);
        }
    }
}
