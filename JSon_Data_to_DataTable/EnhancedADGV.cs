using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSon_Data_to_DataTable
{

    /*
     This class is created to enhance Advanced Data Grid View from Zuby's NuGet.
     Ocassionally, while trying to use this Data grid View, it refreshes along,
     what, for the user, may seem like Data Grid View is lagging.

     In order to improve this, I implement DoubleBuffered and set it to true.
     In such case, Datagridview do not flicker on user device.
     However, this solution may have issues on devices connecting to such with
     Parallel desktops or on servers, so be cautious for whom you are preparing this solution.
     */
    class EnhancedADGV : Zuby.ADGV.AdvancedDataGridView
    {
        public EnhancedADGV()
        {
            DoubleBuffered = true;
        }
    }
}
