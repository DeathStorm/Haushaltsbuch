using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haushaltsbuch
{
    public partial class frmMain : Form
    {

        private struct BudgetEntry
        {
            internal int id;
            internal int categoryID;
            internal float value;
            internal string comment;
            internal DateTime paidOn;
            internal DateTime createdOn;
        }

        private Dictionary<int, BudgetEntry> budgetEntries = new Dictionary<int, BudgetEntry>();
        private Dictionary<int, string> categories = new Dictionary<int, string>();


        public frmMain()
        {
            InitializeComponent();

            BudgetEntry budgetEntry = new BudgetEntry();
            budgetEntry.id = 0;
            budgetEntry.categoryID = 0;
            budgetEntry.value = 79.53f;
            budgetEntry.comment = "Nur Benzin sonst nix";
            budgetEntries.Add(0, budgetEntry);

            budgetEntry = new BudgetEntry();
            budgetEntry.id = 1;
            budgetEntry.categoryID = 0;
            budgetEntry.value = 83.55f;
            budgetEntry.comment = "Nur Benzin sonst nix, ausser was zu trinken";
            budgetEntries.Add(1, budgetEntry);

            categories.Add(0, "Tanken");
            categories.Add(1, "Mittagessen AC");
            categories.Add(2, "Einkaufen");
            categories.Add(3, "etc.");

            
        }

        private void dateiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void miFileQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            frmNewEntryDialoge newEntry = new frmNewEntryDialoge();
            newEntry.cbCategory.DataSource = new BindingSource(categories, null);
            newEntry.cbCategory.DisplayMember = "Value";
            newEntry.cbCategory.ValueMember = "Key";
            newEntry.dtCreatedOn.Value = DateTime.Now;
            newEntry.dtPaidOn.Value = DateTime.Now;

            if (newEntry.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                BudgetEntry budgetEntry = new BudgetEntry();

                if (newEntry.cbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Eine neue Kategorie \"" + newEntry.cbCategory.Text + "\" wird angelegt.", "Neue Kategorie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    int nextCatID = -1;
                    foreach (int catId in categories.Keys)
                    { if (catId > nextCatID) nextCatID = catId; }
                    nextCatID++;
                    categories.Add(nextCatID, newEntry.cbCategory.Text);

                    budgetEntry.categoryID = nextCatID;
                }
                else
                {
                    budgetEntry.categoryID = (int)newEntry.cbCategory.SelectedValue;
                }

                int nextNo = -1;
                foreach (BudgetEntry entry in budgetEntries.Values)
                { if (entry.id > nextNo) nextNo = entry.id; }

                
                budgetEntry.id = nextNo + 1;
                
                budgetEntry.value = (float)newEntry.nudValue.Value;
                budgetEntry.comment = newEntry.tbComment.Text;
                budgetEntry.createdOn = newEntry.dtCreatedOn.Value;
                budgetEntry.paidOn = newEntry.dtPaidOn.Value;

                budgetEntries.Add(budgetEntry.id,budgetEntry);
                ShowEntries();
            }
            
            
        }

        private void ShowEntries()
        {
            dgBudgetEntries.Rows.Clear();
            foreach (BudgetEntry budgetEntrie in budgetEntries.Values)
            {
                DataGridViewRow row = dgBudgetEntries.Rows[dgBudgetEntries.Rows.Add(1)];
                row.Cells[colID.Name].Value = budgetEntrie.id.ToString();
                row.Cells[colCategory.Name].Value = categories[budgetEntrie.categoryID].ToString();
                row.Cells[colValue.Name].Value = budgetEntrie.value.ToString();
                row.Cells[colComment.Name].Value = budgetEntrie.comment.ToString();

                row.Cells[colCreatedOn.Name].Value = budgetEntrie.createdOn.ToString("dd.MM.yyyy");
                row.Cells[colPaidOn.Name].Value = budgetEntrie.paidOn.ToString("dd.MM.yyyy");
            }
        }

    }
}
