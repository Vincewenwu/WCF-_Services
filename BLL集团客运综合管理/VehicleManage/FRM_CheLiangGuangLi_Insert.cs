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
    class FRM_CheLiangGuangLi_Insert
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 新增一条车辆信息
        [OperationContract]
        public int InsertCheLiangXinXi(
            int VehicleHostID,
            int VehicleTypeID,
            int CarBelongToTheUnitID,
            int VehicleStateID,
            int PolicyOfInsuranceID,
            int VehicleLicenseID,
            int DriverID,
            int DriverAssistantID,
            int CreateUserID,
            int DeleteUserID, 
            string VehicleNumber,
            string VehiclePaiNumber, 
            DateTime RegisterDate,
            string Seating,
            string Loadheaver,
            bool SafeInspectNo, 
            bool EverySkySafeInspect,
            bool OneSkySafeInspectOneNext,
            string Comment,
            DateTime CreateTime,
            DateTime LogicalDeleteTime
           )
        {
            SqlParameter[] SqlParameters =
            {
                    new SqlParameter("@TYPE",SqlDbType.NChar),
                    new SqlParameter("@VehicleHostID",SqlDbType.Int),
                    new SqlParameter("@VehicleTypeID",SqlDbType.Int),
                    new SqlParameter("@CarBelongToTheUnitID",SqlDbType.Int),
                    new SqlParameter("@VehicleStateID",SqlDbType.Int),
                    new SqlParameter("@PolicyOfInsuranceID",SqlDbType.Int),
                    new SqlParameter("@VehicleLicenseID",SqlDbType.Int),
                    new SqlParameter("@DriverID",SqlDbType.Int),
                    new SqlParameter("@DriverAssistantID",SqlDbType.Int),
                    new SqlParameter("@CreateUserID",SqlDbType.Int),
                    new SqlParameter("@DeleteUserID",SqlDbType.Int),
                    new SqlParameter("@VehicleNumber",SqlDbType.NChar),
                    new SqlParameter("@VehiclePaiNumber",SqlDbType.NChar),
                    new SqlParameter("@RegisterDate",SqlDbType.Date),
                    new SqlParameter("@Seating",SqlDbType.NChar),
                    new SqlParameter("@Loadheaver",SqlDbType.NChar),
                    new SqlParameter("@SafeInspectNo",SqlDbType.Bit),
                    new SqlParameter("@EverySkySafeInspect",SqlDbType.Bit),
                    new SqlParameter("@OneSkySafeInspectOneNext",SqlDbType.Bit),
                    new SqlParameter("@Comment",SqlDbType.NChar),
                    new SqlParameter("@CreateTime",SqlDbType.DateTime),
                    new SqlParameter("@LogicalDeleteTime",SqlDbType.DateTime),
                };
            SqlParameters[0].Value = "InsertCheLiangXinXi";
            SqlParameters[1].Value = VehicleHostID;
            SqlParameters[2].Value = VehicleTypeID;
            SqlParameters[3].Value = CarBelongToTheUnitID;
            SqlParameters[4].Value = VehicleStateID;
            SqlParameters[5].Value = PolicyOfInsuranceID;
            SqlParameters[6].Value = VehicleLicenseID;
            SqlParameters[7].Value = DriverID;
            SqlParameters[8].Value = DriverAssistantID;
            SqlParameters[9].Value = CreateUserID;
            SqlParameters[10].Value = DeleteUserID;
            SqlParameters[11].Value = VehicleNumber;
            SqlParameters[12].Value = VehiclePaiNumber;
            SqlParameters[13].Value = RegisterDate;
            SqlParameters[14].Value = Seating;
            SqlParameters[15].Value = Loadheaver;
            SqlParameters[16].Value = SafeInspectNo;
            SqlParameters[17].Value = EverySkySafeInspect;
            SqlParameters[18].Value = OneSkySafeInspectOneNext;
            SqlParameters[19].Value = Comment;
            SqlParameters[20].Value = CreateTime;
            SqlParameters[21].Value = LogicalDeleteTime;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
            int rault = Convert.ToInt32(dt.Rows[0][0]);
            return rault;
        }
        #endregion

        #region 新增保险信息
        [OperationContract]
        public int InsertBaoXian(
           int UnderwriteCompanyID,
           int CreateUserID,
           int DeleteUserID, 
           string PolicyOfInsuranceMC, 
           DateTime BookbuildingDate,
           DateTime Drivenvehicle,
           DateTime CommercialUnderwritingExecutive,
           DateTime Bearingonetransportrisk,
           DateTime CreateTime,
           DateTime LogicalDeleteTime
          )
        {
            SqlParameter[] SqlParameters =
            {
                    new SqlParameter("@TYPE",SqlDbType.NChar),
                    new SqlParameter("@UnderwriteCompanyID",SqlDbType.Int),
                    new SqlParameter("@CreateUserID",SqlDbType.Int),
                    new SqlParameter("@DeleteUserID",SqlDbType.Int),
                    new SqlParameter("@PolicyOfInsuranceMC",SqlDbType.NChar),
                    new SqlParameter("@BookbuildingDate",SqlDbType.Date),
                    new SqlParameter("@Drivenvehicle",SqlDbType.Date),
                    new SqlParameter("@CommercialUnderwritingExecutive",SqlDbType.Date),
                    new SqlParameter("@Bearingonetransportrisk",SqlDbType.Date),
                    new SqlParameter("@CreateTime",SqlDbType.DateTime),
                    new SqlParameter("@LogicalDeleteTime",SqlDbType.DateTime)
                };
            SqlParameters[0].Value = "InsertBaoXian";
            SqlParameters[1].Value = UnderwriteCompanyID;
            SqlParameters[2].Value = CreateUserID;
            SqlParameters[3].Value = DeleteUserID;
            SqlParameters[4].Value = PolicyOfInsuranceMC;
            SqlParameters[5].Value = BookbuildingDate;
            SqlParameters[6].Value = Drivenvehicle;
            SqlParameters[7].Value = CommercialUnderwritingExecutive;
            SqlParameters[8].Value = Bearingonetransportrisk;
            SqlParameters[9].Value = CreateTime;
            SqlParameters[10].Value = LogicalDeleteTime;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
            int rault = Convert.ToInt32(dt.Rows[0][0]);
            return rault;
        }
        #endregion

        #region 新增车辆证件信息
        [OperationContract]
        public int InsertCheLiangZhengJianXingXi(
            int CreateUserID, 
            int DeleteUserID,
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
            DateTime CreateTime, 
            DateTime LogicalDeleteTime)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@CreateUserID",SqlDbType.Int),
                new SqlParameter("@DeleteUserID",SqlDbType.Int),
                new SqlParameter("@BusinessLine",SqlDbType.NChar),
                new SqlParameter("@LineNumber",SqlDbType.NChar),
                new SqlParameter("@AttachedCardNumber",SqlDbType.NChar),
                new SqlParameter("@OperationOfTheNumber",SqlDbType.NChar),
                new SqlParameter("@Validity",SqlDbType.Date),
                new SqlParameter("@SpringRecords",SqlDbType.Date),
                new SqlParameter("@InspectionRecords",SqlDbType.Date),
                new SqlParameter("@CompleteMaintenance",SqlDbType.Date),
                new SqlParameter("@Rating",SqlDbType.Date),
                new SqlParameter("@TravelCard",SqlDbType.Date),
                new SqlParameter("@MonthMaintainSun",SqlDbType.Date),
                new SqlParameter("@LiquefiedPetroleumGasCard",SqlDbType.Date),
                new SqlParameter("@CreateTime",SqlDbType.DateTime),
                new SqlParameter("@LogicalDeleteTime",SqlDbType.DateTime)
            };
            SqlParameters[0].Value = "InsertCheLiangZhengJianXingXi";
            SqlParameters[1].Value = CreateUserID;
            SqlParameters[2].Value = DeleteUserID;
            SqlParameters[3].Value = BusinessLine;
            SqlParameters[4].Value = LineNumber;
            SqlParameters[5].Value = AttachedCardNumber;
            SqlParameters[6].Value = OperationOfTheNumber;
            SqlParameters[7].Value = Validity;
            SqlParameters[8].Value = SpringRecords;
            SqlParameters[9].Value = InspectionRecords;
            SqlParameters[10].Value = CompleteMaintenance;
            SqlParameters[11].Value = Rating;
            SqlParameters[12].Value = TravelCard;
            SqlParameters[13].Value = MonthMaintainSun;
            SqlParameters[14].Value = LiquefiedPetroleumGasCard;
            SqlParameters[15].Value = CreateTime;
            SqlParameters[16].Value = LogicalDeleteTime;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
            int rault = Convert.ToInt32(dt.Rows[0][0]);
            return rault;
        }
        #endregion

        #region 新增车主
        [OperationContract]
        public int InsertCheZhu(
            int CreateUserID, 
            int DeleteUserID, 
            string VehicleHostMC,
            string Address,
            string ContactPhone,
            string Identification, 
            DateTime CreateTime,
            DateTime LogicalDeleteTime)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@CreateUserID",SqlDbType.Int),
                new SqlParameter("@DeleteUserID",SqlDbType.Int),
                new SqlParameter("@VehicleHostMC",SqlDbType.NChar),
                new SqlParameter("@Address",SqlDbType.NChar),
                new SqlParameter("@ContactPhone",SqlDbType.NChar),
                new SqlParameter("@Identification",SqlDbType.NChar),
                new SqlParameter("@CreateTime",SqlDbType.DateTime),
                new SqlParameter("@LogicalDeleteTime",SqlDbType.DateTime)
             };
            SqlParameters[0].Value = "InsertCheZhu";
            SqlParameters[1].Value = CreateUserID;
            SqlParameters[2].Value = DeleteUserID;
            SqlParameters[3].Value = VehicleHostMC;
            SqlParameters[4].Value = Address;
            SqlParameters[5].Value = ContactPhone;
            SqlParameters[6].Value = Identification;
            SqlParameters[7].Value = CreateTime;
            SqlParameters[8].Value = LogicalDeleteTime;
            DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
            int rault = Convert.ToInt32(dt.Rows[0][0]);
            return rault;
        }
        #endregion

        #region 新增席位信息
        [OperationContract]
        public int InsertXiWei(int VehicleID, int SeatsTypeID, int SeatsStateID, int SeatNoMC, bool UseNo,
             int CreateUserID,int DeleteUserID)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@VehicleID",SqlDbType.Int),
                new SqlParameter("@SeatsTypeID",SqlDbType.Int),
                new SqlParameter("@SeatsStateID",SqlDbType.Int),
                new SqlParameter("@SeatNoMC",SqlDbType.Int),
                new SqlParameter("@UseNo",SqlDbType.Bit),
                new SqlParameter("@CreateUserID",SqlDbType.Int),
                new SqlParameter("@DeleteUserID",SqlDbType.Int)
             };
            SqlParameters[0].Value = "InsertXiWei";
            SqlParameters[1].Value = VehicleID;
            SqlParameters[2].Value = SeatsTypeID;
            SqlParameters[3].Value = SeatsStateID;
            SqlParameters[4].Value = SeatNoMC;
            SqlParameters[5].Value = UseNo;
            SqlParameters[6].Value = CreateUserID;
            SqlParameters[7].Value = DeleteUserID;
            int result = myDALMethod.UpdateData("FRM_CheLiangGuangLi_Insert", SqlParameters);
            return result;
        }
        #endregion

        #region 查询席位个数
        [OperationContract]
        public DataSet SelectXiweigeshu( int VehicleID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                    new SqlParameter("@VehicleID",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectXiweigeshu";
            SqlParameters[1].Value = VehicleID;
           DataTable dt = myDALMethod.QueryDataTable("FRM_CheLiangGuangLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion
    }
}




