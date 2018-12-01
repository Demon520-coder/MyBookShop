using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Admin.ViewModel
{
    public class LoginViewModel
    {
        [DisplayName("用户名")]
        [Required(ErrorMessage ="用户名不能为空")]
        public string UserName { get; set; }

        [DisplayName("密码")]
        [Required(ErrorMessage ="密码不能为空")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
    }
}
