using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial34
{
    class StringSet
    {
        private string[] stringSet;
        private int cnt;

        public StringSet(string[] s)
        {
            stringSet = new string[s.Length];
            for(int i=0; i<s.Length; ++i)
                stringSet[i] = s[i];
            cnt = s.Length;
        }

        public StringSet(int i)
        {
            stringSet = new string[i];
            cnt = 0;
        }

        public int Length
        {
            get
            {
                return cnt;
            }
        }

        public string this[int idx]
        {
            get
            {
                if (idx >= cnt)
                    throw new IndexOutOfRangeException();
                return stringSet[idx];
            }
            set
            {
                if (idx >= cnt)
                    throw new IndexOutOfRangeException();
                stringSet[idx] = value;
            }
        }

        public void Add(string s)
        {
            if (cnt >= stringSet.Length)
                Array.Resize<string>(ref stringSet, stringSet.Length + 10);
            stringSet[cnt++] = s;
        }

        public void Remove(string rs)
        {
            int idx = -1;
            for(int i = 0; i < cnt; i++)
            {
                if(stringSet[i].Equals(rs))
                {
                    idx = i;
                    break;
                }
            }
            if (idx >= 0)
            {
                for (int i = idx; i < cnt - 1; i++)
                    stringSet[i] = stringSet[i + 1];
                cnt--;
            }
        }

        public StringSet Intersection(StringSet anStringSet)
        {
            StringSet retStringSet = new StringSet(this.Length > anStringSet.Length ? this.Length : anStringSet.Length);
            foreach(string s in stringSet)
            {
                for(int i = 0; i < anStringSet.Length; ++i)
                {
                    if (s.Equals(anStringSet[i]))
                        retStringSet.Add(s);
                }
            }
            return retStringSet;
        }

        public StringSet Sum(StringSet anStringSet)
        {
            StringSet retStringSet = new StringSet(stringSet);
            for(int i=0; i < anStringSet.Length; ++i)
            {
                bool repeat = false;
                foreach(string s in stringSet)
                {
                    if (s.Equals(anStringSet[i]))
                        repeat = true;
                }
                if (repeat == false)
                    retStringSet.Add(anStringSet[i]);
            }
            return retStringSet;
        }

        public StringSet Diff(StringSet anStringSet)
        {
            StringSet retStringSet = new StringSet(stringSet);
            for (int i = 0; i < anStringSet.Length; ++i)
            {
                foreach (string s in stringSet)
                {
                    if (s.Equals(anStringSet[i]))
                        retStringSet.Remove(s);
                }
               
            }
            return retStringSet;
        }


    }
}
