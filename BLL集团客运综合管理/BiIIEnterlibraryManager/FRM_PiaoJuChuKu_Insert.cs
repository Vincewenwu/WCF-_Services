using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;
using System;

namespace BLL集团客运综合管理.BiIIEnterlibraryManager
{
    [ServiceContract]
    class FRM_PiaoJuChuKu_Insert
    {
        DALPublic.DALMethod myDALMethod = new DALPublic.DALMethod();

        #region 查询使用状态
        [OperationContract]
        public DataSet SelectShiYonZhuangTai()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectShiYonZhuangTai";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询用户编号
        [OperationContract]
        public DataSet SelectYonHuBianHao()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYonHuBianHao";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询用户通过用户编号
        [OperationContract]
        public DataSet SelectYonHuByYonHuBianHao(string UserCoding)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@UserCoding",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectYonHuByYonHuBianHao";
            SqlParameters[1].Value = UserCoding;
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 查询票据库存信息
        [OperationContract]
        public DataSet SelectPiaoJuKuCunXinXi()
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar)
            };
            SqlParameters[0].Value = "SelectPiaoJuKuCunXinXi";
            DataTable dt = myDALMethod.QueryDataTable("FRM_PiaoJuChuKu_Insert", SqlParameters);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        #endregion

        #region 新增票据出库信息
        [OperationContract]
        public int InsertPiaoJuChuKu(
            int BiIITypeID, 
            int ReceiveUserID, 
            int UseStateID, 
            int CreateUserID, 
            int DeleteUserID, 
            int BeginTicketMark, 
            int FinishTicketMark,
            int CurrentTicketMark, 
            int SurplusQuantity,
            DateTime RemovaDate, 
            string Comment,
            DateTime CreateTime,
            DateTime LogicalDeleteTime,
            int NeckUseQuantity)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@BiIITypeID",SqlDbType.NChar),
                   new SqlParameter("@ReceiveUserID",SqlDbType.NChar),
                   new SqlParameter("@UseStateID",SqlDbType.NChar),
                   new SqlParameter("@CreateUserID",SqlDbType.NChar),
                   new SqlParameter("@DeleteUserID",SqlDbType.NChar),
                   new SqlParameter("@BeginTicketMark",SqlDbType.NChar),
                   new SqlParameter("@FinishTicketMark",SqlDbType.NChar),
                   new SqlParameter("@CurrentTicketMark",SqlDbType.NChar),
                   new SqlParameter("@SurplusQuantity",SqlDbType.NChar),
                   new SqlParameter("@RemovaDate",SqlDbType.NChar),
                   new SqlParameter("@Comment",SqlDbType.NChar),
                   new SqlParameter("@CreateTime",SqlDbType.NChar),
                   new SqlParameter("@LogicalDeleteTime",SqlDbType.NChar),
                   new SqlParameter("@NeckUseQuantity",SqlDbType.Int)
            };
            SqlParameters[0].Value = "InsertPiaoJuChuKu";
            SqlParameters[1].Value = BiIITypeID;
            SqlParameters[2].Value = ReceiveUserID;
            SqlParameters[3].Value = UseStateID;
            SqlParameters[4].Value = CreateUserID;
            SqlParameters[5].Value = DeleteUserID;
            SqlParameters[6].Value = BeginTicketMark;
            SqlParameters[7].Value = FinishTicketMark;
            SqlParameters[8].Value = CurrentTicketMark;
            SqlParameters[9].Value = SurplusQuantity;
            SqlParameters[10].Value = RemovaDate;
            SqlParameters[11].Value = Comment;
            SqlParameters[12].Value = CreateTime;
            SqlParameters[13].Value = LogicalDeleteTime;
            SqlParameters[14].Value = NeckUseQuantity;
            int result = myDALMethod.UpdateData("FRM_PiaoJuChuKu_Insert", SqlParameters);
            return result;
        }
        #endregion

        #region 新增票据入库信息
        [OperationContract]
        public int UpdatePiaoJuChuKu(int CurrentTicketMark,int Inventory,int BiIIEnterlibraryID)
        {
            SqlParameter[] SqlParameters =
            {
                   new SqlParameter("@TYPE",SqlDbType.NChar),
                   new SqlParameter("@CurrentTicketMark",SqlDbType.Int),
                   new SqlParameter("@Inventory",SqlDbType.Int),
                   new SqlParameter("@BiIIEnterlibraryID",SqlDbType.Int)
            };
            SqlParameters[0].Value = "UpdatePiaoJuChuKu";
            SqlParameters[1].Value = CurrentTicketMark;
            SqlParameters[2].Value = Inventory;
            SqlParameters[3].Value = BiIIEnterlibraryID;
            int result = myDALMethod.UpdateData("FRM_PiaoJuChuKu_Insert", SqlParameters);
            return result;
        }
        #endregion

    }
}
