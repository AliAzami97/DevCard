using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace DevCard_Project.Models
{
    public class Contact
    {
        [MinLength(2, ErrorMessage = "حداقل تعداد کاراکتر نام، 2 تا می باشد.")]
        [MaxLength(10, ErrorMessage = "حداکثر تعداد کاراکتر نام، 10 تا می باشد.")]
        [Required(ErrorMessage ="اجباریه")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "مقدار وارد شده ایمیل صحیح نیست")]
        [Required(ErrorMessage = " اینم اجباریه")]
        public string Email { get; set; }

        public int? Service { get; set; }

        [Required(ErrorMessage = "حالا یه چارتا کلمه بنویسی، چی میشه؟!")]
        public string Message { get; set; }
        
        [ValidateNever]
        public SelectList? Services { get; set; }
    }
}
