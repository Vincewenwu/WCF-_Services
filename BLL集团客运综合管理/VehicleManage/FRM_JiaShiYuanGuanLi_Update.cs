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
    class FRM_JiaShiYuanGuanLi_Update
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi_Update", SqlParameters);
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
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi_Update", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询驾驶员信息通过驾驶员ID
        [OperationContract]
        public DataSet SelectJiaShiYuanXinXiByDriverID(int DriverID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@DriverID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "SelectJiaShiYuanXinXiByDriverID";
            SqlParameters[1].Value = DriverID;
            DataTable dt = myDALMethod.QueryDataTable("FRM_JiaShiYuanGuanLi_Update", SqlParameters);
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
            return myDALMethod.QueryDataByte("FRM_JiaShiYuanGuanLi_Update", SqlParameters);
        }
        #endregion

        #region 修改驾驶员信息
        [OperationContract]
        public int UpdateDriverXinXi(
            int QuasiDrivingTypeID,
            int OrganizationID,
            string ContactPhone,
            int DriveAge,
            string DrivingLicenseNo,
            string DriverNumber,
            string Certificate,
            DateTime DrivingLicence,
            DateTime licensePeriod,
            string DriverVehicleNumber,
            DateTime CertificateLicence,
            string Comment,
            byte[] Photo,
            int DriverID,
            string DriverMC, 
            string Sex, 
            string Identification)
        {
            SqlParameter[] SqlParameters =
            {
                new SqlParameter("@TYPE",SqlDbType.NChar),
                new SqlParameter("@QuasiDrivingTypeID",SqlDbType.Int),
                new SqlParameter("@OrganizationID",SqlDbType.Int),
                new SqlParameter("@ContactPhone",SqlDbType.NChar),
                new SqlParameter("@DriveAge",SqlDbType.Int),
                new SqlParameter("@DrivingLicenseNo",SqlDbType.NChar),
                new SqlParameter("@DriverNumber",SqlDbType.NChar),
                new SqlParameter("@Certificate",SqlDbType.NChar),
                new SqlParameter("@DrivingLicence",SqlDbType.Date),
                new SqlParameter("@licensePeriod",SqlDbType.Date),
                new SqlParameter("@DriverVehicleNumber",SqlDbType.NChar),
                new SqlParameter("@CertificateLicence",SqlDbType.Date),
                new SqlParameter("@Comment",SqlDbType.NChar),
                new SqlParameter("@Photo",SqlDbType.Image),
                new SqlParameter("@DriverID",SqlDbType.Int),
                new SqlParameter("@DriverMC",SqlDbType.NChar),
                new SqlParameter("@Sex",SqlDbType.NChar),
                new SqlParameter("@Identification",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "UpdateDriverXinXi";
            SqlParameters[1].Value = QuasiDrivingTypeID;
            SqlParameters[2].Value = OrganizationID;
            SqlParameters[3].Value = ContactPhone;
            SqlParameters[4].Value = DriveAge;
            SqlParameters[5].Value = DrivingLicenseNo;
            SqlParameters[6].Value = DriverNumber;
            SqlParameters[7].Value = Certificate;
            SqlParameters[8].Value = DrivingLicence;
            SqlParameters[9].Value = licensePeriod;
            SqlParameters[10].Value = DriverVehicleNumber;
            SqlParameters[11].Value = CertificateLicence;
            SqlParameters[12].Value = Comment;
            SqlParameters[13].Value = Photo;
            SqlParameters[14].Value = DriverID;
            SqlParameters[15].Value = DriverMC;
            SqlParameters[16].Value = Sex;
            SqlParameters[17].Value = Identification;
            int result = myDALMethod.UpdateData("FRM_JiaShiYuanGuanLi_Update", SqlParameters);
            return result;
        }
        #endregion
    }
}
