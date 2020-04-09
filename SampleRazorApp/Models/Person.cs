using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleRazorApp.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [Display(Name = "名前")]
        [Required(ErrorMessage = "必須項目です。")]
        public string Name { get; set; }
        [Display(Name = "メールアドレス")]
        [EmailAddress(ErrorMessage = "メールアドレスが必要です。")]
        public string Mail { get; set; }
        [Display(Name = "年齢")]
        [Range(0, 200, ErrorMessage = "ゼロ以上200以下の値にしてください。")]
        public int Age { get; set; }
    }
}
