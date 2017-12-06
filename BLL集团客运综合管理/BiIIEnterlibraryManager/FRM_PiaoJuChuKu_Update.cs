using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;
using System;

namespace BLL集团客运综合管理.BiIIEnterlibraryManager
{
    [ServiceContract]
    class FRM_PiaoJuChuKu_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询用户信息
        [OperationContract]
        public DataSet SelectYuanGon()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYuanGon";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询使用状态
        [OperationContract]
        public DataSet SelectShiYongZhuangTai()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectShiYongZhuangTai";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询票据出库
        [OperationContract]
        public DataSet SelectPiaoJuChuKu(int BillremovalD)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@BillremovalD",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectPiaoJuChuKu";
            SqlParameters[1].Value = BillremovalD;
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 修改票据出库
        [OperationContract]
        public int UpdatePiaoJuChuKuXinXi(int UseStateID, int ReceiveUserID, string Comment, int BillremovalD)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UseStateID",SqlDbType.NChar),
                   new SqlParameter("@ReceiveUserID",SqlDbType.NChar),
                   new SqlParameter("@Comment",SqlDbType.NChar),
                   new SqlParameter("@BillremovalD",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "UpdatePiaoJuChuKuXinXi";
            SqlParameters[1].Value = UseStateID;
            SqlParameters[2].Value = ReceiveUserID;
            SqlParameters[3].Value = Comment;
            SqlParameters[4].Value = BillremovalD;
            int result = myDALMethod.UpdateData("FRM_PiaoJuChuKu_Update", SqlParameters);
            return result;
        }
        #endregion
    }
}
