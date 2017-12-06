using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.SeaseTicket
{
    [ServiceContract]
    class TicketSease
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]//查询车票
        public DataSet Selectchepiao(int  StartingStationID,int  TerminalStationID,int  TicketPriceTypeID,string 给出时间,int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@StartingStationID",SqlDbType.Int),
                                      new SqlParameter("@TerminalStationID",SqlDbType.Int),
                                         new SqlParameter("@TicketPriceTypeID",SqlDbType.Int),
                                             new SqlParameter("@给出时间",SqlDbType.NChar),
                                                new SqlParameter("@FrequencyID",SqlDbType.Int),
                                    };
            sqlPas[0].Value = "Selectchepiao";
            sqlPas[1].Value = StartingStationID;
            sqlPas[2].Value = TerminalStationID;
            sqlPas[3].Value = TicketPriceTypeID;
            sqlPas[4].Value = 给出时间;
            sqlPas[5].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询班次On时间
        public DataSet Selectbancionshijian(int StartingStationID, int TerminalStationID, int TicketPriceTypeID, string 给出时间)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@StartingStationID",SqlDbType.Int),
                                      new SqlParameter("@TerminalStationID",SqlDbType.Int),
                                         new SqlParameter("@TicketPriceTypeID",SqlDbType.Int),
                                             new SqlParameter("@给出时间",SqlDbType.NChar),
                                    };
            sqlPas[0].Value = "Selectbancionshijian";
            sqlPas[1].Value = StartingStationID;
            sqlPas[2].Value = TerminalStationID;
            sqlPas[3].Value = TicketPriceTypeID;
            sqlPas[4].Value = 给出时间;
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询站点和票价
        public DataSet Selectczhandianandpiaojia(int StartingStationID, int TerminalStationID, int TicketPriceTypeID ,int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@StartingStationID",SqlDbType.Int),
                                      new SqlParameter("@TerminalStationID",SqlDbType.Int),
                                         new SqlParameter("@TicketPriceTypeID",SqlDbType.Int),
                                             new SqlParameter("@FrequencyID",SqlDbType.NChar),
                                    };
            sqlPas[0].Value = "Selectczhandianandpiaojia";
            sqlPas[1].Value = StartingStationID;
            sqlPas[2].Value = TerminalStationID;
            sqlPas[3].Value = TicketPriceTypeID;
            sqlPas[4].Value = FrequencyID;
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询站点
        public DataSet SelectStaion()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                                             };
            sqlPas[0].Value = "SelectStaion";
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询某辆车的席位状态
        public DataSet Selelctticketzhuangtai(int FrequencyID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "Selelctticketzhuangtai";
            sqlPas[1].Value = FrequencyID;
        DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }   
        [OperationContract]//查询车辆的席位
        public DataSet selectchelaingdexiwei(int FrequencyID,int 个数)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@FrequencyID",SqlDbType.Int  ),
                                        new SqlParameter("@个数",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "selectchelaingdexiwei";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = 个数;
   DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//修改席位状态为已售
        public int Updatexiweizhaungtai(int SeatsID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                  new SqlParameter("@SeatsID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "Updatexiweizhaungtai";
            sqlPas[1].Value = SeatsID;
            int dt = myDAL.UpdateData("SeaseTicket",sqlPas);
            return dt;
        }
        [OperationContract]//新增订票信息
        public int Insectdingpiaoxinxi(int  FrequencyID, int SeatsID, int CreateUserID, int DeleteUserID,string  TicketMark,DateTime TicketingDate,DateTime  TicketingDateTime,DateTime  CreateTime,int TicketPriceTypeID,decimal Howmoney,int  TicketStateID)
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
                             new SqlParameter("@Howmoney", SqlDbType.Decimal  ),
                                new SqlParameter("@TicketStateID", SqlDbType.Decimal  ),
                    };
            sqlPas[0].Value = "Insectdingpiaoxinxi";
            sqlPas[1].Value = FrequencyID;
            sqlPas[2].Value = SeatsID;
            sqlPas[3].Value = CreateUserID;
            sqlPas[4].Value = DeleteUserID;
            sqlPas[5].Value = TicketMark;
            sqlPas[6].Value = TicketingDate;
            sqlPas[7].Value = TicketingDateTime;
            sqlPas[8].Value = CreateTime;
            sqlPas[9].Value = TicketPriceTypeID;
            sqlPas[10].Value = Howmoney;
            sqlPas[11].Value = TicketStateID;
            int dt = myDAL.UpdateData("SeaseTicket", sqlPas);
            return dt;
        }
        [OperationContract]//查询最大票号
        public DataSet Selectzuidapiohao()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     };
            sqlPas[0].Value = "Selectzuidapiohao";
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//修改订票信息
        public int DELETETicketingInformation( int TicketingInformationID,int TicketPriceTypeID,int TicketStateID,int Tuipiaoshouxufei)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar  ),
                    new SqlParameter("@TicketingInformationID",SqlDbType.Int),
                    new SqlParameter("@TicketPriceTypeID",SqlDbType.Int),
                    new SqlParameter("@TicketStateID",SqlDbType.Int),
                       new SqlParameter("@Tuipiaoshouxufei",SqlDbType.Int),
                    };
            sqlPas[0].Value = "DELETETicketingInformation";
            sqlPas[1].Value = TicketingInformationID;
            sqlPas[2].Value = TicketPriceTypeID;
            sqlPas[3].Value = TicketStateID;
            sqlPas[4].Value = Tuipiaoshouxufei;
            int dt = myDAL.UpdateData("SeaseTicket", sqlPas);
            return dt;
        }
        [OperationContract]//修改订票退票信息
        public int DELETETicketingInformationtuipiao(int TicketingInformationID, int TicketPriceTypeID,int Tuipiaoshouxufei,int TicketStateID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar  ),
                       new SqlParameter("@TicketingInformationID",SqlDbType.Int),
                                              new SqlParameter("@TicketPriceTypeID",SqlDbType.Int),
                                                 new SqlParameter("@Tuipiaoshouxufei",SqlDbType.Int),
                                                  new SqlParameter("@TicketStateID",SqlDbType.Int),
                    };
            sqlPas[0].Value = "DELETETicketingInformationtuipiao";
            sqlPas[1].Value = TicketingInformationID;
            sqlPas[2].Value = TicketPriceTypeID;
            sqlPas[3].Value = Tuipiaoshouxufei;
            sqlPas[4].Value = TicketStateID;
            int dt = myDAL.UpdateData("SeaseTicket", sqlPas);
            return dt;
        }
        [OperationContract]//删除票价信息之前查询在哪里的
        public DataSet SelectpiaojiaID(int SeatsID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@SeatsID",SqlDbType.Int),
                                     };
            sqlPas[0].Value = "SelectpiaojiaID";
            sqlPas[1].Value = SeatsID;
         DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//修改席位状态为报废
        public int Updatexiweizhaungtaiweibaofei(int SeatsID,int SeatsStateID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar  ),
                          new SqlParameter("@SeatsID",SqlDbType.Int),
                       new SqlParameter("@SeatsStateID",SqlDbType.Int),
                    };
            sqlPas[0].Value = "Updatexiweizhaungtaiweibaofei";
            sqlPas[1].Value = SeatsID;
            sqlPas[2].Value = SeatsStateID;
            int dt = myDAL.UpdateData("SeaseTicket", sqlPas);
            return dt;
        }
        [OperationContract]//模糊查询票
        public DataSet MoHuSelectpiaoxinxi(string 动态条件)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                    new SqlParameter("@动态条件",SqlDbType.NChar  ),
                                     };
            sqlPas[0].Value = "MoHuSelectpiaoxinxi";
            sqlPas[1].Value = 动态条件;
          DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询车型
        public DataSet selectchexing( )
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                   
                                     };
            sqlPas[0].Value = "selectchexing";
          
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询票型
        public DataSet selectpiaoxing()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),

                                     };
            sqlPas[0].Value = "selectpiaoxing";

            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询票状态
        public DataSet selectpiaozhaungrtai()
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),

                                     };
            sqlPas[0].Value = "selectpiaozhaungrtai";

            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询废票信息
        public DataSet selectfeipiaoxinxi(int  SeatsID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@SeatsID",SqlDbType.Int  ),

                                     };
            sqlPas[0].Value = "selectfeipiaoxinxi";
            sqlPas[1].Value = SeatsID;
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询当前票号
        public DataSet selectgenjuyonghuID(int UserID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@UserID",SqlDbType.Int  ),

                                     };
            sqlPas[0].Value = "selectgenjuyonghuID";
            sqlPas[1].Value = UserID;
            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询当前票号
        public int  UPDATEdangqianpiaohao(int CurrentTicketMark,int SurplusQuantity,int ReceiveUserID)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@CurrentTicketMark",SqlDbType.Int  ),
                                         new SqlParameter("@SurplusQuantity",SqlDbType.Int  ),
                                              new SqlParameter("@ReceiveUserID",SqlDbType.Int  ),
                                     };
            sqlPas[0].Value = "UPDATEdangqianpiaohao";
            sqlPas[1].Value = CurrentTicketMark;
            sqlPas[2].Value = SurplusQuantity;
            sqlPas[3].Value = ReceiveUserID;
            int  dt = myDAL.UpdateData("SeaseTicket", sqlPas);
          
            return dt;
        }
        [OperationContract]//查询验证码是否纯在
        public DataSet selectyanzhengma(string DingPiaoYanZhengMa)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@DingPiaoYanZhengMa",SqlDbType.NChar  ),
                                       
                                     };
            sqlPas[0].Value = "selectyanzhengma";
            sqlPas[1].Value = DingPiaoYanZhengMa;

            DataTable dt = myDAL.QueryDataTable("SeaseTicket", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//修改验证码验证码为否
        public int updateyanzhengma(bool ShiFou ,string DingPiaoYanZhengMa)
        {
            SqlParameter[] sqlPas = {
                                  new SqlParameter("@SN",SqlDbType.NChar  ),
                                     new SqlParameter("@ShiFou",SqlDbType.Bit  ),
                                       new SqlParameter("@DingPiaoYanZhengMa",SqlDbType.NChar),

                                     };
            sqlPas[0].Value = "updateyanzhengma";
            sqlPas[1].Value = ShiFou;
            sqlPas[2].Value = DingPiaoYanZhengMa;
            int dt = myDAL.UpdateData("SeaseTicket", sqlPas);

            return dt;
        }
    }
}
