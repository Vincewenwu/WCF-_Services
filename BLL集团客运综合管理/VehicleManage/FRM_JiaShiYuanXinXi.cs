using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.VehicleManage
{
    [ServiceContract]
    class FRM_JiaShiYuanXinXi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询驾驶员信息
        [OperationContract]
        public DataSet SelectJiaShiYuanXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanXinXi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
