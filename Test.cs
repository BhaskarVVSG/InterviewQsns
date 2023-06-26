using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQsns
{
    public   class Test
    {
        public string name { get; set; }
        public string rollno { get; set; }
        public Test()
        {
            this.name = "bhaskar";

        }
        public void method1()
        {
            Console.WriteLine(this.name+this.rollno);
          
        }

    }
   
     
    
}
