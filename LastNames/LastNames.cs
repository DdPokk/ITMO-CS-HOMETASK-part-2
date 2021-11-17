using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastNames
{
    class LastNames
    {
        private List<string> ln;

        public LastNames(List<string> initialList)
        {
            ln = new List<string>();
            foreach(string a in initialList)
            {
                ln.Add(a);
            }
            ln.Sort();
        }

        private int getLastNameIndex(string searchLN)
        {
            int index = -1;
            for(int i = 0; i < ln.Count; ++i)
            {
                if (ln[i].Equals(searchLN))
                {
                    index = i + 1;
                    break;
                }
                    
            }
            return index;
        }

        private void addLastName(string addLN)
        {
            ln.Add(addLN);
            ln.Sort();
        }

        static string Capitalize(string s)
        {
            s = s[0].ToString().ToUpper() + s.Substring(1).ToLower();
            return s;
        }

        public string ProcessLastName(string lastName)
        {
            lastName = Capitalize(lastName);
            int result = getLastNameIndex(lastName);
            if (result < 0)
            {
                addLastName(lastName);
                result = getLastNameIndex(lastName);
            }

            string ret = $"Searched Last name {lastName} has {result} index\n";
            ret += string.Join("\n", ln);
            return ret;

        }
    }
}
