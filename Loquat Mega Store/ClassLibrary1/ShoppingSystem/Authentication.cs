﻿namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.IO;
    using System.Linq;

    public static class Authentication
    {
        public static bool LoginUser(User user)
        {
            bool checkUser = false;
            var path = GetPath(user);
            using (StreamReader read = new StreamReader(path))
            {
                String line = read.ReadLine();
                do
                {
                    string[] arrayLine = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (user.UserId.Equals(arrayLine[0]))
                    {
                        checkUser = true;
                        string hashedPass = Hashing.GenerateSaltedHash(user.Password, arrayLine[3]);

                        if (Hashing.CheckHash(hashedPass, arrayLine[1]))
                        {
                            checkUser = true;
                            break;
                        }
                        else
                        {
                            checkUser = false;
                        }
                    }

                    line = read.ReadLine();
                } while ((line != null));

                return checkUser;
            }
        }

        public static void CreateUser(Customer user)
        {
            bool checkUser = false;
            string path = GetPath(user);
            using (StreamReader read = new StreamReader(path))
            {
                String line = read.ReadLine();
                while (line != null)
                {
                    string[] arrayLine = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (user.UserId.Equals(arrayLine[0]) || user.Email.Equals(arrayLine[2]))
                    {
                        Console.WriteLine("There is already a user with that username or email");
                        checkUser = true;
                    }
                    line = read.ReadLine();
                }
            }
            if (!checkUser)
            {
                string[] str = CreateDBInput(user);
                Console.WriteLine("User created successfully");

                File.AppendAllText("../../DB/UsersDB.txt", String.Join(" ", str) + Environment.NewLine);
            }
        }

        private static string GetPath(User user)
        {
            string path = String.Empty;
            if (user.GetType().Name == "Administrator")
            {
                path = "../../DB/AdminsDB.txt";
            }
            else
            {
                path = "../../DB/UsersDB.txt";
            }
            return path;
        }

        private static string[] CreateDBInput(User user)
        {
            string[] strArray = new string[4];
            string[] salt = DateTime.Now.ToString().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string test = Hashing.GenerateSaltedHash(user.Password, String.Join(String.Empty, salt));

            strArray[0] = user.UserId;
            strArray[1] = test;
            strArray[2] = user.Email;
            strArray[3] = String.Join(String.Empty, salt);
            return strArray;
        }
    }
}