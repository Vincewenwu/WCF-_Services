using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.CampseizedmoneyManager
{
    [ServiceContract]
    class Campseizedmoneyguanli
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]//查询用户
        public DataSet selectyonghu()
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "selectyonghu";
            DataTable dt = myDAL.QueryDataTable("Campseizedmoney", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询用户
        public DataSet Campseizedmoney_selectdangqianpiaohao(int UserID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                      new SqlParameter("@UserID",SqlDbType.Int ),
                        };
            sqlPas[0].Value = "Campseizedmoney_selectdangqianpiaohao";
            sqlPas[1].Value = UserID;
           DataTable dt = myDAL.QueryDataTable("Campseizedmoney", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询售票张数
        public DataSet Campseizedmoney_selectshoupiaozhangshu(int UserID,DateTime TicketingDate)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                      new SqlParameter("@UserID",SqlDbType.Int ),
                       new SqlParameter("@TicketingDate",SqlDbType.DateTime ),
                        };
            sqlPas[0].Value = "Campseizedmoney_selectshoupiaozhangshu";
            sqlPas[1].Value = UserID;
            sqlPas[2].Value = TicketingDate;
            DataTable dt = myDAL.QueryDataTable("Campseizedmoney", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//新增营收缴费表
        public int  Campseizedmoney_insectyingshoujiaofeidan(string  UserCoding,int  UserID,int  Shoupiaozhangshu,decimal Shoupiaojine,int  tuipiaozhangshu,decimal tuipiaojine,int  feipiaozhangshu,decimal feipiaojine,
               decimal  jiankuanjine,string  Comments,DateTime Createtime)
        {
                        SqlParameter[] sqlPas = {
                        new SqlParameter("@SN",SqlDbType.NChar),
                        new SqlParameter("@UserCoding", SqlDbType.NChar),
                        new SqlParameter("@UserID", SqlDbType.NChar),
                        new SqlParameter("@Shoupiaozhangshu", SqlDbType.NChar),
                        new SqlParameter("@Shoupiaojine", SqlDbType.NChar),
                        new SqlParameter("@tuipiaozhangshu", SqlDbType.NChar),
                        new SqlParameter("@tuipiaojine", SqlDbType.NChar),
                        new SqlParameter("@feipiaozhangshu", SqlDbType.NChar),
                        new SqlParameter("@feipiaojine", SqlDbType.NChar),
                        new SqlParameter("@jiankuanjine", SqlDbType.NChar),
                        new SqlParameter("@Comments", SqlDbType.NChar),
                        new SqlParameter("@Createtime",SqlDbType.NChar),

                        }; 
                        sqlPas[0].Value = "Campseizedmoney_insectyingshoujiaofeidan";
            sqlPas[1].Value = UserCoding;
            sqlPas[2].Value = UserID;
            sqlPas[3].Value = Shoupiaozhangshu;
            sqlPas[4].Value = Shoupiaojine;
            sqlPas[5].Value = tuipiaozhangshu;
            sqlPas[6].Value = tuipiaojine;
            sqlPas[7].Value = feipiaozhangshu;
            sqlPas[8].Value = feipiaojine;
            sqlPas[9].Value = jiankuanjine;
            sqlPas[10].Value = Comments;
            sqlPas[11].Value = Createtime;
           int  dt = myDAL.UpdateData("Campseizedmoney", sqlPas);
            return dt;
        }
        [OperationContract]//查询营收单
        public DataSet Campseizedmoney_yingshoudan(int UserID )
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                      new SqlParameter("@UserID",SqlDbType.Int ),
                        };
            sqlPas[0].Value = "Campseizedmoney_yingshoudan";
            sqlPas[1].Value = UserID;
            DataTable dt = myDAL.QueryDataTable("Campseizedmoney", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
