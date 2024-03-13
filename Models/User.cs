using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityApp_1.Models 
{
    [Table("UsersTable")]

    public class User
    {
        /*Створити WPF проект в якому з допомогою EF Core створити базу даних
        з табличкою користувачів. 
        UsersTable
        - Id primary key
        - Name nvarchar(64) not null
        - Login nvarchar(32) not null
        - Password nvarchar(32) not null*/
        [Key]
        public int Id { get; set; }
    
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
    
        [Required]
        [StringLength(32)]
        public string Login { get; set; }
    
        [Required]
        [StringLength(32)]
        public string Password { get; set; }
    }
}
