using System;
using System.IO;
using System.Collections.Generic;

namespace LatihanProjek01
{
    public class KerjaDatabase
    {
        public static List<string[]> SpilUser()
        {
            List<string[]>users= new();
            string Fileuser="User.txt";
            if (File.Exists(Fileuser))
            {
                string[] datauser= File.ReadAllLines(Fileuser);
                foreach (string baris in datauser)
                {
                    if (string.IsNullOrWhiteSpace(baris)) continue;
                    string[] part = baris.Split('|');
                    if (part.Length >= 4)
                    {
                        users.Add(part);
                    }

                }
            }
            return users;
        }
        public static bool Login(string username, string password, string role)
        {
            List<string[]> loginkan = SpilUser();
            foreach (string[] detailuser in loginkan)
            {
                if (detailuser[1].Trim()==username && detailuser[3].Trim()==password && detailuser[2].Trim()==role)
                {
                    return true;
                }
            }
            return false;
        }
    }
}