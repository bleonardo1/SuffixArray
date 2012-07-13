using System;
using System.Collections.Generic;
using System.Text;
using Gallio.Framework;
using MbUnit.Framework;
using MbUnit.Framework.ContractVerifiers;
using System.IO;

namespace SuffixArray.Test
{
    [TestFixture]
    public class UkkonenTest
    {
        [Test]
        [Row("world192.txt")]
        [Row("bible.txt")]
        public void Test(string fileName)
        {
            SuffixArray.Wcf.Lib.SuffixArrayService service = new Wcf.Lib.SuffixArrayService();
            service.BuildUkkonnenSuffixTree(Path.Combine(Environment.CurrentDirectory, "Files", fileName));
        }
    }
}
