using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication5.Models
{
    
    public class RequestDemoViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "فیلد اجباری میباشد.")]
        [MinLength(3,ErrorMessage = "لطفا مقدار معتبر وارد کنید.")]
        [MaxLength(15 , ErrorMessage = "لطفا مقدار معتبر وارد کنید.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "فیلد اجباری میباشد.")]
        [EmailAddress(ErrorMessage = "ایمیل نامعتبر است.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "فیلد اجباری میباشد.")]
        public int DemoSelected { get; set; }
        public string Desc { get; set; }
        public SelectList DemoList { get; set; }
  
    }
}