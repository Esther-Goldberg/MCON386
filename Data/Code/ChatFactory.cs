using MCON368.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCON368.Data.Code
{
    public class ChatFactory
    {
        public static List<ChatEntity> getChatsForGroup(GroupChatEntity groupChatEntity)
        {
            List<ChatEntity> returnData = new();
            DataSet ds = new();
            string strSQL = "EXEC dbo.GroupChat_SELChats '{0}'";

            try
            {
                strSQL = String.Format(strSQL, groupChatEntity.GroupChatKey);
                ds = DataFactory.GetDataSet(strSQL, "ChatMessages");
                foreach (DataRow newRow in ds.Tables[0].Rows)
                {
                    ChatEntity newChatMessage = new();
                    newChatMessage.GroupChatKey = Convert.ToInt32(newRow["GroupChatKey"]);
                    newChatMessage.GroupName = newRow["Header"].ToString();
                    newChatMessage.ChatMessage = newRow["ChatMessage"].ToString();
                    newChatMessage.DisplayName = newRow["FirstName"].ToString() + " " + newRow["LastName"].ToString();
                    newChatMessage.UserProfileKey = Convert.ToInt16(newRow["UserProfileKey"]);
                    newChatMessage.CreatedDateTime = Convert.ToDateTime(newRow["CreatedDateTime"]);

                    returnData.Add(newChatMessage);
                }
                return returnData;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error getting the chat messages: " + ex.Message);
            }
        }
    }
}
