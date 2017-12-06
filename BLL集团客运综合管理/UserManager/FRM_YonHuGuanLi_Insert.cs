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
    class FRM_YonHuGuanLi_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询员工类型
        [OperationContract]
        public DataSet SelectUserType()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectUserType";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询所属车站
        [OperationContract]
        public DataSet SelectCarStand()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCarStand";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车站通过车站名称
        [OperationContract]
        public DataSet SelectCheZhanByCarStandMC(string CarStandMC)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@CarStandMC",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCheZhanByCarStandMC";
            SqlParameters[1].Value = CarStandMC;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询员工类型通过员工类型名称
        [OperationContract]
        public DataSet SelectUserTypeByUserTypeMC(string UserTypeMC)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserTypeMC",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectUserTypeByUserTypeMC";
            SqlParameters[1].Value = UserTypeMC;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 新增车站信息
        [OperationContract]
        public int InsertCarStandXinXi(string CarStandMC)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@CarStandMC",SqlDbType.NChar)
             };
            SqlParameters[0].Value = "InsertCarStandXinXi";
            SqlParameters[1].Value = CarStandMC;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Insert", SqlParameters);
            int rault = Convert.ToInt32(dt.Rows[0][0]);
            return rault;
        }
        #endregion

        #region 新增员工类型信息
        [OperationContract]
        public int InsertUserTypeXinXi(string UserTypeMC)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@UserTypeMC",SqlDbType.NChar)
             };
            SqlParameters[0].Value = "InsertUserTypeXinXi";
            SqlParameters[1].Value = UserTypeMC;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi_Insert", SqlParameters);
            int rault = Convert.ToInt32(dt.Rows[0][0]);
            return rault;
        }
        #endregion

        #region 新增员工信息
        [OperationContract]
        public int InsertUser(
            int UserTypeID,
            int AuthorityTypeID,
            int CarStandID,
            string UserMC,
            string UserCoding,
            string Password,
            string Comments)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@UserTypeID",SqlDbType.Int),
                new SqlParameter("@AuthorityTypeID",SqlDbType.Int),
                new SqlParameter("@CarStandID",SqlDbType.Int),
                new SqlParameter("@UserMC",SqlDbType.NChar),
                new SqlParameter("@UserCoding",SqlDbType.NChar),
                new SqlParameter("@Password",SqlDbType.NChar),
                new SqlParameter("@Comments",SqlDbType.NChar)
             };
            SqlParameters[0].Value = "InsertUser";
            SqlParameters[1].Value = UserTypeID;
            SqlParameters[2].Value = AuthorityTypeID;
            SqlParameters[3].Value = CarStandID;
            SqlParameters[4].Value = UserMC;
            SqlParameters[5].Value = UserCoding;
            SqlParameters[6].Value = Password;
            SqlParameters[7].Value = Comments;
            int result = myDALMethod.UpdateData("FRM_YonHuGuanLi_Insert", SqlParameters);
            return result;
        }
        #endregion
    }
}
