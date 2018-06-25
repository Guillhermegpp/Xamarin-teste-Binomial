using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Binomial
{
    public class History
    {


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string hora { get; set; }
        [MaxLength(100)]
        public string resul { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}\n", hora, resul);

        }

    }
}
