namespace MCON368.Entity
{
    public class ChatEntity
    {
        public int GroupChatKey { get; set; }
        public string GroupName { get; set; }
        public string ChatMessage { get; set; }
        public string DisplayName { get; set; }
        public int UserProfileKey { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}