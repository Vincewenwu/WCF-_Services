using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.Rrepoter
{
    [ServiceContract]
    class RepoterCheLIng
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]  //查询报班班次打印报表
        public DataSet SeleceDaYingBaoBiao()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "SeleceDaYingBaoBiao";
            DataTable  dt = myDAL.QueryDataTable("ReportDaYing", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        }
}
