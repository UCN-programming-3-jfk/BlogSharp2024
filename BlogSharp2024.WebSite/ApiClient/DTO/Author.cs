using System.ComponentModel.DataAnnotations;

namespace BlogSharp2024.WebSite.ApiClient.DTO
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string BlogTitle { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
