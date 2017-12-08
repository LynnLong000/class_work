using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public void SetItem (string key , string value)
        {

        }

        public void GetItem (string ket , string value)
        {

        }

        public string this [string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
