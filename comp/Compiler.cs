using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp
{
    class Compiler
    {
        private Dictionary<string, string[]> t;

        public Compiler(Dictionary<string, string[]> _t)
        {
            t = _t;
            foreach (var key in t.Keys.ToArray())
            {
                t[key] = t[key];
            }
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

        public string f(string x, string inp, out bool consumed)
        {
            foreach (var s in x)
            {
                if (!terminal(s.ToString()))
                {
                    string aux;
                    foreach (var child in t)
                    {

                    }
                    aux = f(t[s.ToString()], inp, out consumed);
                    if(consumed)
                    {
                        if(aux == "")
                        inp = aux;
                    }
                    else
                    {
                        return x;
                    }
                }
                else
                {
                    if (inp.Length == 0)
                    {
                        consumed = false;
                        return null;
                    }
                    if (s == inp[0])
                        inp = inp.Substring(1);
                    else
                    {
                        consumed = false;
                        return null;
                    }
                }
            }
            consumed = true;
            return inp;
        }

        public bool terminal(string key) => !t.ContainsKey(key);
    }
}
