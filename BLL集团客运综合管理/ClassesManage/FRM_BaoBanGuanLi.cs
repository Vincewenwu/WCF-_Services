using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.ClassesManage
{
    [ServiceContract]
    class FRM_BaoBanGuanLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询车辆编号
        [OperationContract]
        public DataSet SelectCheLiangBianHao()
        {
            SqlParameter[] mySqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            mySqlParameters[0].Value = "SelectCheLiangBianHao";
            DataTable dt = myDALMethod.QueryDataTable("FRM_BaoBanGuanLi", mySqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询报班信息通过车牌号
        [OperationContract]
        public DataSet SelectBaoBanXinXiByChePaiHao(string VehicleNumber)
        {
            SqlParameter[] mySqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@VehicleNumber",SqlDbType.NChar)
            };
            mySqlParameters[0].Value = "SelectBaoBanXinXiByChePaiHao";
            mySqlParameters[1].Value = VehicleNumber;
            DataTable dt = myDALMethod.QueryDataTable("FRM_BaoBanGuanLi", mySqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员相片
        [OperationContract]
        public byte[] SelectJiaShiYuanXianPian(int DriverID)
        {
            SqlParameter[] mySqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@DriverID",SqlDbType.Int)
            };
            mySqlParameters[0].Value = "SelectJiaShiYuanXianPian";
            mySqlParameters[1].Value = DriverID;
            return myDALMethod.QueryDataByte("FRM_BaoBanGuanLi", mySqlParameters);
        }
        #endregion

        #region 查询副驾驶员相片
        [OperationContract]
        public byte[] SelectFuJiaShiYuanXianPian(int DriverID)
        {
            SqlParameter[] mySqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@DriverID",SqlDbType.Int)
            };
            mySqlParameters[0].Value = "SelectFuJiaShiYuanXianPian";
            mySqlParameters[1].Value = DriverID;
            return myDALMethod.QueryDataByte("FRM_BaoBanGuanLi", mySqlParameters);
        }
        #endregion

        #region 新增报班信息
        [OperationContract]
        public int InsertBaoBanXinXi(
            int FrequencyID,
            bool WhetherNnSchedule, 
            bool WhetherLate, 
            bool StayClassVehicleNo, 
            string Comment)
        {
            SqlParameter[] mySqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@FrequencyID",SqlDbType.Int),
                new SqlParameter("@WhetherNnSchedule",SqlDbType.Bit),
                new SqlParameter("@WhetherLate",SqlDbType.Bit),
                new SqlParameter("@StayClassVehicleNo",SqlDbType.Bit),
                new SqlParameter("@Comment",SqlDbType.NChar)
            };
            mySqlParameters[0].Value = "InsertBaoBanXinXi";
            mySqlParameters[1].Value = FrequencyID;
            mySqlParameters[2].Value = WhetherNnSchedule;
            mySqlParameters[3].Value = WhetherLate;
            mySqlParameters[4].Value = StayClassVehicleNo;
            mySqlParameters[5].Value = Comment;
            int result = myDALMethod.UpdateData("FRM_BaoBanGuanLi", mySqlParameters);
            return result;
        }
        #endregion

        #region 修改车辆状态
        [OperationContract]
        public int UpdateVehicleState(int VehicleID)
        {
            SqlParameter[] mySqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@VehicleID",SqlDbType.Int)
            };
            mySqlParameters[0].Value = "UpdateVehicleState";
            mySqlParameters[1].Value = VehicleID;
            int result = myDALMethod.UpdateData("FRM_BaoBanGuanLi", mySqlParameters);
            return result;
        }
        #endregion
    }
}
