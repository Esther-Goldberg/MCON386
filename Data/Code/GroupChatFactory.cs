using MCON368.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCON368.Data.Code
{
    public class GroupChatFactory
    {
        public static List<GroupChatEntity> GetGroupChats()
        {
            List<GroupChatEntity> returnData = new();
            DataSet ds = new();
            string strSQL = "EXEC dbo.GroupChat_SELStats";
            
            try
            {
                ds = DataFactory.GetDataSet(strSQL, "Chats");
                foreach (DataRow newRow in ds.Tables[0].Rows)
                {
                    GroupChatEntity newChat = new();
                    newChat.GroupName = newRow["Header"].ToString();
                    newChat.MetroColorKey = Convert.ToInt16(newRow["MetroColorKey"]);
                    newChat.NumberOfUsers = Convert.ToInt16(newRow["MemberCount"]);
                    newChat.NumberOfChats = Convert.ToInt16(newRow["ChatCount"]);
                    newChat.GroupChatKey = Convert.ToInt32(newRow["GroupChatKey"]);

                    newChat.ChatColor = GlobalSettingsEntity.currentUser.StartupObjects.MetroColorList.Where(x => x.MetroColorKey == newChat.MetroColorKey).FirstOrDefault();
                    returnData.Add(newChat);
                }
                return returnData;
            }
            catch (Exception ex)
            {
                throw new Exception("There was an error getting the group chats: " + ex.Message);
            }
        }
    }
}
