namespace dojo_survey.Models
{
    public class User
    {
        // ~~~~~~~~~~Fields~~~~~~~~~~
        public string FullName { get; set; }
        public string Location {get; set;}
        public string Language {get; set;}
        public string Comment {get; set;}
        
        // ~~~~~~~~~~Constructors~~~~~~~~~~
        public User() { }
        public User(string fullName, string location, string language, string comment)
        {
            FullName = fullName;
            Location = Location;
            Language = language;
            Comment = comment;
        }

        // ~~~~~~~~~~ Other Functions ~~~~~~~~~~
        public string String()
        {
            return FullName + " from " + Location + " likes " + Language + ". They said " + Comment + ".";
        }
    }
}