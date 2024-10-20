﻿using System.ComponentModel.DataAnnotations;

namespace BlogSharp2024.WebSite.ApiClient.DTO
{
    public class Author
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
