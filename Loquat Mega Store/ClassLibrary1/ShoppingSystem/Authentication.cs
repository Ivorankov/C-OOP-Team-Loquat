using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoquatMegaStore.ShoppingSystem
{
    public static class Authentication
    {

        public static void LoginUser(User user)
        {
            bool checkUser = false;
            using (StreamReader read = new StreamReader("../../DB/UsersDB.txt"))
            {
                String line = read.ReadLine();
                do
                {
                    string[] arrayLine = line.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                    if (user.UserId.Equals(arrayLine[0]))
                    {
                        checkUser = true;
                        string test = SecurityCheck.GenerateSaltedHash(user.Password, arrayLine[3]);
                        //string salt = String.Empty;
                        //for (int i = test.Length; i < arrayLine[1].Length; i++)
                        //{
                        //    salt += arrayLine[1];
                        //}
                        if (SecurityCheck.CheckHash(test, arrayLine[1]))
                        {
                            Console.WriteLine("Login successful");
                            checkUser = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Login failed");
                        }
                    }

                    line = read.ReadLine();

                } while ((line != null));
                if (checkUser == false)
                {
                    Console.WriteLine("There is no user with these credentials");
                }
            }
        }

        public static void CreateUser(User user)
        {
            bool checkUser = false;
            using (StreamReader read = new StreamReader("../../DB/UsersDB.txt"))
            {
                String line = read.ReadLine();
                while (line != null)
                {
                    string[] arrayLine = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (user.UserId.Equals(arrayLine[0]) || user.Email.Equals(arrayLine[2]))
                    {
                        Console.WriteLine("There is already a user with that username or email"  );
                        checkUser = true;
                    }
                    line = read.ReadLine();
                }
            }
            if (!checkUser)
            {


                //using (StreamWriter write = new StreamWriter("../../DB/UsersDB.txt",append:true))
                //{

                    string[] str = new string[4];
                    string[] salt = DateTime.Now.ToString().Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries);
                    string test = SecurityCheck.GenerateSaltedHash(user.Password, String.Join("",salt));

                    str[0] = user.UserId;
                    str[1] = test;
                    str[2] = user.Email;
                    str[3] = String.Join("",salt);
                    

                    Console.WriteLine("User created successfully");
                    //write.WriteLine(String.Join(" ", str));

                    File.AppendAllText("../../DB/UsersDB.txt",String.Join(" ",str)+Environment.NewLine);

                //}
            }

        }
    }
}


