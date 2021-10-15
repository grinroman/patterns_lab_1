using System;
using System.Collections.Generic;
using System.Text;

namespace lab_real_1_patterns
{
    class Singleton
    {

        private Singleton()
        {
            Data1 = "kek1";
            Data2 = "kek1";
        }

        public string Data1 { get; set; }
        public string Data2 { get; set; }

        static Lazy<Singleton> unique = new Lazy<Singleton>(new Singleton());
        public static Singleton Instance => unique.Value;
    }
}
