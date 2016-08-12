using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network
{
    interface AdminActions : UserActions
    {
        string DeleteUser(AbstractUser u);
        string ChangePermission(int permission, AbstractUser u);
    }
}
