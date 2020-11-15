using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Parking.Model
{
    public class Users
    { 
    private List<User> users = new List<User>();

    public void Add(User user)
    {
        users.Add(user);
    }

    public List<User> ReturnAll()
    {
        return users;
    }

    public void DeleteAll()
    {
        users.Clear();
    }

    public void AddAll(List<User> users)
    {
        this.users = users;
    }

}
}

