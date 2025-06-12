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
        public int SecretCode {  get; }

        public People(string fullName,int id,int secret_code)
        {
            FullName = fullName;
            CreatedAt = DateTime.Now;
            SecretCode = secret_code;
            Id = id;
        }

    }
}
