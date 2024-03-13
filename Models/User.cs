using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityApp_1.Models;
class User
{
    /*Створити WPF проект в якому з допомогою EF Core створити базу даних
    з табличкою користувачів. Колонки: id, name, login, password*/

    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
}
