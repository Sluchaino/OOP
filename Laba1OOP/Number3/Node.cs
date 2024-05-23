using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number3
{
    public class Node
    {
        public int value;
        public List<Node> childrens;

        public Node(int _value)
        {
            value = _value;
            childrens = new List<Node>();
        }

        public void PrintValues()
        {
            Console.WriteLine(value); 

            if (childrens.Count > 0)
            {
                foreach (Node child in childrens)
                {
                    child.PrintValues(); 
                }
            }
        }
    }
}