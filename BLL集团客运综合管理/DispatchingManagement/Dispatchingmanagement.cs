using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.DispatchingManagement
{
    [ServiceContract]
    class Dispatchingmanagement
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
      
        [OperationContract]//查询车辆组合信息
        public DataSet SelectFrequencyOnVehicleState(  )
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "SelectFrequencyOnVehicleState";
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询报班车辆信息
        public DataSet SelectBanCheLiangXinXi(string DepartureTimes,string DepartureTimef)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        new SqlParameter("@DepartureTimes",SqlDbType.NChar),
                            new SqlParameter("@DepartureTimef",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "SelectBanCheLiangXinXi";
            sqlPas[1].Value = DepartureTimes;
            sqlPas[2].Value = DepartureTimef;
       DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询开班车辆信息
        public DataSet SelectkaibanCheLiangXinXi(string DepartureTimes, string DepartureTimef)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        new SqlParameter("@DepartureTimes",SqlDbType.NChar),
                            new SqlParameter("@DepartureTimef",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "SelectkaibanCheLiangXinXi";
            sqlPas[1].Value = DepartureTimes;
            sqlPas[2].Value = DepartureTimef;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车辆信息
        public DataSet SelectFrequencyXinXi(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                    new SqlParameter("@FrequencyID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "SelectFrequencyXinXi";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]//查询代班车辆信息
        public DataSet Selectdaibancheliangxinxi( )
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "Selectdaibancheliangxinxi";  
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //修改车辆状态On报班车辆
        public int UpdateVehicleStateOnFrequency(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@VehicleID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "UpdateVehicleStateOnFrequency";
            sqlPas[1].Value = VehicleID;
            int dt = myDAL.UpdateData("Dispatchingmanagement", sqlPas);
            return dt;
        }
        [OperationContract]  //车辆停班
        public int Updatecheliangitbgban(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@VehicleID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "Updatecheliangitbgban";
            sqlPas[1].Value = VehicleID;
            int dt = myDAL.UpdateData("Dispatchingmanagement", sqlPas);
            return dt;
        }
        [OperationContract]  //查询检票口
        public DataSet Selectjianpiaokou()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "Selectjianpiaokou";
            DataTable  dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询车辆给检票口
        public DataSet SelectFrequencyOnjianpiaokou(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@FrequencyID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "SelectFrequencyOnjianpiaokou";
            sqlPas[1].Value = FrequencyID;
         DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //修改检票口
        public int UpdateJIanPiaoKou(int FrequencyID,int TicketEntranceID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@FrequencyID",SqlDbType.Int),
                                    new SqlParameter("@TicketEntranceID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "UpdateJIanPiaoKou";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = TicketEntranceID;
            int dt = myDAL.UpdateData("Dispatchingmanagement", sqlPas);
            return dt;
        }
        [OperationContract]  //查询车属单位On条件
        public DataSet SelectCarBeLong(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@FrequencyID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "SelectCarBeLong";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询车属单位
        public DataSet Selectcbocarbelong( )
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     };
            sqlPas[0].Value = "Selectcbocarbelong";
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询班次ON调度站
        public DataSet SelectBanCiOnDioaDuZhan(int CarBelongToTheUnitID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                     new SqlParameter("@CarBelongToTheUnitID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "SelectBanCiOnDioaDuZhan";
            sqlPas[1].Value = CarBelongToTheUnitID;
        DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询车辆On班次
        public DataSet SelectCheLiangOnBanCi(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                     new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "SelectCheLiangOnBanCi";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询终点站On班次ID
        public DataSet SelectdendsTaionOnFrequencyID(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                     new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "SelectdendsTaionOnFrequencyID";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询车辆状态On班次ID 中间条件是车辆表限制关系
        public DataSet Selectcheliangzhuangtai(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                     new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "Selectcheliangzhuangtai";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询第一个站点 
        public DataSet Selectdiyigezhandian(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                     new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "Selectdiyigezhandian";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询站点票价多条件查询 
        public DataSet Selectzhandianpiaojia(int FrequencyID ,int StationID1)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                     new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                       new SqlParameter("@StationID1",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "Selectzhandianpiaojia";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = StationID1;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询某辆车的席位状态 
        public DataSet Selelctxiweizhaungtai(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                     new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "Selelctxiweizhaungtai";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //修改检票口
        public int updatetime(int FrequencyID, string DepartureTime)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@FrequencyID",SqlDbType.Int),
            new SqlParameter("@DepartureTime",SqlDbType.NChar),       };
            sqlPas[0].Value = "updatetime";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = DepartureTime;
            int dt = myDAL.UpdateData("Dispatchingmanagement", sqlPas);
            return dt;
        }
        [OperationContract]  //修改检票口
        public DataSet  Selectpiaojiazuidariqi()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                               
                  };
            sqlPas[0].Value = "Selectpiaojiazuidariqi";
           
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询最大票号调度
        public DataSet Selectzuidapiohaodiaodu()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),

                  };
            sqlPas[0].Value = "Selectzuidapiohaodiaodu";

            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//新增订票信息调度
        public int Insectdingpiaoxinxidiaodu(int FrequencyID, int SeatsID, int CreateUserID, int DeleteUserID, string TicketMark, DateTime TicketingDate, DateTime TicketingDateTime, DateTime CreateTime,int TicketPriceTypeID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar  ),
                    new SqlParameter("@FrequencyID", SqlDbType.Int   ),
                    new SqlParameter("@SeatsID", SqlDbType.Int  ),
                    new SqlParameter("@CreateUserID", SqlDbType.Int  ),
                    new SqlParameter("@DeleteUserID", SqlDbType.Int  ),
                    new SqlParameter("@TicketMark", SqlDbType.NChar  ),
                    new SqlParameter("@TicketingDate", SqlDbType.DateTime  ),
                    new SqlParameter("@TicketingDateTime", SqlDbType.DateTime  ),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime  ),
                        new SqlParameter("@TicketPriceTypeID", SqlDbType.Int  ),
                          
                    };
            sqlPas[0].Value = "Insectdingpiaoxinxidiaodu";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = SeatsID;
            sqlPas[3].Value = CreateUserID;
            sqlPas[4].Value = DeleteUserID;
            sqlPas[5].Value = TicketMark;
            sqlPas[6].Value = TicketingDate;
            sqlPas[7].Value = TicketingDateTime;
            sqlPas[8].Value = CreateTime;
            sqlPas[9].Value = TicketPriceTypeID;
          
            int dt = myDAL.UpdateData("Dispatchingmanagement", sqlPas);
            return dt;
        }
        [OperationContract]  //查询票价类型
        public DataSet selectpiaojialeixing()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                  };
            sqlPas[0].Value = "selectpiaojialeixing";
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//修改席位状态为留票调度
        public int Updatexiweizhaungtaiweibaofeidiaodu(int SeatsID )
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar  ),
                          new SqlParameter("@SeatsID",SqlDbType.Int),
                    };
            sqlPas[0].Value = "Updatexiweizhaungtaiweibaofeidiaodu";
            sqlPas[1].Value = SeatsID;
            int dt = myDAL.UpdateData("Dispatchingmanagement", sqlPas);
            return dt;
        }
        [OperationContract]  //查询班次信息to广播
        public DataSet Selectbancixinxitoguangbo(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.Int  ),

                  };
            sqlPas[0].Value = "Selectbancixinxitoguangbo";
            sqlPas[1].Value = FrequencyID;
          DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //根据班次查询第一个站点
        public DataSet Selectchaxundiyigezhandian(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.Int  ),

                  };
            sqlPas[0].Value = "Selectchaxundiyigezhandian";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //根据班次查询最后站点
        public DataSet Selectchaxunzuihougezhandian(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.Int  ),

                  };
            sqlPas[0].Value = "Selectchaxunzuihougezhandian";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //根据班次查询最后站点
        public DataSet selectbaobanbanci()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                  };
            sqlPas[0].Value = "selectbaobanbanci";
            DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询途径站
        public DataSet selecttujinzhan(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.Int),
                  };
            sqlPas[0].Value = "selecttujinzhan";
            sqlPas[1].Value = FrequencyID;
          DataTable dt = myDAL.QueryDataTable("Dispatchingmanagement", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//新增验证码
        public int InsectYanZhnegMa(string DingPiaoYanZhengMa,bool ShiFou)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar  ),
                          new SqlParameter("@DingPiaoYanZhengMa",SqlDbType.NChar ),
                            new SqlParameter("@ShiFou",SqlDbType.Bit ),
                    };
            sqlPas[0].Value = "InsectYanZhnegMa";
            sqlPas[1].Value = DingPiaoYanZhengMa;
            sqlPas[2].Value = ShiFou;
            int dt = myDAL.UpdateData("Dispatchingmanagement", sqlPas);
            return dt;
        }
    }
}
