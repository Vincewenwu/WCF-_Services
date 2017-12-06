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
    class NEWFrequencyInsect
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]  //新增班次

        public int FrequencyInsect(int VehicleID, int LineID, int StartingStationID, int TerminalStationID, int TicketEntranceID, int CreateUserID, int DeleteUserID, string FrequencyMC,
               string  DepartureTime, string  CirculationDate, int BeginningDays, int ClassNumber, int StopClassDays, bool Generate, bool WhetherToPas, string Comments,
              DateTime CreateTime,bool ListState)
        {
            SqlParameter[] sqlPas = {
                                        new SqlParameter("@SN",SqlDbType.NChar  ),
                            new SqlParameter("@VehicleID", SqlDbType.Int   ),
                            new SqlParameter("@LineID", SqlDbType.Int  ),
                            new SqlParameter("@StartingStationID", SqlDbType.Int  ),
                            new SqlParameter("@TerminalStationID", SqlDbType.Int  ),
                            new SqlParameter("@TicketEntranceID", SqlDbType.Int),
                            new SqlParameter("@CreateUserID", SqlDbType.Int),
                            new SqlParameter("@DeleteUserID", SqlDbType.Int),
                            new SqlParameter("@FrequencyMC", SqlDbType.NChar),
                            new SqlParameter("@DepartureTime", SqlDbType.NChar  ),
                            new SqlParameter("@CirculationDate", SqlDbType.NChar),
                            new SqlParameter("@BeginningDays", SqlDbType.Int ),
                            new SqlParameter("@ClassNumber", SqlDbType.Int ),
                            new SqlParameter("@StopClassDays", SqlDbType.Int ),
                            new SqlParameter("@Generate", SqlDbType.Bit ),
                            new SqlParameter("@WhetherToPas", SqlDbType.Bit ),
                            new SqlParameter("@Comments", SqlDbType.NChar),
                            new SqlParameter("@CreateTime", SqlDbType.DateTime ),
                              new SqlParameter("@ListState", SqlDbType.Bit ),

                    };
            sqlPas[0].Value = "FrequencyInsect";
            sqlPas[1].Value = VehicleID;
            sqlPas[2].Value = LineID;
            sqlPas[3].Value = StartingStationID;
            sqlPas[4].Value = TerminalStationID;
            sqlPas[5].Value = TicketEntranceID;
            sqlPas[6].Value = CreateUserID;
            sqlPas[7].Value = DeleteUserID;
            sqlPas[8].Value = FrequencyMC;
            sqlPas[9].Value = DepartureTime;
            sqlPas[10].Value = CirculationDate;
            sqlPas[11].Value = BeginningDays;
            sqlPas[12].Value = ClassNumber;
            sqlPas[13].Value = StopClassDays;
            sqlPas[14].Value = Generate;
            sqlPas[15].Value = WhetherToPas;
            sqlPas[16].Value = Comments;
            sqlPas[17].Value = CreateTime;
            sqlPas[18].Value = ListState;
            int dt = myDAL.UpdateData ("NEWFrequencyInsect", sqlPas);
            return dt;
        }


        [OperationContract]   //修改车辆状态为待报班
        public int UpdateVehicleState(int VehicleID)
        {
            SqlParameter[] sqlPas = {
                      new SqlParameter("@SN",SqlDbType.NChar),
              new SqlParameter("@VehicleID", SqlDbType.Int),
                                        };
            sqlPas[0].Value = "UpdateVehicleState";
            sqlPas[1].Value = VehicleID;
            int it = myDAL.UpdateData("NEWFrequencyInsect", sqlPas);
            return it;
        }
        [OperationContract]   //新增线路
        public int LineLInsect(int CreateUserID, int DeleteUserID, string LineMC, string LineNumber, DateTime CreateTime )
        {
            SqlParameter[] sqlPas = {
                                        new SqlParameter("@SN",SqlDbType.NChar),
              new SqlParameter("@CreateUserID", SqlDbType.Int),
              new SqlParameter("@DeleteUserID", SqlDbType.Int),
              new SqlParameter("@LineMC", SqlDbType.NChar),
              new SqlParameter("@LineNumber", SqlDbType.NChar),
              new SqlParameter("@CreateTime", SqlDbType.DateTime),
            
                                        };
            sqlPas[0].Value = "LineLInsect";
            sqlPas[1].Value = CreateUserID;
            sqlPas[2].Value = DeleteUserID;
            sqlPas[3].Value = LineMC;
            sqlPas[4].Value = LineNumber;
            sqlPas[5].Value = CreateTime; 
            int  it = myDAL.UpdateData ("NEWFrequencyInsect", sqlPas);
           
            return it ;
        }
        [OperationContract]  //新增站点
        public int StationInsect(int CreateUserID, int DeleteUserID, string StationMC, string SitePinYinInitials, string StationNunber, DateTime CreateTime )
        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar  ),
                new SqlParameter("@CreateUserID", SqlDbType.Int   ),
                new SqlParameter("@DeleteUserID", SqlDbType.Int   ),
                new SqlParameter("@StationMC", SqlDbType.NChar  ),
                new SqlParameter("@SitePinYinInitials", SqlDbType.NChar),
                new SqlParameter("@StationNunber", SqlDbType.NChar),
                new SqlParameter("@CreateTime", SqlDbType.DateTime ),
                                        };
            sqlPas[0].Value = "StationInsect";
            sqlPas[1].Value = CreateUserID;
            sqlPas[2].Value = DeleteUserID;
            sqlPas[3].Value = StationMC;
            sqlPas[4].Value = SitePinYinInitials;
            sqlPas[5].Value = StationNunber;
            sqlPas[6].Value = CreateTime;
            int  myint = myDAL.UpdateData ("NEWFrequencyInsect", sqlPas);
            return myint ;
        }
        [OperationContract]  //新增检票口
        public int InsectDriverForm(int CreateUserID, int DeleteUserID, string TicketEntranceMC, DateTime CreateTime, DateTime LogicalDeleteTime)
        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar  ),
              new SqlParameter("@CreateUserID", SqlDbType.NChar  ),
              new SqlParameter("@DeleteUserID", SqlDbType.NChar  ),
              new SqlParameter("@TicketEntranceMC", SqlDbType.NChar  ),
              new SqlParameter("@CreateTime", SqlDbType.NChar  ),
              new SqlParameter("@LogicalDeleteTime", SqlDbType.NChar),
                                        };
            sqlPas[0].Value = "InsectVehicleLicense";
            sqlPas[0].Value = CreateUserID;
            sqlPas[1].Value = DeleteUserID;
            sqlPas[2].Value = TicketEntranceMC;
            sqlPas[3].Value = CreateTime;
            sqlPas[4].Value = LogicalDeleteTime;
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyInsect", sqlPas);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            return result;
        }
        [OperationContract]  //查询线路
        public DataSet   LineSelect()
        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar  ),
                                        };
            sqlPas[0].Value = "LineSelect";
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyInsect", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询站点
        public DataSet StationSelect()
        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar  ),
                                        };
            sqlPas[0].Value = "StationSelect";
            DataSet ds  = myDAL.QueryDataSet("NEWFrequencyInsect", sqlPas);
            return ds ;
        }
        [OperationContract]  //查询检票口
        public DataSet   TicketEntranceSelect()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "TicketEntranceSelect";
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyInsect", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds ;
        }
        [OperationContract]  //查询车辆
        public DataSet VehicleSelect()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "VehicleSelect";
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyInsect", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询站点是否存在
        public DataSet StationSelectOn(string  StationMC)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                   new SqlParameter("@StationMC",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "StationSelectOn";
            sqlPas[1].Value = StationMC;
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyInsect", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询线路是否存在
        public DataSet LineSelectOn(string LineMC)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                   new SqlParameter("@LineMC",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "LineSelectOn";
            sqlPas[1].Value = LineMC;
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyInsect", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    } 
    
}
