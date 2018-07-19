using System;

namespace EnumFlagsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecutionSettings executionSettings = ExecutionSettings.None | ExecutionSettings.AllowUiPostconditions | ExecutionSettings.AllowAutoLogIn;

            //true 
            Console.WriteLine(executionSettings.HasFlag(ExecutionSettings.AllowUiPostconditions));

            //false
            Console.WriteLine(executionSettings.HasFlag(ExecutionSettings.AllowUiPreconditions));

            //true
            Console.WriteLine(executionSettings.HasFlag(ExecutionSettings.AllowAutoLogIn));
            Console.ReadKey();
            
        }
    }
}
