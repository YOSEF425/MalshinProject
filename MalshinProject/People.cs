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
        public string SecretCode {  get; }

        public People(string fullName,string secret_code)
        {
            FullName = fullName;
            CreatedAt = DateTime.Now;
            SecretCode = secret_code;
          
        }

    }
}
