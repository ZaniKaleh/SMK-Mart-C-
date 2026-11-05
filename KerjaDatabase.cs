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
        public static string AmbilPathFile(string namaFile)
        {
            string folderProject = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
            return Path.Combine(folderProject, namaFile);
        }
        public static List<string[]> SpilUser()
        {
            List<string[]>users= new();
            string Fileuser=AmbilPathFile("User.txt");
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
            string Filestoknya = AmbilPathFile("Stok.txt");
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
                    long harga=long.Parse(part[4].Trim());
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
            string filekategorinya = AmbilPathFile("Kategori.txt");
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
            using (StreamWriter file = new StreamWriter(AmbilPathFile("Stok.txt")))
            {
                foreach (var kategori in data)
                {
                    foreach (var barang in kategori.Value)
                    {
                        Barang detail = barang.Value;
                        file.WriteLine($"{kategori.Key}|{barang.Key}|{detail.NamaBarang}|{detail.Stok}|{detail.Harga}|{detail.StokMinimum}|{detail.Kondisi}");
                    }
                }
            }
        }
        public static string TambahBarang(bool kategoriBaru, string namaKategori, string inisialBaru, string namaBarang, int stokAwal, long harga, int stokMinimum)
        {
            namaKategori = namaKategori.Trim().ToLower();
            inisialBaru=inisialBaru.Trim().ToUpper();
            namaBarang = namaBarang.Trim();
            string pathKategori = AmbilPathFile("Kategori.txt");
            if (!File.Exists(pathKategori))
            {
                return "File Kategori.txt tidak ditemukan!";
            }
            Dictionary<string, string> kategori = SpilKategori();
            string inisial;

            if (kategoriBaru)
            {
                if (kategori.ContainsKey(namaKategori))
                {
                    inisial = kategori[namaKategori];
                }
                else
                {
                    if (inisialBaru.Length == 0)
                    {
                        return "Inisial tidak boleh kosong!";
                    }
                    foreach(string kode in kategori.Values)
                    {
                        if (kode == inisialBaru)
                        {
                            return "Inisial tersebut sudah digunakan!";
                        }
                    }
                    File.AppendAllText(pathKategori, $"{namaKategori}|{inisialBaru}|{Environment.NewLine}");
                    inisial = inisialBaru;
                }
            }
            else
            {
                if (!kategori.ContainsKey(namaKategori))
                {
                    return "Nama Kategori tidak valid/tidak terdaftar!";
                }
                inisial = kategori[namaKategori];
            }
            Dictionary<string, Dictionary<string, Barang>> stok = SpilStok("Admin");
            int maksID = 0;
            if (stok.ContainsKey(namaKategori))
            {
                foreach (string idLama in stok[namaKategori].Keys)
                {
                    if (idLama.Length <= inisial.Length)
                    {
                        continue;
                    }
                    string bagianAngka = idLama.Substring(inisial.Length);
                    if (int.TryParse(bagianAngka, out int angka))
                    {
                        if (angka > maksID)
                        {
                            maksID = angka;
                        }
                    }
                }
            }
            string idBaru = inisial + (maksID + 1).ToString("D3");
            if (!stok.ContainsKey(namaKategori))
            {
                stok[namaKategori] = new Dictionary<string, Barang>();
            }
            stok[namaKategori][idBaru] = new Barang
            {
                NamaBarang = namaBarang,
                Stok = stokAwal,
                Harga = harga,
                StokMinimum = stokMinimum,
                Kondisi = 1
            };
            simpanstok(stok);
            return $"Barang berhasil ditambahkan! ID Barang: {idBaru}";
        }
        public static bool HapusUser(string id)
        {
            string filenya = AmbilPathFile("User.txt");
            if (!File.Exists(filenya))
            {
                return false;
            }
            List<string> dataUser = new();
            bool ditemukan = false;
            foreach (string baris in File.ReadAllLines(filenya))
            {
                if (string.IsNullOrWhiteSpace(baris))
                {
                    dataUser.Add(baris);
                    continue;
                }
                string[] part = baris.Split('|');
                if (part[0].Trim() == id.Trim())
                {
                    ditemukan=true;
                    continue;
                }
                dataUser.Add(baris);
            }
            if (!ditemukan)
            {
                return false;
            }
            File.WriteAllLines(filenya, dataUser);
            return true;
        }
    }
}