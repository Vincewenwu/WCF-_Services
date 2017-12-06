using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.FrequencyManager
{
    [ServiceContract]
    class FrequencyListManager
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet SelectFrequency(int YeShu,int YeMa)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@YeShu",SqlDbType.Int),
                                      new SqlParameter("@YeMa",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "SelectFrequency";
            sqlPas[1].Value = YeShu;
            sqlPas[2].Value = YeMa;
        DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询最大班次数
        public DataSet selectzhongshu()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "selectzhongshu";
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //删除班次
        public int UPDATErequency(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "UPDATErequency";
            sqlPas[1].Value = FrequencyID;
            int myin = myDAL.UpdateData("FrequencyListManager", sqlPas);

            return myin;
        }
        [OperationContract]  //查询车辆On班次ID
        public DataSet SelectOnFrequencyID(int LineID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@LineID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "SelectOnFrequencyID";
            sqlPas[1].Value = LineID;
            DataTable  dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //增加途径站点
        public int IntsertStopsinroute(int  FrequencyID, int StaionID, int CreateUserID, int DeleteUserID,string StopsinrouteMC,
                                   int   Standingorder,string StationNunber,bool Whetherdock,DateTime CreateTime)

        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar),
                            new SqlParameter("@FrequencyID",SqlDbType.Int ),
                            new SqlParameter("@StaionID",SqlDbType.Int ),
                            new SqlParameter("@CreateUserID",SqlDbType.Int ),
                            new SqlParameter("@DeleteUserID",SqlDbType.Int ),
                            new SqlParameter("@StopsinrouteMC",SqlDbType.NChar ),
                            new SqlParameter("@Standingorder",SqlDbType.Int ),
                            new SqlParameter("@StationNunber",SqlDbType.Int ),
                            new SqlParameter("@Whetherdock",SqlDbType.Bit ),
                            new SqlParameter("@CreateTime",SqlDbType.DateTime),
                                            }; 
                            sqlPas[0].Value = "IntsertStopsinroute";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = StaionID;
            sqlPas[3].Value = CreateUserID;
            sqlPas[4].Value = DeleteUserID;
            sqlPas[5].Value = StopsinrouteMC;
            sqlPas[6].Value = Standingorder;
            sqlPas[7].Value = StationNunber;
            sqlPas[8].Value = Whetherdock; ;
            sqlPas[9].Value = CreateTime;
            int myin = myDAL.UpdateData("FrequencyListManager", sqlPas);
            return myin;
        }
        [OperationContract]  //查询车辆所属单位
        public DataSet selectbancimingcheng()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "selectbancimingcheng";
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询车辆所属单位
        public DataSet SelectBelong(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "SelectBelong";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询站点
        public DataSet SelectTuJinStaion()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "SelectTuJinStaion";
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询途径站点
        public DataSet SelectTuJinnewStaion(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                      new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "SelectTuJinnewStaion";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询最大单个途径站站点的序号
        public DataSet SelectMAXStaionxuhao(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                      new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "SelectMAXStaionxuhao";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询最大单个途径站站点的序号
        public DataSet Selectxhelaingxiweishu(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                      new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "Selectxhelaingxiweishu";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //增加途径站点
        public int UpdateTuJinStation(int FrequencyID, int StaionID, int CreateUserID, int DeleteUserID, string StopsinrouteMC,
                                  int Standingorder, string StationNunber, bool Whetherdock, DateTime CreateTime, int StopsinrouteID, int kilometer)

        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar),
                            new SqlParameter("@FrequencyID",SqlDbType.Int ),
                            new SqlParameter("@StaionID",SqlDbType.Int ),
                            new SqlParameter("@CreateUserID",SqlDbType.Int ),
                            new SqlParameter("@DeleteUserID",SqlDbType.Int ),
                            new SqlParameter("@StopsinrouteMC",SqlDbType.NChar ),
                            new SqlParameter("@Standingorder",SqlDbType.Int ),
                            new SqlParameter("@StationNunber",SqlDbType.Int ),
                            new SqlParameter("@Whetherdock",SqlDbType.Bit ),
                            new SqlParameter("@CreateTime",SqlDbType.DateTime),
                            new SqlParameter("@StopsinrouteID",SqlDbType.Int),
                            new SqlParameter("@kilometer",SqlDbType.Int),
                                            };
            sqlPas[0].Value = "UpdateTuJinStation";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = StaionID;
            sqlPas[3].Value = CreateUserID;
            sqlPas[4].Value = DeleteUserID;
            sqlPas[5].Value = StopsinrouteMC;
            sqlPas[6].Value = Standingorder;
            sqlPas[7].Value = StationNunber;
            sqlPas[8].Value = Whetherdock; ;
            sqlPas[9].Value = CreateTime;
            sqlPas[10].Value =StopsinrouteID;
            sqlPas[11].Value = kilometer;
            int myin = myDAL.UpdateData("FrequencyListManager", sqlPas);
            return myin;
        }
        [OperationContract]  //查询最大单个途径站站点的序号
        public DataSet SelectTuJinStaionMoHu( )
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "SelectTuJinStaionMoHu"; 
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //选择修改途径站点
        public DataSet SelectUpdatetujinStation(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "SelectUpdatetujinStation";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //选择修改途径站点dgv4
        public DataSet SelectagainUpdatetujinStation(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "SelectagainUpdatetujinStation";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //SEE站点票价计算
        public DataSet Caculateprice(int FrequencyID,int StaionID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                       new SqlParameter("@StaionID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "Caculateprice";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = StaionID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //增加途径站点
        public int InsectCaculateprice(int FrequencyID, int StartingStationID, int TerminalStationID, int SeatsTypeID,
            int TicketPriceTypeID, int CreateUserID, int DeleteUserID,
              decimal   TicketPrice,DateTime  CreateTime)

        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar),
                  new SqlParameter("@FrequencyID", SqlDbType.Int ),
                  new SqlParameter("@StartingStationID", SqlDbType.Int),
                  new SqlParameter("@TerminalStationID", SqlDbType.Int),
                  new SqlParameter("@SeatsTypeID", SqlDbType.Int),
                  new SqlParameter("@TicketPriceTypeID", SqlDbType.Int),
                  new SqlParameter("@CreateUserID", SqlDbType.Int),
                  new SqlParameter("@DeleteUserID", SqlDbType.Int),
                  new SqlParameter("@TicketPrice", SqlDbType.Decimal),
                  new SqlParameter("@CreateTime", SqlDbType.DateTime),
                          
                        };
            sqlPas[0].Value = "InsectCaculateprice";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = StartingStationID;
            sqlPas[3].Value = TerminalStationID;
            sqlPas[4].Value = SeatsTypeID;
            sqlPas[5].Value = TicketPriceTypeID;
            sqlPas[6].Value = CreateUserID;
            sqlPas[7].Value = DeleteUserID;
            sqlPas[8].Value = TicketPrice;
            sqlPas[9].Value = CreateTime;

           int myin = myDAL.UpdateData("FrequencyListManager", sqlPas);
            return myin;
        }
        [OperationContract]  //查询途径站点
        public DataSet selecttujinzhandian(int FrequencyID )
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                                             };
            sqlPas[0].Value = "selecttujinzhandian";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询席位类型
        public DataSet SelectSeatTypeID( )
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "SelectSeatTypeID";
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询票价类型
        public DataSet SelectTicketPriceTypeID()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "SelectTicketPriceTypeID";
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询一个站点对应所有站点的所有票价类型和价钱
        public DataSet SelectStationtickprice(int FrequencyID,int StartingStationID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.NChar  ),
                                      new SqlParameter("@StartingStationID",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "SelectStationtickprice";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = StartingStationID;
           DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询车辆
        public DataSet  SeleectFrequencyIDtoVehicleID(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@FrequencyID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "SeleectFrequencyIDtoVehicleID";
            sqlPas[1].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        //[OperationContract]  //修改车辆状态
        //public int UpdateVehicleState(int VehicleID)
        //{
        //    SqlParameter[] sqlPas = {
        //                          new SqlParameter("@SN",SqlDbType.NChar  ),
        //                            new SqlParameter("@VehicleID",SqlDbType.Int),
        //                                                     };
        //    sqlPas[0].Value = "UpdateVehicleState";
        //    sqlPas[1].Value = VehicleID;
        //    int dt = myDAL.UpdateData ("FrequencyListManager", sqlPas);
        //    return dt;
        //}
        [OperationContract]  //删除票价On车次
        public int DeleteTicketPriceOnFrequencyID(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@FrequencyID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "DeleteTicketPriceOnFrequencyID";
            sqlPas[1].Value = FrequencyID;
            int dt = myDAL.UpdateData("FrequencyListManager", sqlPas);
            return dt;
        }
        [OperationContract]  //修改车辆状态删除票价之后
        public int UpdateVehicleStateOnFrequencyID(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@VehicleID",SqlDbType.Int),
                                                             };
            sqlPas[0].Value = "DeleteTicketPriceOnFrequencyID";
            sqlPas[1].Value = VehicleID;
            int dt = myDAL.UpdateData("FrequencyListManager", sqlPas);
            return dt;
        }
        [OperationContract]  //修改车辆状态删除票价之后
        public int UpdateallFrequency(string  CirculationDate)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@CirculationDate",SqlDbType.NChar),
                                                             };
            sqlPas[0].Value = "UpdateallFrequency";
            sqlPas[1].Value = CirculationDate;
            int dt = myDAL.UpdateData("FrequencyListManager", sqlPas);
            return dt;
        }
        [OperationContract]  //查询班次打印报表
        public DataSet selectbanbiao()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  )
                                                             };
            sqlPas[0].Value = "selectbanbiao";
            DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //删除途径站点
        public int  DELETEtujinzhandian(int StopsinrouteID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@StopsinrouteID",SqlDbType.Int  )
                                                             };
            sqlPas[0].Value = "DELETEtujinzhandian";
            sqlPas[1].Value = StopsinrouteID;
          int  dt = myDAL.UpdateData("FrequencyListManager", sqlPas);
            return dt;
        }
        [OperationContract]  //查询用户名称和类型通过用户ID
        public DataSet selectyonghuandleixing(int UserID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                       new SqlParameter("@UserID",SqlDbType.Int   )
                                                             };
            sqlPas[0].Value = "selectyonghuandleixing";
            sqlPas[1].Value = UserID;
       DataTable dt = myDAL.QueryDataTable("FrequencyListManager", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
