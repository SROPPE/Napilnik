using System;

namespace Homework2
{
    struct Good
    {
        public string Name { get; }

        public Good(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be empty");

            Name = name;   
        }
    }

}
