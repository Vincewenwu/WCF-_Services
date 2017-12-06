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
    class NEWFrequencyUpdate
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]
        public int FrequencyUPDATE(int VehicleID, int LineID, int StartingStationID, int TerminalStationID, int TicketEntranceID, int CreateUserID, int DeleteUserID, string FrequencyMC,
               string DepartureTime, string CirculationDate, int BeginningDays, int ClassNumber, int StopClassDays, bool Generate, bool WhetherToPas, string Comments,
              DateTime CreateTime,int FrequencyID)
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
                            new SqlParameter("@FrequencyID", SqlDbType.Int  ),

                    };
            sqlPas[0].Value = "FrequencyUPDATE";
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
            sqlPas[18].Value = FrequencyID;
            int dt = myDAL.UpdateData("NEWFrequencyUpdate", sqlPas);
            return dt;
        }
        [OperationContract]  //查询班次
        public DataSet SelectFrequency()
        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar  ),
                                        };
            sqlPas[0].Value = "SelectFrequency";
        DataTable  dt = myDAL.QueryDataTable ("NEWFrequencyUpdate", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt );
            return ds;
        }
        [OperationContract]  //查询条件班次
        public DataSet SelectFrequencyTIAO(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                  new SqlParameter("@SN",SqlDbType.NChar  ),
                            new SqlParameter("@FrequencyID",SqlDbType.Int   ),
                                        };
            sqlPas[0].Value = "SelectFrequencyTIAO";
            sqlPas[1].Value = FrequencyID;
           DataTable dt = myDAL.QueryDataTable("NEWFrequencyUpdate", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询线路
        public DataSet LineSelect()
        {
            SqlParameter[] sqlPas = {
                            new SqlParameter("@SN",SqlDbType.NChar  ),
                                        };
            sqlPas[0].Value = "LineSelect";
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyUpdate", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询检票口
        public DataSet TicketEntranceSelect()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "TicketEntranceSelect";
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyUpdate", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询车辆
        public DataSet VehicleSelect()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "VehicleSelect";
            DataTable dt = myDAL.QueryDataTable("NEWFrequencyUpdate", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]  //查询站点
        public DataSet StationSelect1()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "StationSelect1";
            DataSet  ds= myDAL.QueryDataSet("NEWFrequencyUpdate", sqlPas);
            return ds;
        }
        [OperationContract]  //查询条件站点
        public DataSet StationSelectTIAO(string StationMC)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@StationMC",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "StationSelectTIAO";
            sqlPas[1].Value = StationMC;
        DataTable  dt = myDAL.QueryDataTable("NEWFrequencyUpdate", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
      
    }
}
