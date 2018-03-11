namespace Lib2
{
    using System;

    public class NastyClass
    {
        public NastyClass(object obj)
        {
            if (obj == null) throw new ArgumentException(nameof(obj)); // violates
        }


        // empty line above violates
    }
}
