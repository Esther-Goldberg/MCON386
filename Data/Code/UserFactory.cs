using MCON368.Entity;
using Microsoft.Identity.Client;
using System.Data;

namespace MCON368.Data.Code
{
    public class UserFactory
    {
        public UserProfileEntity GetUserInformation(string userName, string password)
        {
            string strSQL = "EXEC dbo.UserProfile_SEL '{0}'";
            DataSet ds = new();
            UserProfileEntity returnData = new();

            try
            {
                ds = DataFactory.GetDataSet(strSQL, "UserInformation");
                returnData.UserName = userName;
                returnData.Password = password;
                returnData.ErrorMessage = ValidateUser(ds, returnData);
                if(string.IsNullOrEmpty(returnData.ErrorMessage))
                {
                    returnData = PopulateUserInformation(ds);
                    returnData.StartupObjects = StartupFactory.GetStartUpData();
                }
            } catch (Exception ex)
            {
                returnData.ErrorMessage = ex.Message;
            }
            return returnData;
        }

        private string ValidateUser(DataSet ds, UserProfileEntity returnData)
        {
            if (ds == null || ds.Tables[0].Rows.Count == 0) // no rows returned because username doesn't exist
            {
                return "No user information found for username " + returnData.UserName;
            } else if (returnData.Password == null || ds.Tables[0].Rows[0]["Password"].ToString() != returnData.Password)
            {
                return "Invalid password";
            }
            else if (ds.Tables[0].Rows[0]["ActiveInd"].ToString() != "1")
            {
                return "User is inactive";
            } else
            {
                return "";
            }

        }

        public UserProfileEntity PopulateUserInformation(DataSet ds)
        {
            UserProfileEntity returnData = new();

            try
            {
                returnData.UserProfileKey = Convert.ToInt32(ds.Tables[0].Rows[0]["UserProfileKey"].ToString());
                returnData.FirstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                returnData.LastName = ds.Tables[0].Rows[0]["LastName"].ToString();
                returnData.EmailAddress = ds.Tables[0].Rows[0]["EmailAddress"].ToString();
                returnData.PhoneNumber = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
                returnData.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                returnData.Password = ds.Tables[0].Rows[0]["Password"].ToString();
                returnData.CreatedBy = ds.Tables[0].Rows[0]["CreatedBy"].ToString();
                returnData.CreatedDateTime = Convert.ToDateTime(ds.Tables[0].Rows[0]["CreatedDateTime"].ToString());
                returnData.ActiveInd = ds.Tables[0].Rows[0]["ActiveInd"].ToString() == "1" ? true : false;
                returnData.DisplayName = ds.Tables[0].Rows[0]["DisplayName"].ToString();
                returnData.LastRefreshed = DateTime.Now;
                returnData.SQLUserName = ds.Tables[0].Rows[0]["SQLUserName"].ToString();

            } catch (Exception ex)
            {
                returnData.ErrorMessage = ex.Message;
            }

            return returnData;

        }
    }
}