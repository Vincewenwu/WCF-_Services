using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL集团客运综合管理.BiIIEnterlibraryManager
{
    [ServiceContract]
    class FRM_PiaoJuRuKu_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询票据类型
        [OperationContract]
        public DataSet SelectBiIIType()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectBiIIType";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuRuKu_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 新增票据入库
        [OperationContract]
        public int InsertBiIIEnterlibraryXinXi(
            int BiIITypeID, 
            int CreateUserID, 
            int DeleteUserID, 
            int BeginTicketMark, 
            int FinishTicketMark, 
            int CurrentTicketMark, 
            int EnterlibraryQuantity,
            int Inventory, 
            DateTime EnterlibraryDate, 
            string Comment)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@BiIITypeID",SqlDbType.Int),
                   new SqlParameter("@CreateUserID",SqlDbType.Int),
                   new SqlParameter("@DeleteUserID",SqlDbType.Int),
                   new SqlParameter("@BeginTicketMark",SqlDbType.Int),
                   new SqlParameter("@FinishTicketMark",SqlDbType.Int),
                   new SqlParameter("@CurrentTicketMark",SqlDbType.Int),
                   new SqlParameter("@EnterlibraryQuantity",SqlDbType.Int),
                   new SqlParameter("@Inventory",SqlDbType.Int),
                   new SqlParameter("@EnterlibraryDate",SqlDbType.Date),
                   new SqlParameter("@Comment",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "InsertBiIIEnterlibraryXinXi";
            SqlParameters[1].Value = BiIITypeID;
            SqlParameters[2].Value = CreateUserID;
            SqlParameters[3].Value = DeleteUserID;
            SqlParameters[4].Value = BeginTicketMark;
            SqlParameters[5].Value = FinishTicketMark;
            SqlParameters[6].Value = CurrentTicketMark;
            SqlParameters[7].Value = EnterlibraryQuantity;
            SqlParameters[8].Value = Inventory;
            SqlParameters[9].Value = EnterlibraryDate;
            SqlParameters[10].Value = Comment;
            int result = myDALMethod.UpdateData("FRM_PiaoJuRuKu_Insert", SqlParameters);
            return result;
        }
        #endregion
    }
}
