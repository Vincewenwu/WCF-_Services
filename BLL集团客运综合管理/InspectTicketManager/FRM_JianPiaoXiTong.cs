using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.InspectTicketManager
{
    [ServiceContract]
    class FRM_JianPiaoXiTong
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询车辆编号
        [OperationContract]
        public DataSet SelectCheLiangBianHao(/*int VehicleID*/)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
                   //new SqlParameter("@VehicleID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectCheLiangBianHao";
            //SqlParameters[1].Value = VehicleID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车辆通过车辆编号
        [OperationContract]
        public DataSet SelectCheLiangByCheLiangBianHao(string VehicleNumber)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                    new SqlParameter("@VehicleNumber",SqlDbType.NChar),
            };
            SqlParameters[0].Value = "SelectCheLiangByCheLiangBianHao";
            SqlParameters[1].Value = VehicleNumber;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查找车辆席位状态
        [OperationContract]
        public DataSet SelectCheLiangXiWeiZhangTai(int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                    new SqlParameter("@VehicleID",SqlDbType.Int),
            };
            SqlParameters[0].Value = "SelectCheLiangXiWeiZhangTai";
            SqlParameters[1].Value = VehicleID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询待检车辆
        [OperationContract]
        public DataSet SelectDaiJianCheLiang( )
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
            };
            SqlParameters[0].Value = "SelectDaiJianCheLiang";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询检票信息
        [OperationContract]
        public DataSet SelectJianPiaoXinXi(string TicketMark,int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@TicketMark",SqlDbType.NChar),
                   new SqlParameter("@VehicleID",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectJianPiaoXinXi";
            SqlParameters[1].Value = TicketMark;
            SqlParameters[2].Value = VehicleID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询报班信息
        [OperationContract]
        public DataSet SelectBaoBanXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectBaoBanXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 修改席位状态
        [OperationContract]
        public int UpdateSeatsState(int SeatsID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@SeatsID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "UpdateSeatsState";
            SqlParameters[1].Value = SeatsID;
            int result = myDALMethod.UpdateData("FRM_JianPiaoXiTong", SqlParameters);
            return result;
        }
        #endregion

        #region 查询票号通过车辆ID
        [OperationContract]
        public DataSet SelectPiaoHaoByCheLiangID(int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectPiaoHaoByCheLiangID";
            SqlParameters[1].Value = VehicleID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion



        //#region 
        //[OperationContract]
        //public DataSet SelectYiJianBanCi(int VehicleStateID)
        //{
        //    SqlParameter[] SqlParameters =
        //    {
        //           new SqlParameter("@TYPE",SqlDbType.NChar),
        //           new SqlParameter("@VehicleStateID",SqlDbType.Int)
        //    };
        //    SqlParameters[0].Value = "SelectYiJianBanCi";
        //    SqlParameters[1].Value = VehicleStateID;
        //    DataTable dt = myDALMethod.QueryDataTable("FRM_JianPiaoXiTong", SqlParameters);
        //    DataSet ds = new DataSet();
        //    ds.Tables.Add(dt);
        //    return ds;
        //}
        //#endregion
    }
}
