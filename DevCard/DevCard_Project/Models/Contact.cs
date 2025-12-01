using System.ComponentModel.DataAnnotations;

namespace DevCard_Project.Models
{
    public class Contact
    {
        [MinLength(2, ErrorMessage = "حداقل تعداد کاراکتر نام، 2 تا می باشد.")]
        [MaxLength(10, ErrorMessage = "حداکثر تعداد کاراکتر نام، 10 تا می باشد.")]
        [Required(ErrorMessage ="اجباریه")]
        public string Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = " اینم اجباریه")]
        public string Email { get; set; }

        public string Service { get; set; }

        [Required(ErrorMessage = "حالا یه چارتا کلمه بنویسی، چی میشه؟!")]
        public string Message { get; set; }
    }
}
