using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTasks
{
    public class Branch
    {
        private string name;
        private List<Branch> branches;

        public Branch(string name)
        {
            this.name = name;
            this.branches = new List<Branch>();
        }

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }

        public int GetDepth()
        {
            int maxChildDepth = 0;
            foreach (var branch in branches)
            {
                int childDepth = branch.GetDepth();
                if (childDepth > maxChildDepth)
                {
                    maxChildDepth = childDepth;
                }
            }
            return maxChildDepth + 1;
        }
        public void PrintBranches(int depth)
        {
            Console.WriteLine($"{name} - Depth: {depth}");
            foreach (var branch in branches)
            {
                branch.PrintBranches(depth+1);
            }
        }
    }
}


