namespace MCON368.Entity
{
    public class GroupChatEntity
    {
        public int GroupChatKey { get; set; }
        public string GroupName { get; set; }
        public DateTime LastChatDateTime { get; set; }
        public DateTime ChatCreatedDateTime { get; set; }
        public bool ActiveInd { get; set; }
        public int NumberOfUsers { get; set; }
        public int NumberOfChats { get; set; }
        public MetroColorEntity ChatColor { get; set; }
    }
}