namespace MCON368.Entity
{
    public class StartUpObjectEntity
    {
     public List<UserProfileEntity> UserList { get; set; }
     public List<GroupChatEntity> GroupChatList { get; set; }
     public List<MetroColorEntity> MetroColorList { get; set; }
     public Exception ErrorObject { get; set; }
    }
}