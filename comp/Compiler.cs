using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp
{
    class Compiler
    {
        private Dictionary<string, string> t;

        public Compiler(Dictionary<string, string> t)
        {
            this.t = t;
        }

        public string Print()
        {
            string s = "";
            foreach (var item in t)
            {
                s += $"{item.Key} -> {item.Value}\n";
            }
            return s;
        }

        public string f(string x, string inp)
        {
            foreach (var s in x)
            {
                if (!terminal(s.ToString()))
                {
                    inp += f(t[s.ToString()], inp);
                }
                else
                {
                    //if(inp.Length > 0)
                    //    return 
                    if (s == inp[0])
                        inp = inp.Substring(1);
                    //else if (!terminal(s.ToString()))
                    //    return f(s.ToString(), inp);
                    //else
                    //    return x;
                }
            }
            return inp;
        }

        public bool terminal(string key) => !t.ContainsKey(key);
    }
}
