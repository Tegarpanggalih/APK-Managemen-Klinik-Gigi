using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental_Management_System.konfigurasi
{
    abstract class Konfigurasi_Cls
    {
        //untuk menagani  intruksi insert,create,update, delete
        public abstract int eksekusiBukanQuery(string query);

        //untuk menangani fungsi select
        public abstract DataTable eksekusiQuery(string query);
    }
}
