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
    class FRM_CheLiangGuangLi_Update
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询驾驶员编号
        [OperationContract]
        public DataSet SelectDriverNumber()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectDriverNumber";
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员通过驾驶员编号
        [OperationContract]
        public DataSet SelectJiaShiYuanByDriverNumber(string DriverNumber)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@DriverNumber",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanByDriverNumber";
            SqlParameters[1].Value = DriverNumber;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询承保公司
        [OperationContract]
        public DataSet SelectChengBaoGonSi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectChengBaoGonSi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车属单位
        [OperationContract]
        public DataSet SelectCheShuDangWei()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCheShuDangWei";
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车辆类型
        [OperationContract]
        public DataSet SelectCheLiangLeiXing()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectCheLiangLeiXing";
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询车辆信息通过车辆ID
        [OperationContract]
        public DataSet SelectCheLiangXinXiByVehicleID(int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectCheLiangXinXiByVehicleID";
            SqlParameters[1].Value = VehicleID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 修改车辆信息
        [OperationContract]
        public int UpdateCheLiangXinXi(
            int VehicleTypeID,
            int CarBelongToTheUnitID, 
            int DriverID,
            int DriverAssistantID, 
            string VehiclePaiNumber, 
            string VehicleNumber,
            DateTime RegisterDate,
            bool SafeInspectNo,
            bool EverySkySafeInspect,
            bool OneSkySafeInspectOneNext, 
            string Comment,
            int VehicleID,
            string Loadheaver)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleTypeID",SqlDbType.Int),
                   new SqlParameter("@CarBelongToTheUnitID",SqlDbType.Int),
                   new SqlParameter("@DriverID",SqlDbType.Int),
                   new SqlParameter("@DriverAssistantID",SqlDbType.Int),
                   new SqlParameter("@VehiclePaiNumber",SqlDbType.NChar),
                   new SqlParameter("@VehicleNumber",SqlDbType.NChar),
                   new SqlParameter("@RegisterDate",SqlDbType.Date),
                   new SqlParameter("@SafeInspectNo",SqlDbType.Bit),
                   new SqlParameter("@EverySkySafeInspect",SqlDbType.Bit),
                   new SqlParameter("@OneSkySafeInspectOneNext",SqlDbType.Bit),
                   new SqlParameter("@Comment",SqlDbType.NChar),
                   new SqlParameter("@VehicleID",SqlDbType.Int),
                   new SqlParameter("@Loadheaver",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "UpdateCheLiangXinXi";
            SqlParameters[1].Value = VehicleTypeID;
            SqlParameters[2].Value = CarBelongToTheUnitID;
            SqlParameters[3].Value = DriverID;
            SqlParameters[4].Value = DriverAssistantID;
            SqlParameters[5].Value = VehiclePaiNumber;
            SqlParameters[6].Value = VehicleNumber;
            SqlParameters[7].Value = RegisterDate;
            SqlParameters[8].Value = SafeInspectNo;
            SqlParameters[9].Value = EverySkySafeInspect;
            SqlParameters[10].Value = OneSkySafeInspectOneNext;
            SqlParameters[11].Value = Comment;
            SqlParameters[12].Value = VehicleID;
            SqlParameters[13].Value = Loadheaver;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi_Update", SqlParameters);
            return result;
        }
        #endregion

        #region 修改车主信息
        [OperationContract]
        public int UpdateCheZhuXinXi(
            string VehicleHostMC, 
            string Address, 
            string ContactPhone, 
            string Identification,
            int VehicleHostID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@VehicleHostMC",SqlDbType.NChar),
                   new SqlParameter("@Address",SqlDbType.NChar),
                   new SqlParameter("@ContactPhone",SqlDbType.NChar),
                   new SqlParameter("@Identification",SqlDbType.NChar),
                   new SqlParameter("@VehicleHostID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "UpdateCheZhuXinXi";
            SqlParameters[1].Value = VehicleHostMC;
            SqlParameters[2].Value = Address;
            SqlParameters[3].Value = ContactPhone;
            SqlParameters[4].Value = Identification;
            SqlParameters[5].Value = VehicleHostID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi_Update", SqlParameters);
            return result;
        }
        #endregion

        #region 修改保险信息
        [OperationContract]
        public int UpdateBaoXianXinXi(
            int UnderwriteCompanyID,
            string PolicyOfInsuranceMC, 
            DateTime BookbuildingDate,
            DateTime Drivenvehicle,
            DateTime CommercialUnderwritingExecutive,
            DateTime Bearingonetransportrisk,
            int PolicyOfInsuranceID)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@UnderwriteCompanyID",SqlDbType.Int),
                new SqlParameter("@PolicyOfInsuranceMC",SqlDbType.NChar),
                new SqlParameter("@BookbuildingDate",SqlDbType.Date),
                new SqlParameter("@Drivenvehicle",SqlDbType.Date),
                new SqlParameter("@CommercialUnderwritingExecutive",SqlDbType.Date),
                new SqlParameter("@Bearingonetransportrisk",SqlDbType.Date),
                new SqlParameter("@PolicyOfInsuranceID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "UpdateBaoXianXinXi";
            SqlParameters[1].Value = UnderwriteCompanyID;
            SqlParameters[2].Value = PolicyOfInsuranceMC;
            SqlParameters[3].Value = BookbuildingDate;
            SqlParameters[4].Value = Drivenvehicle;
            SqlParameters[5].Value = CommercialUnderwritingExecutive;
            SqlParameters[6].Value = Bearingonetransportrisk;
            SqlParameters[7].Value = PolicyOfInsuranceID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi_Update", SqlParameters);
            return result;
        }
        #endregion

        #region 修改证件信息
        [OperationContract]
        public int UpdateZhengJianXinXi(
            string BusinessLine,
            string LineNumber,
            string AttachedCardNumber,
            string OperationOfTheNumber, 
            DateTime Validity,
            DateTime SpringRecords,
            DateTime InspectionRecords,
            DateTime CompleteMaintenance,
            DateTime Rating,
            DateTime TravelCard,
            DateTime MonthMaintainSun,
            DateTime LiquefiedPetroleumGasCard,
            int VehicleLicenseID)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@BusinessLine",SqlDbType.NChar),
                new SqlParameter("@LineNumber",SqlDbType.NChar),
                new SqlParameter("@AttachedCardNumber",SqlDbType.NChar),
                new SqlParameter("@OperationOfTheNumber",SqlDbType.NChar),
                new SqlParameter("@Validity",SqlDbType.NChar),
                new SqlParameter("@SpringRecords",SqlDbType.NChar),
                new SqlParameter("@InspectionRecords",SqlDbType.NChar),
                new SqlParameter("@CompleteMaintenance",SqlDbType.NChar),
                new SqlParameter("@Rating",SqlDbType.NChar),
                new SqlParameter("@TravelCard",SqlDbType.NChar),
                new SqlParameter("@MonthMaintainSun",SqlDbType.NChar),
                new SqlParameter("@LiquefiedPetroleumGasCard",SqlDbType.NChar),
                new SqlParameter("@VehicleLicenseID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "UpdateZhengJianXinXi";
            SqlParameters[1].Value = BusinessLine;
            SqlParameters[2].Value = LineNumber;
            SqlParameters[3].Value = AttachedCardNumber;
            SqlParameters[4].Value = OperationOfTheNumber;
            SqlParameters[5].Value = Validity;
            SqlParameters[6].Value = SpringRecords;
            SqlParameters[7].Value = InspectionRecords;
            SqlParameters[8].Value = CompleteMaintenance;
            SqlParameters[9].Value = Rating;
            SqlParameters[10].Value = TravelCard;
            SqlParameters[11].Value = MonthMaintainSun;
            SqlParameters[12].Value = LiquefiedPetroleumGasCard;
            SqlParameters[13].Value = VehicleLicenseID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi_Update", SqlParameters);
            return result;
        }
        #endregion

    }
}
