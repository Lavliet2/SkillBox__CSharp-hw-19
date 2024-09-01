﻿using Homework_19_2.Models;
using System.Text.Json;

namespace Homework_19_2.Services
{
    public class ContactService
    {
        public List<Contact> GetContacts()
        {
            string fileName = "Data/contacts.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<Contact>>(jsonString);
        }
    }
}
