namespace csharp_day1.Models
{
    class Animal
    {
        // public string name; //Field

        public string Name { get; private set; }
        private int Age { get; set; }


        public void Birthday()
        {
            Age++;
        }



        public string ChangeName(string newName)
        {
            Name = newName;
            if (newName.ToLower() == "simba")
            {
                return "he's a killer, he killed his father";
            }
            return "Success";
        }

        public Animal(string name)
        {
            Name = name;
            Age = 0;
        }


    }
}