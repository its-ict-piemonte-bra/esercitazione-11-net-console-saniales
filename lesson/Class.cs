using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    public class Class
    {
        public string Name {
            get
            {
                return this.name;
            }
        }

        private string name;

        public ClassMember[] Members {
            get
            {
                return this.members;
            }
        }

        private ClassMember[] members;

        public Class(string name, ClassMember[] members)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            if (members == null || members.Length == 0)
            {
                throw new ArgumentException("Members cannot be null or empty");
            }

            this.name = name;
            this.members = members;
        }
    }
}
