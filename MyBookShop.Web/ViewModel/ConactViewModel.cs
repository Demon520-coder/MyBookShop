using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Web.ViewModel
{
    public class ConactViewModel
    {
        [DisplayName("称呼")]
        [MaxLength(20,ErrorMessage ="做多20个字符")]
        public string CustomerName { get; set; }

        [DisplayName("电子邮箱")]
        [Required]
        [EmailAddress(ErrorMessage ="电子邮箱错误")]
        public string Email { get; set; }

        [DisplayName("主题")]
        [Required(ErrorMessage ="留言主题不能为空")]
        public string Subject { get; set; }

        [DisplayName("内容")]
        [Required]
        [MaxLength(500,ErrorMessage ="留言内容最多500个字符")]
        public string Message { get; set; }
    }
}
