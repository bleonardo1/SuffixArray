using System;
namespace SuffixArray.Wcf.Lib.Interface
{
    public interface ISuffixArrayInfo
    {
        TimeSpan TimeToConstruct { get; set; }
        int Edges { get; set; }
        int Nodes { get; set; }
        int SuffixLinks { get; set; }
        string Message { get; set; }
    }
}
