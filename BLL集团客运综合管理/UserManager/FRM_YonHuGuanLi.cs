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
    class FRM_YonHuGuanLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询员工
        [OperationContract]
        public DataSet SelectUser()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectUser";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询员工类型
        [OperationContract]
        public DataSet SelectUserType()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectUserType";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询用户信息
        [OperationContract]
        public DataSet SelectYonHuXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYonHuXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询员工信息通过员工编号
        [OperationContract]
        public DataSet SelectYonHuXinXiByUserCoding(string UserCoding)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserCoding",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYonHuXinXiByUserCoding";
            SqlParameters[1].Value = UserCoding;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询员工信息通过员工姓名
        [OperationContract]
        public DataSet SelectYonHuXinXiByUserMC(string UserMC)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserMC",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYonHuXinXiByUserMC";
            SqlParameters[1].Value = UserMC;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询员工信息通过员工类型
        [OperationContract]
        public DataSet SelectYonHuXinXiByUserTypeMC(int UserTypeID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserTypeID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectYonHuXinXiByUserTypeMC";
            SqlParameters[1].Value = UserTypeID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询员工信息通过所属车站
        [OperationContract]
        public DataSet SelectYonHuXinXiByCarStandMC(int CarStandID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@CarStandID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectYonHuXinXiByCarStandMC";
            SqlParameters[1].Value = CarStandID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 删除员工信息
        [OperationContract]
        public int DeleteYonHuXinXi(int UserID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteYonHuXinXi";
            SqlParameters[1].Value = UserID;
            int result = myDALMethod.UpdateData("FRM_YonHuGuanLi", SqlParameters);
            return result;
        }
        #endregion
    }
}
