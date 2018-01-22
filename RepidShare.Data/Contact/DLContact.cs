using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepidShare.Entities;
using System.Data.SqlClient;
using System.Data;

namespace RepidShare.Data
{
    public class DLContact
    {
        /// <summary>
        /// Insert ContactUS Details
        /// </summary>
        /// <param name="objContactModel"></param>
        /// <returns></returns>
        public ContactModel InsertContactUSDetails(ContactModel objContactModel)
        {
            try
            {                
                int ErrorCode = 0;
                string ErrorMessage = "";
                SqlParameter pErrorCode = new SqlParameter("@ErrorCode", ErrorCode);
                pErrorCode.Direction = ParameterDirection.Output;
                SqlParameter pErrorMessage = new SqlParameter("@ErrorMessage", ErrorMessage);
                pErrorMessage.Direction = ParameterDirection.Output;

                SqlParameter[] parmList = {
                                         new SqlParameter("@FirstName",objContactModel.FirstName.Trim())
                                        ,new SqlParameter("@LastName",objContactModel.LastName.Trim())
                                        ,new SqlParameter("@DaytimeContactNumber",Convert.ToString(objContactModel.DaytimeContactNumber))
                                        ,new SqlParameter("@MobileTelephoneNumber",Convert.ToString(objContactModel.MobileTelephoneNumber))
                                        ,new SqlParameter("@Email",objContactModel.Email)
                                        ,new SqlParameter("@Message",objContactModel.MessageBody)                                        
                                        ,pErrorCode
                                        ,pErrorMessage
                                      };

                //If  CategoryId is 0 Than Insert  Category else Update  Category
                SQLHelper.ExecuteNonQuery(SQLHelper.ConnectionStringLocalTransaction, CommandType.StoredProcedure, DBConstants.Web_InsertContactUSDetails, parmList);
                //set error code and message 
                objContactModel.ErrorCode = Convert.ToInt32(pErrorCode.Value);
                objContactModel.Message = Convert.ToString(pErrorMessage.Value);
                return objContactModel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
