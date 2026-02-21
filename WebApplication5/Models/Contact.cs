using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [MinLength(3,ErrorMessage = "مقدار معتبر وارد کنید")]
        [MaxLength(10,ErrorMessage = "مقدار معتبر وارد کنید")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "ایمیل معتبر وارد کنید")]
        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Email { get; set; }
        public string Messege { get; set; }
    }
}