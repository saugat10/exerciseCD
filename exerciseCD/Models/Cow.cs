namespace exerciseCD.Models
{
    public class Cow
    {
        public int myProperty { get; set; }

        public string Name { get; set; }

        public int Weight { get; set; }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException("Name cannot be null");
            }

            if(Name.Length < 2) 
            {
                throw new ArgumentException("Name must have atleast 3 characters");
            }
        }

        public override string ToString()
        {
            return $"Cow: {Name} weights {Weight} pounds";
        }

    }
}
