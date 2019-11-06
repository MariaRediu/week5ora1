using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Comment
    {
        private List<string> input;
        public Comment()
        {
            this.Input = input;

        }
        public List<string> Input { get; set; }

        public void AddComment(string inputComent)
        {
            input.Add(inputComent);
        }

        public void PrintComment()
        {
            foreach (var item in input)
            {
                Console.WriteLine("Coment:" + input);
            }
        }
          
    }
}
