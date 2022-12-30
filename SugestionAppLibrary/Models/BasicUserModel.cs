namespace SugestionAppLibrary.Models
{
    public class BasicUserModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string DisplayName { get; set; }

        // Implicit constructor
        public BasicUserModel()
        {

        }

        // Explicit constructor
        public BasicUserModel(UserModel user)
        {
            Id = user.Id;
            DisplayName = user.DisplayName;
        }
    }
}
