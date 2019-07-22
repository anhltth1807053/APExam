namespace APExam
{
    public class People
    {
        public bool Gender { get; set; }
        public string Name{ get; set; }
        public int Age { get; set; }

        public People()
        {
        }

        public People(bool gender, string name, int age)
        {
            Gender = gender;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            var sGender = Gender ? "Male" : "Female";
            return $"Name = {Name}, Gender = {sGender}, Age={Age}";
        }

    }
}