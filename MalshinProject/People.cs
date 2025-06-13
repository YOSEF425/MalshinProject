using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalshinProject
{
    public class People
    {
        public string FullName { get; }
        public DateTime CreatedAt {  get; }
        public int Id {  get; }

        public People(string fullName,int id)
        {
            FullName = fullName;
            CreatedAt = DateTime.Now;
            Id = id;
          
        }

    }
}
