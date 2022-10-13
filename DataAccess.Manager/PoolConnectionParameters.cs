using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Manager {
    // Summary:
    //     Represents a parameter to a Command and optionally
    //     its mapping to System.Data.DataSet columns.
    public class PoolConnectionParameters {
        /// <summary>
        /// Gets or sets the name of the parameter
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Gets or sets the value of the parameter.
        /// </summary>
        public object ParameterValue { get; set; }

        /// <summary>
        /// Gets or sets the DbType of the parameter.
        /// </summary>
        public int? ParemeterDbType { get; set; }

        /// <summary>
        /// Gets or sets the direccion of the parameter
        /// </summary>
        public int? ParameterDirection { get; set; }
    }
}
