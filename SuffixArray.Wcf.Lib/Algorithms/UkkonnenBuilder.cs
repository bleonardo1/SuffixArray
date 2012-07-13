using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuffixArray.Wcf.Lib.Interface;

namespace SuffixArray.Wcf.Lib.Algorithms
{
    public class UkkonnenBuilder
    {
        public int NodeCount { get; private set; }
        public int EdgeCount { get; private set; }
        public int SuffixLinkCount { get; private set; }
        public StringBuilder Text { get; set; }

        public UkkonnenBuilder()
        {
            Text = new StringBuilder();
        }
        
        public void AddChar(char c)
        {
#if DEBUG
            Text.Append(c);
#endif
        }
    }
}
