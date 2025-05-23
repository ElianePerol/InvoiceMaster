﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Master.BLL
{
    internal class TransactionsBLL
    {
        public int id { get; set; }
        public string type { get; set; }
        public int dea_cust_id { get; set; }
        public decimal grand_total { get; set; }
        public DateTime transaction_date { get; set; }
        public decimal vat { get; set; }
        public decimal discount { get; set; }
        public int added_by { get; set; }
        public DataTable TransactionDetails { get; set; }
    }
}
