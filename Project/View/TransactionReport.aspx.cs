using CrystalDecisions.CrystalReports.Engine;
using Project.Handler;
using Project.Model;
using Project.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != UserHandler.findUserRole("U002").UserRoleId.ToString())
            {
                Response.Redirect("/View/Login.aspx");
            }

            CrystalReport tr = new CrystalReport();
            CrystalReportViewer1.ReportSource = tr;
            tr.SetDataSource(GetData(TransactionRepository.getTransaction()));
        }

        private DataSet GetData(List<Transaction> transactions)
        {
            DataSet rds = new DataSet();
            var TransactionTable = rds.HeaderTransaction;
            var DetailTransactionTable = rds.DetailTransaction;

            foreach (Transaction transaction in transactions)
            {
                var TransactionRow = TransactionTable.NewRow();
                TransactionRow["TransactionId"] = transaction.TransactionId;
                TransactionRow["Username"] = transaction.MsUser.UserName;
                TransactionRow["TransactionDate"] = transaction.TransactionDate;
                TransactionTable.Rows.Add(TransactionRow);

                foreach (Transaction detailTransaction in transactions)
                {
                    var DetailTransactionRow = DetailTransactionTable.NewRow();
                    DetailTransactionRow["TransactionId"] = transaction.TransactionId;
                    DetailTransactionRow["ProductName"] = detailTransaction.ShoeTable.ShoeName;
                    DetailTransactionRow["ProductPrice"] = detailTransaction.ShoeTable.ShoePrice;
                    DetailTransactionRow["Quantity"] = detailTransaction.Quantity;
                    DetailTransactionTable.Rows.Add(DetailTransactionRow);
                }

            }

            return rds;
        }


    }
}