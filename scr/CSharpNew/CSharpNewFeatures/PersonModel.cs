namespace CSharpNewFeatures
{
    public class PersonModel
    {
        // New init accessor available for props.
        public int Id { get; init; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }

        public PersonModel()
        {
        }
        public PersonModel(int id, string fisrtName, string lastName)
        {
            Id = id;
            FisrtName = fisrtName;
            LastName = lastName;
        }
    }
}