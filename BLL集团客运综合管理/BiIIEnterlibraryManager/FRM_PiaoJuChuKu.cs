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
    class FRM_PiaoJuChuKu
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询用户信息
        [OperationContract]
        public DataSet SelectYuanGongXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYuanGongXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询票据出库信息
        [OperationContract]
        public DataSet SelectPiaoJuChuKuXinXi(int ReceiveUserID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@ReceiveUserID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectPiaoJuChuKuXinXi";
            SqlParameters[1].Value = ReceiveUserID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询当前使用票据
        [OperationContract]
        public DataSet SeleceBillremovaXinXi(int ReceiveUserID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@ReceiveUserID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SeleceBillremovaXinXi";
            SqlParameters[1].Value = ReceiveUserID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 删词票据出库信息
        [OperationContract]
        public int DelectBillremova(int BillremovalD)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@BillremovalD",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DelectBillremova";
            SqlParameters[1].Value = BillremovalD;
            int result = myDALMethod.UpdateData("FRM_PiaoJuChuKu", SqlParameters);
            return result;
        }
        #endregion
    }
}
