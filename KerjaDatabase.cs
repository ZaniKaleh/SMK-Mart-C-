using System;
using System.IO;
using System.Collections.Generic;

namespace LatihanProjek01
{
    public class Barang
    {
        public string NamaBarang { get; set; } = string.Empty;
        public int Stok { get; set; }
        public long Harga { get; set; }
        public int StokMinimum {  get; set; }
        public int Kondisi { get; set; } = 1;

    }

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
        public static Dictionary<string, Dictionary<string, Barang>> SpilStok(string Job)
        {
            Dictionary<string, Dictionary<string, Barang>> stok = new();
            string Filestoknya = "Stok.txt";
            if (File.Exists(Filestoknya))
            {
                string[] datanya=File.ReadAllLines(Filestoknya);
                foreach (string baris in datanya)
                {
                    if (string.IsNullOrWhiteSpace(baris)) continue;
                    string[] part=baris.Split('|');

                    string kat=part[0].Trim();
                    string aidi=part[1].Trim();
                    string nama=part[2].Trim();
                    int stok_jml=int.Parse(part[3].Trim());
                    long harga=int.Parse(part[4].Trim());
                    int stok_min=int.Parse(part[5].Trim());

                    int aktif = part.Length >= 7 ? int.Parse(part[6].Trim()) : 1;
                    if (Job != "Admin"&& aktif == 0)
                    {
                        continue;
                    }
                    if (!stok.ContainsKey(kat))
                    {
                        stok[kat] = new Dictionary<string, Barang>();
                    }
                    stok[kat][aidi] = new Barang
                    {
                        NamaBarang = nama,
                        Stok = stok_jml,
                        Harga = harga,
                        StokMinimum = stok_min,
                        Kondisi = aktif
                    };
                }
            }
            return stok;
        }
        public static Dictionary<string, string> SpilKategori()
        {
            Dictionary<string, string> kategori = new Dictionary<string, string>();
            string filekategorinya = "Kategori.txt";
            if (File.Exists(filekategorinya))
            {
                string[] datakategorinya=File.ReadAllLines(filekategorinya);
                foreach (string baris in datakategorinya)
                {
                    if (string.IsNullOrWhiteSpace(baris))
                    {
                        continue;
                    }
                    string[] part = baris.Split('|');
                    if (part.Length < 2)
                    {
                        continue;
                    }
                    string namakat = part[0].Trim().ToLower();
                    string inisial = part[1].Trim().ToUpper();
                    if (namakat.Length==0 || inisial.Length == 0)
                    {
                        continue;
                    }
                    kategori[namakat]=inisial;
                }
            }
            return kategori;
        }
        public static void simpanstok(Dictionary<string, Dictionary<string, Barang>> data)
        {
            using (StreamWriter file = new StreamWriter("Stok.txt"))
            {
                foreach (var kategori in data)
                {
                    foreach (var barang in kategori.Value)
                    {
                        Barang detail=barang.Value;
                        file.WriteLine($"{kategori.Key}|{barang.Key}|{detail.NamaBarang}|{detail.Stok}|{detail.Harga}|{detail.StokMinimum}|{detail.Kondisi}");
                    }
                }
            }
        }
        public static string TambahBarang(string namaKategori, string inisialBaru, string namaBarang, int stokAwal, long harga, int stokMinimum)
        {
            namaKategori = namaKategori.Trim().ToLower();
            inisialBaru=inisialBaru.Trim().ToUpper();
            namaBarang = namaBarang.Trim();
            if 
        }
    }
}