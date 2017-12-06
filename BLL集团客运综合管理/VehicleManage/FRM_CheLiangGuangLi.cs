using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.VehicleManage
{
    [ServiceContract]
    class FRM_CheLiangGuangLi
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询车辆编号
        [OperationContract]
        public DataSet SelectCheLiangBianHao()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCheLiangBianHao";
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车辆信息
        [OperationContract]
        public DataSet SelectCheLiangXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCheLiangXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车辆信息通过车牌号
        [OperationContract]
        public DataSet SelectCheLiangXinXiByVehiclePaiNumber(string VehiclePaiNumber)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehiclePaiNumber",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCheLiangXinXiByVehiclePaiNumber";
            SqlParameters[1].Value = VehiclePaiNumber;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车辆信息通过车辆编号
        [OperationContract]
        public DataSet SelectCheLiangXinXiByVehicleNumber(string VehicleNumber)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleNumber",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCheLiangXinXiByVehicleNumber";
            SqlParameters[1].Value = VehicleNumber;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车辆明细信息
        [OperationContract]
        public DataSet SelectCheLiangMingXiXinXi(int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectCheLiangMingXiXinXi";
            SqlParameters[1].Value = VehicleID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 删除车主信息
        [OperationContract]
        public int DeleteCheZhuXinXi(int VehicleHostID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleHostID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteCheZhuXinXi";
            SqlParameters[1].Value = VehicleHostID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi", SqlParameters);
            return result;
        }
        #endregion

        #region 删除保险信息
        [OperationContract]
        public int DeleteBaoXianXinXi(int PolicyOfInsuranceID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@PolicyOfInsuranceID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteBaoXianXinXi";
            SqlParameters[1].Value = PolicyOfInsuranceID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi", SqlParameters);
            return result;
        }
        #endregion

        #region 删除车辆证件信息
        [OperationContract]
        public int DeleteCheLiangZhengJianXinXi(int VehicleLicenseID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleLicenseID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteCheLiangZhengJianXinXi";
            SqlParameters[1].Value = VehicleLicenseID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi", SqlParameters);
            return result;
        }
        #endregion

        #region 删除车辆信息
        [OperationContract]
        public int DeleteCheLiangXinXi(
            int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteCheLiangXinXi";
            SqlParameters[1].Value = VehicleID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi", SqlParameters);
            return result;
        }
        #endregion

        #region 删除席位信息
        [OperationContract]
        public int DeleteXiWei(int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "DeleteXiWei";
            SqlParameters[1].Value = VehicleID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi", SqlParameters);
            return result;
        }
        #endregion
    }
}
