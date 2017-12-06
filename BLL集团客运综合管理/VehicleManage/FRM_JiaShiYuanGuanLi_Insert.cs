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
    class FRM_JiaShiYuanGuanLi_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询准驾车型
        [OperationContract]
        public DataSet SelectQuasiDrivingType()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectQuasiDrivingType";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询机构组织
        [OperationContract]
        public DataSet SelectOrganization()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectOrganization";
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 新增一条司机信息
        [OperationContract]
        public int InsertJiaShiYuanXinXi(
            int QuasiDrivingTypeID,
            int OrganizationID,
            int CreateUserID,
            int DeleteUserID,
            string DriverMC,
            string Sex,
            string Identification,
            string ContactPhone,
            int DriveAge,
            string DrivingLicenseNo,
            string DriverNumber,
            string Certificate,
            DateTime DrivingLicence,
            DateTime licensePeriod,
            string DriverVehicleNumber,
            DateTime CertificateLicence,
            byte[] Photo,
            string Comment,
            bool JobON,
            DateTime CreateTime,
            DateTime LogicalDeleteTime)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@QuasiDrivingTypeID",SqlDbType.Int),
                new SqlParameter("@OrganizationID",SqlDbType.Int),
                new SqlParameter("@CreateUserID",SqlDbType.Int),
                new SqlParameter("@DeleteUserID",SqlDbType.Int),
                new SqlParameter("@DriverMC",SqlDbType.NChar),
                new SqlParameter("@Sex",SqlDbType.NChar),
                new SqlParameter("@Identification",SqlDbType.NChar),
                new SqlParameter("@ContactPhone",SqlDbType.NChar),
                new SqlParameter("@DriveAge",SqlDbType.Int),
                new SqlParameter("@DrivingLicenseNo",SqlDbType.NChar),
                new SqlParameter("@DriverNumber",SqlDbType.NChar),
                new SqlParameter("@Certificate",SqlDbType.NChar),
                new SqlParameter("@DrivingLicence",SqlDbType.Date),
                new SqlParameter("@licensePeriod",SqlDbType.Date),
                new SqlParameter("@DriverVehicleNumber",SqlDbType.NChar),
                new SqlParameter("@CertificateLicence",SqlDbType.Date),
                new SqlParameter("@Photo",SqlDbType.Image),
                new SqlParameter("@Comment",SqlDbType.NChar),
                new SqlParameter("@JobON",SqlDbType.Bit),
                new SqlParameter("@CreateTime",SqlDbType.DateTime),
                new SqlParameter("@LogicalDeleteTime",SqlDbType.DateTime)

            };
            SqlParameters[0].Value = "InsertJiaShiYuanXinXi";
            SqlParameters[1].Value = QuasiDrivingTypeID;
            SqlParameters[2].Value = OrganizationID;
            SqlParameters[3].Value = CreateUserID;
            SqlParameters[4].Value = DeleteUserID;
            SqlParameters[5].Value = DriverMC;
            SqlParameters[6].Value = Sex;
            SqlParameters[7].Value = Identification;
            SqlParameters[8].Value = ContactPhone;
            SqlParameters[9].Value = DriveAge;
            SqlParameters[10].Value = DrivingLicenseNo;
            SqlParameters[11].Value = DriverNumber;
            SqlParameters[12].Value = Certificate;
            SqlParameters[13].Value = DrivingLicence;
            SqlParameters[14].Value = licensePeriod;
            SqlParameters[15].Value = DriverVehicleNumber;
            SqlParameters[16].Value = CertificateLicence;
            SqlParameters[17].Value = Photo;
            SqlParameters[18].Value = Comment;
            SqlParameters[19].Value = JobON;
            SqlParameters[20].Value = CreateTime;
            SqlParameters[21].Value = LogicalDeleteTime;
            int result = myDALMethod.UpdateData("FRM_JiaShiYuanGuanLi_Insert", SqlParameters);
            return result;
        }
        #endregion


        [OperationContract]
        public int SELECT(byte[] Photo)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@Photo",SqlDbType.Image)
            };
            SqlParameters[0].Value = "SELECT";
            SqlParameters[1].Value = Photo;
            int result = myDALMethod.UpdateData("FRM_JiaShiYuanGuanLi_Insert", SqlParameters);
            return result;
        }
    }
}
