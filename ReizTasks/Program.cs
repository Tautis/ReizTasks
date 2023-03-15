using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock obj = new Clock();
            obj.clock();


            var rootBranch = new Branch("1");

            var newBranch = new Branch("2");
            rootBranch.AddBranch(newBranch);

            var branch2 = new Branch("3");
            newBranch.AddBranch(branch2);

            var newBranch2 = new Branch("2");
            rootBranch.AddBranch(newBranch2);

            var branch3 = new Branch("3");
            newBranch2.AddBranch(branch3);

            var branch4 = new Branch("4");
            branch3.AddBranch(branch4);

            var branch3_1 = new Branch("3");
            newBranch2.AddBranch(branch3_1);

            var branch4_1 = new Branch("4");
            branch3_1.AddBranch(branch4_1);

            var branch5 = new Branch("5");
            branch4_1.AddBranch(branch5);

            var branch4_2 = new Branch("4");
            branch3_1.AddBranch(branch4_2);

            var branch3_2 = new Branch("3");
            newBranch2.AddBranch(branch3_2);

            //rootBranch.PrintBranches(0);
            int depth = rootBranch.GetDepth();

            Console.WriteLine($"Depth of structure: {depth}");

        }
    }
}
