using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDesperser
{
    class StringDisperser : ICloneable, IEnumerable
    {
        public StringDisperser() { }
        public StringDisperser(params string[] text)
        {
            this.Text = text;
        }

        public string[] Text { get; set; }

        public object Clone()
        {
            return new StringDisperser()
            {
                Text=(string[])this.Text.Clone()
            };
        }

        public override string ToString()
        {
            return string.Join("", Text);
        }

        public IEnumerator GetEnumerator()
        {
            var joinedString = this.ToString();
            for (int i = 0; i < joinedString.Length; i++)
            {
                yield return joinedString[i];
            }
        }
    }
}
