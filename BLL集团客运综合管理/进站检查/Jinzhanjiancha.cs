using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.进站检查
{
    [ServiceContract]
    class Jinzhanjiancha
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]//查询安全检查项目
        public DataSet selectanquanjianxianmghu()
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "selectanquanjianxianmghu";
            DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//新增检查明细
        public int INSERTInspectionItemmingxi(int  CarriageInspectionShedID,int  InspectionItemID,bool  YON,string Comments)
        {
            SqlParameter[] sqlPas = {
                new SqlParameter("@SN",SqlDbType.NChar  ),
                new SqlParameter("@CarriageInspectionShedID",SqlDbType.Int  ),
                new SqlParameter("@InspectionItemID",SqlDbType.Int  ),
                new SqlParameter("@YON",SqlDbType.Bit  ),
                new SqlParameter("@Comments",SqlDbType.NChar  ),

                }; 
                 sqlPas[0].Value = "INSERTInspectionItemmingxi";
            sqlPas[1].Value = CarriageInspectionShedID;
            sqlPas[2].Value = InspectionItemID;
            sqlPas[3].Value = YON;
            sqlPas[4].Value = Comments;
    int dt = myDAL.UpdateData("CarSaveCheak", sqlPas);
            return dt;
        }
        [OperationContract]//新增检查单 
        public int insectjianchadan(int  VehicleID, int UserTypeID, int CarBelongToTheUnitID, int CreateUserID, int DeleteUserID,string  TheDriverSignature,string  PlateNumber,
              int   VehicleTypeID,int  CompetaterID,DateTime Youxiaodate,bool  YON)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar  ),
                    new SqlParameter("@VehicleID", SqlDbType.Int   ),
                    new SqlParameter("@UserTypeID", SqlDbType.Int  ),
                    new SqlParameter("@CarBelongToTheUnitID", SqlDbType.Int  ),
                    new SqlParameter("@CreateUserID", SqlDbType.Int  ),
                    new SqlParameter("@DeleteUserID", SqlDbType.Int  ),
                    new SqlParameter("@TheDriverSignature", SqlDbType.NChar  ),
                    new SqlParameter("@PlateNumber", SqlDbType.NChar  ),
                    new SqlParameter("@VehicleTypeID", SqlDbType.Int  ),
                    new SqlParameter("@CompetaterID", SqlDbType.Int  ),
                    new SqlParameter("@Youxiaodate", SqlDbType.DateTime  ),
                    new SqlParameter("@YON",SqlDbType.Bit),
                    };  
                    sqlPas[0].Value = "insectjianchadan";
                    sqlPas[1].Value = VehicleID;
                    sqlPas[2].Value = UserTypeID;
                    sqlPas[3].Value = CarBelongToTheUnitID;
                    sqlPas[4].Value = CreateUserID;
                    sqlPas[5].Value = DeleteUserID;
                    sqlPas[6].Value = TheDriverSignature;
                    sqlPas[7].Value = PlateNumber;
                    sqlPas[8].Value = VehicleTypeID;
                    sqlPas[9].Value = CompetaterID;
                    sqlPas[10].Value = Youxiaodate;
                    sqlPas[11].Value = YON;
             DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            int I = Convert.ToInt32(dt.Rows[0][0]);
            return I;
        }
        [OperationContract]//查询车辆
        public DataSet CarSaveCheak_Selectchelaing()
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "CarSaveCheak_Selectchelaing";
            DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车辆
        public DataSet SelectCheLiangXinXiOnchepaihao(string PlateNumber)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                       new SqlParameter("@PlateNumber",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "SelectCheLiangXinXiOnchepaihao";
            sqlPas[1].Value = PlateNumber;
          DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车型
        public DataSet SELECTCEXINGONCHEPIHAO(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                       new SqlParameter("@VehicleID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "SELECTCEXINGONCHEPIHAO";
            sqlPas[1].Value = VehicleID;
            DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车型
        public DataSet CarSaveCheak_selectcheshudanwei(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                       new SqlParameter("@VehicleID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "CarSaveCheak_selectcheshudanwei";
            sqlPas[1].Value = VehicleID;
            DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询安检员
        public DataSet CarSaveCheak_selectjichayuan( )
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "CarSaveCheak_selectjichayuan";
            DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//修改车辆状态
        public int  CarSaveCheak_updatechelaingzhuangtai(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                       new SqlParameter("@VehicleID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "CarSaveCheak_updatechelaingzhuangtai";
            sqlPas[1].Value = VehicleID;
       int  dt = myDAL.UpdateData("CarSaveCheak", sqlPas);
          
            return dt ;
        }
        [OperationContract]//查询安检员
        public DataSet selectdongtaijianchadan(string PlateNumber)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        new SqlParameter("@PlateNumber",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "selectdongtaijianchadan";
            sqlPas[1].Value = PlateNumber;
         DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询安检员
        public DataSet selectmnigxi(int  CarriageInspectionShedID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        new SqlParameter("@CarriageInspectionShedID",SqlDbType.Int ),
                        };
            sqlPas[0].Value = "selectmnigxi";
            sqlPas[1].Value = CarriageInspectionShedID;
            DataTable dt = myDAL.QueryDataTable("CarSaveCheak", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
