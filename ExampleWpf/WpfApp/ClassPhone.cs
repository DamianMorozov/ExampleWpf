﻿namespace WpfApp
{
    public class ClassPhone
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Name {Name}; Cost: {Price}";
        }
    }
}
