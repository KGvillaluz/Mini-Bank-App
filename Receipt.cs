using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;

namespace BankManagement
{
    internal class Receipt
    {
        public static string userName, transactionType;
        public static int accountID, transactionID;
        public static float currentBalance, amount, newBalance;
        public Receipt()
        {
        }

        public void printReceipt()
        {
            MessageBox.Show(receiptContent());
        }

        public string receiptContent()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"\n");
            str.AppendLine($"-------------------------------------------------------");
            str.AppendLine($"                      MINI BANK APP           ");
            str.AppendLine($"-------------------------------------------------------"); 
            str.AppendLine($"Username                : {userName}");
            str.AppendLine($"Account ID              : {accountID}"); 
            str.AppendLine($"Transaction No        : {transactionID}");
            str.AppendLine($"Transaction Type     : {transactionType}");
            str.AppendLine($"Current Balance       : ${currentBalance}");
            str.AppendLine($"Amount                    : ${amount}");
            str.AppendLine($"New Balance            : ${newBalance}");
            str.AppendLine($"-------------------------------------------------------");
            str.AppendLine($"\n");
            str.AppendLine($"Excellent customer service is the number \n one job in any company");
            str.AppendLine("\n");

            return str.ToString();
        }
    }
}
