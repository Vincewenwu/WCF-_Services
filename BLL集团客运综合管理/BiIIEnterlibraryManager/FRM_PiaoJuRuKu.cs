using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.BiIIEnterlibraryManager
{
    [ServiceContract]
    class FRM_PiaoJuRuKu
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询票据信息
        [OperationContract]
        public DataSet SelectPiaoJuXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectPiaoJuXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuRuKu", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 删除票据信息
        [OperationContract]
        public int DeleteBiIIEnterlibraryXinXi(int BiIIEnterlibraryID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@BiIIEnterlibraryID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteBiIIEnterlibraryXinXi";
            SqlParameters[1].Value = BiIIEnterlibraryID;
            int result = myDALMethod.UpdateData("FRM_PiaoJuRuKu", SqlParameters);
            return result;
        }
        #endregion
    }
}
