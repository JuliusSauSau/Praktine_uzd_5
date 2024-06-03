using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace Projektinis_darbas_5
{
    public class PasswordEntry
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string Comment { get; set; }
    }

    public class PasswordManager
    {
        private readonly string filePath;
        private readonly string encryptedFilePath;

        public PasswordManager(string username)
        {
            filePath = $"{username}_passwords.csv";
            encryptedFilePath = $"{username}_passwords_encrypted.csv";

            if (!File.Exists(encryptedFilePath))
            {
                using (var file = File.Create(filePath)) { }
                EncryptFile();
            }
            else
            {
                DecryptFile();
            }
        }

        public void EncryptFile()
        {
            if (!File.Exists(filePath)) return;

            var entries = ReadPasswords(false);

            using (var writer = new StreamWriter(encryptedFilePath))
            {
                foreach (var entry in entries)
                {
                    var encryptedEntry = new PasswordEntry
                    {
                        Name = CryptoHelper.EncryptString(entry.Name),
                        Password = CryptoHelper.EncryptString(entry.Password),
                        Url = CryptoHelper.EncryptString(entry.Url),
                        Comment = CryptoHelper.EncryptString(entry.Comment)
                    };
                    writer.WriteLine($"{encryptedEntry.Name},{encryptedEntry.Password},{encryptedEntry.Url},{encryptedEntry.Comment}");
                }
            }
            File.Delete(filePath);
        }

        public void DecryptFile()
        {
            if (!File.Exists(encryptedFilePath)) return;

            var entries = new List<PasswordEntry>();

            using (var reader = new StreamReader(encryptedFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        var entry = new PasswordEntry
                        {
                            Name = CryptoHelper.DecryptString(parts[0]),
                            Password = CryptoHelper.DecryptString(parts[1]),
                            Url = CryptoHelper.DecryptString(parts[2]),
                            Comment = CryptoHelper.DecryptString(parts[3])
                        };
                        entries.Add(entry);
                    }
                }
            }
            WriteAllPasswords(entries, false);
        }

        public void AddPassword(PasswordEntry entry)
        {
            var entries = ReadPasswords(true);
            entries.Add(entry);
            WriteAllPasswords(entries, true);
        }

        public List<PasswordEntry> ReadPasswords(bool decrypt = true)
        {
            var path = decrypt ? filePath : encryptedFilePath;
            if (!File.Exists(path)) return new List<PasswordEntry>();

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.Context.RegisterClassMap<PasswordEntryMap>();
                var entries = new List<PasswordEntry>(csv.GetRecords<PasswordEntry>());

                if (decrypt)
                {
                    foreach (var entry in entries)
                    {
                        entry.Password = CryptoHelper.DecryptString(entry.Password);
                        entry.Url = CryptoHelper.DecryptString(entry.Url);
                        entry.Comment = CryptoHelper.DecryptString(entry.Comment);
                    }
                }

                return entries;
            }
        }

        public PasswordEntry FindPassword(string name)
        {
            var entries = ReadPasswords(true);
            return entries.Find(entry => entry.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void UpdatePassword(string name, PasswordEntry newEntry)
        {
            var entries = ReadPasswords(true);
            var entry = entries.Find(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (entry != null)
            {
                entry.Password = newEntry.Password;
                entry.Url = newEntry.Url;
                entry.Comment = newEntry.Comment;

                WriteAllPasswords(entries, true);
            }
        }

        public void DeletePassword(string name)
        {
            var entries = ReadPasswords(true);
            entries.RemoveAll(e => e.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            WriteAllPasswords(entries, true);
        }

        private void WriteAllPasswords(List<PasswordEntry> entries, bool encrypt = true)
        {
            var path = encrypt ? filePath : encryptedFilePath;

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, config))
            {
                if (encrypt)
                {
                    foreach (var entry in entries)
                    {
                        entry.Password = CryptoHelper.EncryptString(entry.Password);
                        entry.Url = CryptoHelper.EncryptString(entry.Url);
                        entry.Comment = CryptoHelper.EncryptString(entry.Comment);
                    }
                }
                csv.WriteRecords(entries);
            }
        }
    }

    public class PasswordEntryMap : ClassMap<PasswordEntry>
    {
        public PasswordEntryMap()
        {
            Map(m => m.Name);
            Map(m => m.Password);
            Map(m => m.Url);
            Map(m => m.Comment);
        }
    }
}
