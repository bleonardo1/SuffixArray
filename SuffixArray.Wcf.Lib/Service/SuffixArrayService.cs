using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SuffixArray.Wcf.Lib.Interface;
using System.IO;
using System.Diagnostics;

namespace SuffixArray.Wcf.Lib
{
    public class SuffixArrayService : ISuffixArrayService
    {
        /// <summary>
        /// Builds the ukkonnen suffix tree and stores in a cache database.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>
        /// ISuffixArrayInfo with basic information about the constructed tree
        /// </returns>
        public ISuffixArrayInfo BuildUkkonnenSuffixTree(string filePath)
        {
            // Create new stopwatch
            Stopwatch stopwatch = new Stopwatch();


            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            Algorithms.UkkonnenBuilder builder = new Algorithms.UkkonnenBuilder();
            // Begin timing
            stopwatch.Start();
            ISuffixArrayInfo info = new SuffixArray.Wcf.Lib.Domain.SuffixArrayInfo();

            using (StreamReader s = new StreamReader(filePath))
            {
                int i = 0;
                char[] buffer = new char[1];
                while (!s.EndOfStream)
                {
                    s.Read(buffer, i, 1);
                    builder.AddChar(buffer[0]);
                }
                info.Nodes = builder.NodeCount;
                info.Edges = builder.EdgeCount;
                info.SuffixLinks = builder.SuffixLinkCount;
            }
            stopwatch.Stop();
            info.TimeToConstruct = stopwatch.Elapsed;
            return info;
        }


        /// <summary>
        /// Builds the N. JESPER LARSSON AND KUNIHIKO SADAKANE faster suffix tree and stores in a cache database.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>
        /// ISuffixArrayInfo with basic information about the constructed tree
        /// </returns>
        public ISuffixArrayInfo BuildLarssonSadakaneuSuffixTree(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
