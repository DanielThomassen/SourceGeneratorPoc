using System;
using System.ComponentModel;
using ModelGenerator;

namespace Demo
{
    [HasViewModel]
    public class Class1
    {
        public string Message {get;set;}

        public bool ShowMessage { get; set; } = true;

        public Class2 Class2 { get; set; }
        
    }

    [HasViewModel]
    public class Class2
    {
        public Class1 Model { get; set; }

    }
}
