using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.UserManager
{
    [ServiceContract]
    class FRM_YonHuQuanXianGuanLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询权限类型父ID
        [OperationContract]
        public DataSet SelectAuthorityTypeFuID(int AuthorityTypeFuID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@AuthorityTypeFuID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectAuthorityTypeFuID";
            SqlParameters[1].Value = AuthorityTypeFuID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuQuanXianGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询用户类型
        [OperationContract]
        public DataSet SelectUserType()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectUserType";
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuQuanXianGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车站父ID
        [OperationContract]
        public DataSet SelectCarStandFuID(int CarStandFuID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@CarStandFuID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectCarStandFuID";
            SqlParameters[1].Value = CarStandFuID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuQuanXianGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 
        [OperationContract]
        public DataSet SDFSFSF(int 系统管理FU)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@系统管理FU",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SDFSFSF";
            SqlParameters[1].Value = 系统管理FU;
            DataTable dt = myDALMethod.QueryDataTable("FRM_YonHuQuanXianGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}
