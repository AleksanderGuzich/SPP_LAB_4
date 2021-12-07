using System;
using System.Collections.Generic;
using TestGenerator;

namespace ConsoleApp
{
    class Program
    {
        private const string SourceFilePath1 =
            "C:\\Users\\Xiaomi\\Desktop\\СПП лабы\\LAB_4 (tests)\\TestClassLib\\ClassExample1.cs";

        private const string SourceFilePath2 =
            "C:\\Users\\Xiaomi\\Desktop\\СПП лабы\\LAB_4 (tests)\\TestClassLib\\ClassExample3.cs";

        private const string OutDirPath = "C:\\Users\\Xiaomi\\Desktop\\СПП лабы\\LAB_4 (tests)\\GenClasses";

        private const int MaxParallelTasksCount = 3;


        static void Main(string[] args)
        {
            var testsGenerator = new TestsGenerator(MaxParallelTasksCount);
            testsGenerator.Generate(new List<string>() {SourceFilePath1, SourceFilePath2}, OutDirPath).Wait();
        }
    }
}