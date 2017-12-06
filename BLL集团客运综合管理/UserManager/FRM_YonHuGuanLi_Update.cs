using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.UserManager
{
    [ServiceContract]
    class FRM_YonHuGuanLi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询用户类型
        [OperationContract]
        public DataSet SelectYonHuLeiXing()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYonHuLeiXing";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询所属车站
        [OperationContract]
        public DataSet SelectSuoShuCheZhan()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectSuoShuCheZhan";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询员工信息
        [OperationContract]
        public DataSet SelectYuanGongXinXi(int UserID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectYuanGongXinXi";
            SqlParameters[1].Value = UserID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 修改员工信息
        [OperationContract]
        public int UpdateYuanGongXinXi(int UserTypeID,int CarStandID,
            string UserCoding,string Password,string Comments,int UserID, string UserMC)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserTypeID",SqlDbType.Int),
                   new SqlParameter("@CarStandID",SqlDbType.Int),
                   new SqlParameter("@UserCoding",SqlDbType.NChar),
                   new SqlParameter("@Password",SqlDbType.NChar),
                   new SqlParameter("@Comments",SqlDbType.NChar),
                   new SqlParameter("@UserID",SqlDbType.Int),
                   new SqlParameter("@UserMC",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "UpdateYuanGongXinXi";
            SqlParameters[1].Value = UserTypeID;
            SqlParameters[2].Value = CarStandID;
            SqlParameters[3].Value = UserCoding;
            SqlParameters[4].Value = Password;
            SqlParameters[5].Value = Comments;
            SqlParameters[6].Value = UserID;
            SqlParameters[7].Value = UserMC;
            int result = myDALMethod.UpdateData("FRM_YonHuGuanLi_Update", SqlParameters);
            return result;
        }
        #endregion
    }
}
