using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacherConsole
{
    internal class IdGenerator
    {
        private static int currentId = 0;

        public static int NextId()
        {
            currentId++;
            return currentId;
        }
    }
}
