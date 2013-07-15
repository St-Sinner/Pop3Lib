using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pop3Lib.MIME
{
    /// <summary>
    /// Объектное представление MIME-заголовка Content-Disposition
    /// </summary>
    public class ContentDisposition : ParametersBase
    {

        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName
        {
            get
            {
                if (this.Parameters != null && this.Parameters.ContainsKey("filename"))
                {
                    return this.Parameters["filename"];
                }
                return String.Empty;
            }
        }

        public ContentDisposition(string source)
            : base(source)
        {
        }

    }
}