using SalesProgram.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesProgram
{
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
        }

        DBSalesProgramContext ctx = new DBSalesProgramContext();
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBarcode.Text.Length <= 3)
                {
                    txtQuantity.Text = txtBarcode.Text;
                    txtBarcode.Clear();
                    txtBarcode.Focus();
                }
                else
                {
                    var product = ctx.Products.Where(x => x.Barcode == txtBarcode.Text).FirstOrDefault();
                    int RowCount = datagridSales.Rows.Count;
                    bool added = false;
                    if (product != null)
                    {
                        if (RowCount > 0)
                        {
                            for (int i = 0; i < RowCount; i++)
                            {
                                if (datagridSales.Rows[i].Cells["Barcode"].Value.ToString()==txtBarcode.Text)
                                {
                                    datagridSales.Rows[i].Cells["Quantity"].Value = Convert.ToDouble(txtQuantity.Text) + Convert.ToDouble(datagridSales.Rows[i].Cells["Quantity"].Value);
                                    datagridSales.Rows[i].Cells["Total"].Value = Math.Round((Convert.ToDouble(datagridSales.Rows[i].Cells["Quantity"].Value) * (double)product.SalesPrice), 2);
                                    added = true;
                                }
                            }
                        }
                        if (!added)
                        {
                            datagridSales.Rows.Add();
                            datagridSales.Rows[RowCount].Cells["Barcode"].Value = txtBarcode.Text;
                        }
                    }
                }
            }
        }
    }
}
