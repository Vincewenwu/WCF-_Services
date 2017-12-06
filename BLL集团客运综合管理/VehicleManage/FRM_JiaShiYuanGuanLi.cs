using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.VehicleManage
{
    [ServiceContract]
    class FRM_JiaShiYuanGuanLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询驾驶员编号
        [OperationContract]
        public DataSet SelectJiaShiYuanBianHao()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanBianHao";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员名称
        [OperationContract]
        public DataSet SelectJiaShiYuanMingCheng()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanMingCheng";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员信息
        [OperationContract]
        public DataSet SelectJiaShiYuanXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员信息通过驾驶员编号
        [OperationContract]
        public DataSet SelectJiaShiYuanXinXiByJiaShiYuanBianHao(string DriverNumber)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@DriverNumber",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanXinXiByJiaShiYuanBianHao";
            SqlParameters[1].Value = DriverNumber;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员信息通过驾驶员ID
        [OperationContract]
        public DataSet SelectJiaShiYuanXinXiByJiaShiYuanID(int DriverID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@DriverID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanXinXiByJiaShiYuanID";
            SqlParameters[1].Value = DriverID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员详细信息通过驾驶员ID
        [OperationContract]
        public DataSet SelectJiaShiYuanXiangXiXinXiByJiaShiYuanID(int DriverID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@DriverID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanXiangXiXinXiByJiaShiYuanID";
            SqlParameters[1].Value = DriverID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员图片
        [OperationContract]
        public byte[] SelectJiaShiYuanTuPian(int DriverID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@DriverID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanTuPian";
            SqlParameters[1].Value = DriverID;
            return myDALMethod.QueryDataByte("FRM_JiaShiYuanGuanLi", SqlParameters);
        }
        #endregion

        #region 删除驾驶员信息
        [OperationContract]
        public int DeleteJiaShiYuanXinXi(int DriverID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@DriverID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteJiaShiYuanXinXi";
            SqlParameters[1].Value = DriverID;
            int result = myDALMethod.UpdateData("FRM_JiaShiYuanGuanLi", SqlParameters);
            return result;
        }
        #endregion
    }
}
