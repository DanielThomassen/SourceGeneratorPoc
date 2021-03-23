using System;
using System.CodeDom.Compiler;
using Demo;

namespace Run
{
    class Program
    {
        static void Main(string[] args)
        {
            var vm = new Class1ViewModel();
            vm.Message = "Hello World";

            if(vm.ShowMessage)
            {
                Console.WriteLine(vm.Message);
            }
            
        }
    }


}
