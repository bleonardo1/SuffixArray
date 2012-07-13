using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SuffixArray.Wcf.Lib.Interface
{
    /// <summary>
    /// Defines the interface to build and search for patterns in a text for different Suffix Arrays implementatations
    /// </summary>
    [ServiceContract]
    public interface ISuffixArrayService
    {
        /// <summary>
        /// Builds the ukkonnen suffix tree and stores in a cache database.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>ISuffixArrayInfo with basic information about the constructed tree</returns>
        [OperationContract]
        ISuffixArrayInfo BuildUkkonnenSuffixTree(string filePath);

        /// <summary>
        /// Builds the N. JESPER LARSSON AND KUNIHIKO SADAKANE faster suffix tree and stores in a cache database.
        /// </summary>
        /// <remarks>
        /// http://www.larsson.dogma.net/ssrev-tr.pdf
        /// </remarks>
        /// <param name="filePath">The file path.</param>
        /// <returns>ISuffixArrayInfo with basic information about the constructed tree</returns>
        [OperationContract]
        ISuffixArrayInfo BuildLarssonSadakaneuSuffixTree(string filePath);
    }
}
