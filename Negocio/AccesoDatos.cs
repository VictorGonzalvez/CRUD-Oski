using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["cs_proyecto"].ConnectionString
            );

    }
}
