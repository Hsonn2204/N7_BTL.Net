using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    public class ConnectString
    {
        public static string GetConnectionString()
            {
               // return @"Data Source=LAPTOP-CUA-HOC\QUANGHOC;Initial Catalog=QuanLyDiemSV;Integrated Security=True;";
            return @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=master;Integrated Security=True;";
        }
    }
    
}
