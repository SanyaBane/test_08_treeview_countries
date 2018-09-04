using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_08_treeview_countries.Models;

namespace test_08_treeview_countries.Database.Mappers
{
    public class HouseMapper : AbstractMapper<House>
    {
        

        protected override void DoLoad(House obj, IDataReader reader)
        {
            obj.ID = Convert.ToInt32(reader["ID"]);
            obj.NAME = reader["NAME"].ToString();
        }
    }
}
