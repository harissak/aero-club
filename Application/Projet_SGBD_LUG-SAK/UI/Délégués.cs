using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
  
    public delegate void delSelect(int i);
    public delegate void delUpdate(int i);
    public delegate void delRefresh();
    public delegate void delSelectReservation (int resID, int mbrID, int machineID);
    public delegate void delSelectApp(int appID);

}
