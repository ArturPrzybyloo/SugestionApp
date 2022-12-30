namespace SugestionAppLibrary.Models
{
    public class BasicSuggestionModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Suggestion { get; set; }

        // Implicit constructor
        public BasicSuggestionModel()
        {

        }

        // Explicit constructor
        public BasicSuggestionModel(SuggestionModel suggestion)
        {
            Id = suggestion.Id;
            Suggestion = suggestion.Suggestion;
        }
    }
}
