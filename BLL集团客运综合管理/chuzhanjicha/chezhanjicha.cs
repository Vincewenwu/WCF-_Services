using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.chuzhanjicha
{
    [ServiceContract]
    class chezhanjicha
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]//查询车辆
        public DataSet Selectchelaing()
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "Selectchelaing";
            DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车辆
        public DataSet SelectchelaingID(string PlateNumber)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                       new SqlParameter("@PlateNumber",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "SelectchelaingID";
            sqlPas[1].Value = PlateNumber;
          DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车型
        public DataSet Selectchelaingxinhao(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                     new SqlParameter("@VehicleID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "Selectchelaingxinhao";
            sqlPas[1].Value = VehicleID;
         DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询班次
        public DataSet selectbanci()
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "selectbanci";
            DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询班次人数
        public DataSet selectbancirenshu(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                      new SqlParameter("@VehicleID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "selectbancirenshu";
            sqlPas[1].Value = VehicleID;
         DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询班次儿童数
        public DataSet selectbancirenshuertongshu(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                      new SqlParameter("@VehicleID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "selectbancirenshuertongshu";
            sqlPas[1].Value = VehicleID;
            DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//
        public int INSERTchuzhanxinxi(int  VehicleID, int CarBelongToTheUnitID, int UserID, int CreateUserID, int DeleteUserID, int TheNumberOfPassengers, int ChildrenFree,
              string   ComprehensiveResults,bool AllPass,DateTime  CreateTime)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                    new SqlParameter("@VehicleID", SqlDbType.Int),
                    new SqlParameter("@CarBelongToTheUnitID", SqlDbType.Int),
                    new SqlParameter("@UserID", SqlDbType.Int),
                    new SqlParameter("@CreateUserID", SqlDbType.Int),
                    new SqlParameter("@DeleteUserID", SqlDbType.Int),
                    new SqlParameter("@TheNumberOfPassengers", SqlDbType.Int),
                    new SqlParameter("@ChildrenFree", SqlDbType.Int),
                    new SqlParameter("@ComprehensiveResults", SqlDbType.NChar),
                    new SqlParameter("@AllPass", SqlDbType.Bit),
                    new SqlParameter("@CreateTime",SqlDbType.DateTime),
                    }; 
            sqlPas[0].Value = "INSERTchuzhanxinxi";
            sqlPas[1].Value = VehicleID;
            sqlPas[2].Value = CarBelongToTheUnitID;
            sqlPas[3].Value = UserID;
            sqlPas[4].Value = CreateUserID;
            sqlPas[5].Value = DeleteUserID;
            sqlPas[6].Value = TheNumberOfPassengers;
            sqlPas[7].Value = ChildrenFree;
            sqlPas[8].Value = ComprehensiveResults;
            sqlPas[9].Value = AllPass;
            sqlPas[10].Value = CreateTime;
          DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
          int I= Convert.ToInt32(dt.Rows[0][0]);
            return I;
        }
        [OperationContract]//查询稽查员
        public DataSet selectjichayuan( )
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "selectjichayuan";
            DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车属单位
        public DataSet selectcheshudanwei(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                     new SqlParameter("@VehicleID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "selectcheshudanwei";
            sqlPas[1].Value = VehicleID;
           DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//新增出站明细
        public int  insectchuzhanmingxi(int  TheStationInspectionID, int CreateUserID, int DeleteUserID,int  AuditByComparisonNaneID, bool YON, DateTime CreateTime)
        {
               SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                    new SqlParameter("@TheStationInspectionID", SqlDbType.Int),
                    new SqlParameter("@CreateUserID", SqlDbType.Int),
                    new SqlParameter("@DeleteUserID", SqlDbType.Int),
                    new SqlParameter("@AuditByComparisonNaneID", SqlDbType.Int),
                    new SqlParameter("@YON",SqlDbType.Bit),
                    new SqlParameter("@CreateTime",SqlDbType.DateTime),
                    }; 
                     sqlPas[0].Value = "insectchuzhanmingxi";
            sqlPas[1].Value = TheStationInspectionID;
            sqlPas[2].Value = CreateUserID;
            sqlPas[3].Value = DeleteUserID;
            sqlPas[4].Value = AuditByComparisonNaneID;
            sqlPas[5].Value = YON;
            sqlPas[6].Value =CreateTime ;
            int dt = myDAL.UpdateData ("Chuzhanjichabiao", sqlPas);
          
            return dt;
        }
        [OperationContract]//查询稽查项目
        public DataSet selectjichaxianmu()
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "selectjichaxianmu";
            DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//修改车辆状态
        public int updatechelaingzhuangtai(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                    new SqlParameter("@VehicleID", SqlDbType.Int),
                    };
            sqlPas[0].Value = "updatechelaingzhuangtai";
            sqlPas[1].Value = VehicleID;
            int dt = myDAL.UpdateData("Chuzhanjichabiao", sqlPas);

            return dt;
        }
        [OperationContract]//修改车辆状态
        public int updatechelaingzhuangtaizuowei(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                    new SqlParameter("@VehicleID", SqlDbType.Int),
                    };
            sqlPas[0].Value = "updatechelaingzhuangtaizuowei";
            sqlPas[1].Value = VehicleID;
            int dt = myDAL.UpdateData("Chuzhanjichabiao", sqlPas);

            return dt;
        }
        [OperationContract]//查询稽查项目2
        public DataSet selectjichaxiangmu(int TheStationInspectionID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                      new SqlParameter("@TheStationInspectionID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "selectjichaxiangmu";
            sqlPas[1].Value = TheStationInspectionID;
         DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询稽查项目明细
        public DataSet SELECTJICHAXIANGMUMINGXI(string PlateNumber)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                new SqlParameter("@PlateNumber",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "SELECTJICHAXIANGMUMINGXI";
            sqlPas[1].Value = PlateNumber;
           DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车辆稽查单
        public DataSet selectcheliangjichadan(string VehiclePaiNumber)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                new SqlParameter("@VehiclePaiNumber",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "selectcheliangjichadan";
            sqlPas[1].Value = VehiclePaiNumber;
            DataTable dt = myDAL.QueryDataTable("Chuzhanjichabiao", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
