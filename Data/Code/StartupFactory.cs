﻿using MCON368.Entity;

using MCON368.Data.Code;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MCON368.Data
{
    public class StartupFactory
    {
        public static StartUpObjectEntity GetStartUpData() 
        {
            DataSet ds = new();
            StartUpObjectEntity returnData = new();
            string strSQL = "EXEC dbo.StartUpLists_SEL";

            try
            {
                ds = DataFactory.GetDataSet(strSQL, "StartUpData");
                returnData.MetroColorList = LoadMetroColorList(ds.Tables[2]);
                returnData.UserList = LoadUserList(ds.Tables[0]);
                returnData.GroupChatList = LoadGroupChatList(ds.Tables[1], returnData.MetroColorList);
            }
            catch (Exception ex)
            {
                returnData.ErrorObject = ex;
            }
            return returnData;
        }

        private static List<GroupChatEntity> LoadGroupChatList(DataTable dataTable, List<MetroColorEntity> colorList)
        {
            List<GroupChatEntity> returnData = new();
            foreach (DataRow newRow in dataTable.Rows)
            {
                GroupChatEntity newItem = new();
                newItem.GroupChatKey = Convert.ToInt32(newRow["GroupChatKey"]);
                newItem.MetroColorKey = Convert.ToInt32(newRow["MetroColorKey"]);
                newItem.ChatCreatedDateTime = Convert.ToDateTime(newRow["CreatedDateTime"]);
                newItem.GroupName = newRow["Header"].ToString();
                newItem.ChatColor = colorList.Where(color => color.MetroColorKey == newItem.MetroColorKey).FirstOrDefault();
                returnData.Add(newItem);
            }
            return returnData;
        }

        private static List<UserProfileEntity> LoadUserList(DataTable dataTable)
        {
            List<UserProfileEntity> returnData = new();
            foreach (DataRow newRow in dataTable.Rows)
            {
                UserProfileEntity newItem = new();
                newItem.ActiveInd = Convert.ToInt16(newRow["ActiveInd"]) == 1;
                newItem.PhoneNumber = newRow["PhoneNumber"].ToString();
                newItem.CreatedDateTime = Convert.ToDateTime(newRow["CreatedDateTime"]);
                newItem.EmailAddress = newRow["EmailAddress"].ToString();
                newItem.FirstName = newRow["FirstName"].ToString();
                newItem.LastName = newRow["LastName"].ToString();
                newItem.UserProfileKey = Convert.ToInt32(newRow["UserProfileKey"]);
                newItem.SQLUserName = newRow["SQLUserName"].ToString();
                newItem.UserName = newRow["UserName"].ToString();
                newItem.Password = newRow["Password"].ToString();
                newItem.LastRefreshed = DateTime.Now;
                returnData.Add(newItem);
            }
            return returnData;
        }

        private static List<MetroColorEntity> LoadMetroColorList(DataTable dataTable)
        {
            List<MetroColorEntity> returnData = new();
            foreach (DataRow newRow in dataTable.Rows)
            {
                MetroColorEntity newItem = new();
                newItem.RGB = newRow["RGB"].ToString();
                newItem.HexNumber = newRow["HexNumber"].ToString();
                newItem.ColorName = newRow["ColorName"].ToString();
                newItem.MetroColorKey = Convert.ToInt32(newRow["MetroColorKey"]);
                returnData.Add(newItem);
            }
            return returnData;
        }
    }
}