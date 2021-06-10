using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Model.Accounting;

namespace XeroNetStandardApp.Models {
    public class InvoiceModel {
        // Value of the checkbox
        public Invoice invoice { get; set; }

        public System.Guid? invoiceId { get; set; }

        // whether the checkbox is selected or not
        public bool isChecked { get; set; }
    }
}