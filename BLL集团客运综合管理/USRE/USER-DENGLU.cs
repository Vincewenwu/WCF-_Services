using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.USRE
{
    [ServiceContract]
    class USER_DENGLU
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]//查询用户
        public DataSet Selectyonghu()
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "Selectyonghu";
            DataTable dt = myDAL.QueryDataTable("UserLogin", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//查询密码通过用户
        public DataSet SelectMiMaBYyonghu(int UserID)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        new SqlParameter("@UserID",SqlDbType.Int),
                        };
            sqlPas[0].Value = "SelectMiMaBYyonghu";
            sqlPas[1].Value = UserID;
         DataTable dt = myDAL.QueryDataTable("UserLogin", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        [OperationContract]//直接输入看是否
        public DataSet selectzhijie(string UserMC ,string Password)
        {
            SqlParameter[] sqlPas = {
                    new SqlParameter("@SN",SqlDbType.NChar),
                        new SqlParameter("@UserMC",SqlDbType.NChar),
                            new SqlParameter("@Password",SqlDbType.NChar),
                        };
            sqlPas[0].Value = "SelectMiMaBYyonghu";
            sqlPas[1].Value = UserMC;
            sqlPas[2].Value = Password;
            DataTable dt = myDAL.QueryDataTable("UserLogin", sqlPas);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
