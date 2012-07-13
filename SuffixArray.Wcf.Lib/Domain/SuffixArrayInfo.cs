using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SuffixArray.Wcf.Lib.Interface;

namespace SuffixArray.Wcf.Lib.Domain
{
    [DataContract]
    public class SuffixArrayInfo : ISuffixArrayInfo
    {
        [DataMember]
        public TimeSpan TimeToConstruct { get; set; }
        [DataMember]
        public int Nodes { get; set; }
        [DataMember]
        public int Edges { get; set; }
        [DataMember]
        public int SuffixLinks { get; set; }
        [DataMember]
        public string Message { get; set; }

    }
}
