using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsInstaller;
using System.IO;
using System.Collections;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using Microsoft.Office.Interop.Excel;


namespace MSIInspector
{
    public partial class mainForm : Form
    {
        [System.Runtime.InteropServices.ComImport(),
            System.Runtime.InteropServices.Guid
            ("000C1090-0000-0000-C000-000000000046")]
        
        
        class Installer { }
        private Hashtable Tables;
        private Database instDb;
        private string[] UITables = new string[]{"CheckBox", "ActionText", "ComboBox", "Control",
            "ControlCondition", "ControlEvent", "Dialog", "ListBox", "ListView", "RadioButton", "Icon"};

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // clear out in advance
            pruneContent();
            if (msiPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbxFilePath.Text = msiPath.FileName;
            }
            else
            {
                // do nothing, not OK response
                return;
            }

        }

        private Boolean already_populated()
        {
            if (dgTables.RowCount > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void pruneContent()
        {
            List<string> boilerplate = new List<string>();
            // check for content already there
            if (already_populated())
            {
                // clear out rows over the first 5
                for (int tabIndex = 0; tabIndex < 6; tabIndex++)
                {
                    // keep the defined
                    TabPage thisTab = tbList.TabPages[tabIndex];
                    boilerplate.Add(thisTab.Name);
                    DataGridView dg = (DataGridView)thisTab.Controls[0];
                    foreach (DataGridViewRow row in dg.Rows)
                    {
                        dg.Rows.Remove(row);
                    }
               
                }
                // delete the remaining
                foreach (TabPage page in tbList.TabPages)
                {
                    if (boilerplate.IndexOf(page.Name) == -1)
                    {
                        tbList.TabPages.Remove(page);
                    }
                }
            }
            
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //TODO: read data from _Tables and _Columns to generate automatically.
            //TODO: on Browse, if data exists clear it out
            if (tbxFilePath.Text.Length == 0)
            {
                // No file path, eject
                return;
            }
            if (!File.Exists(tbxFilePath.Text))
            {
                // no such file, eject
                return;
            }

            // check for content already there
            pruneContent();

            FileInfo msiFile = new FileInfo(tbxFilePath.Text);
            // open MSI database
            WindowsInstaller.Installer inst = (WindowsInstaller.Installer)new Installer();
            instDb = inst.OpenDatabase(msiFile.FullName,
                WindowsInstaller.MsiOpenDatabaseMode.msiOpenDatabaseModeReadOnly);

            Tables = new Hashtable();
            // Load all the tables and columns
            WindowsInstaller.View TableView = instDb.OpenView
                 ("Select `Name` FROM `_Tables` ORDER BY `Name`");
            TableView.Execute(null);
            Record tablerecord = TableView.Fetch();
            while (tablerecord != null)
            {
                int iRow = dgTables.Rows.Add();
                try
                {
                    string queryText = "Select `Table`,`Number`,`Name` FROM `_Columns` WHERE `Table`='" + tablerecord.get_StringData(1) + "' ORDER BY `Number`";
                    WindowsInstaller.View colView = instDb.OpenView
                        (queryText);
                    colView.Execute(null);
                    List<string> Columns = new List<string>();
                    Record colrec = colView.Fetch();
                    while (colrec != null)
                    {
                        Columns.Add(colrec.get_StringData(3));
                        colrec = colView.Fetch();
                    }
                    Tables[tablerecord.get_StringData(1)] = Columns;
                    dgTables.Rows[iRow].Cells[1].Value = string.Join(",", Columns);
                }
                catch (COMException exception)
                {
                    
                            dgTables.Rows[iRow].Cells[1].Value = "COM Exception Raised: " + exception.Message;
                }
                // register the table
                dgTables.Rows[iRow].Cells[0].Value = tablerecord.get_StringData(1);
                tablerecord = TableView.Fetch();
            }
            TableView.Close();
            //if (Tables.ContainsKey("Environment"))
            //{
            //    // Enviroment Variables
            //    WindowsInstaller.View EnvView = instDb.OpenView
            //        ("Select `Environment`,`Name`,`Value`,`Component_` FROM `Environment`");
            //    EnvView.Execute(null);
            //    //fetch each record...
            //    Record erecord = EnvView.Fetch();
            //    while (erecord != null)
            //    {
            //        int iRow = envList.Rows.Add();
            //        envList.Rows[iRow].Cells[0].Value = erecord.get_StringData(1);
            //        envList.Rows[iRow].Cells[1].Value = erecord.get_StringData(2);
            //        envList.Rows[iRow].Cells[2].Value = erecord.get_StringData(3);
            //        envList.Rows[iRow].Cells[3].Value = erecord.get_StringData(4);
            //        erecord = EnvView.Fetch();
            //    }
            //    // close the database
            //    EnvView.Close();
            //}
            // query the database
            WindowsInstaller.View PropView = instDb.OpenView
                ("Select `Property`,`Value` FROM `Property` ORDER BY `Property`");
            PropView.Execute(null);
            //fetch each record...
            Record precord = PropView.Fetch();
            while (precord != null)
            {
                int iRow = propertyList.Rows.Add();
                propertyList.Rows[iRow].Cells[0].Value = precord.get_StringData(1);// property
                propertyList.Rows[iRow].Cells[1].Value = precord.get_StringData(2);// value
                precord = PropView.Fetch();
            }
            // close the database
            PropView.Close();
            // query the database
            WindowsInstaller.View DirView = instDb.OpenView
                ("Select `Directory`,`Directory_Parent`,`DefaultDir` FROM `Directory`");
            DirView.Execute(null);
            //fetch each record...
            Record drecord = DirView.Fetch();
            while (drecord != null)
            {
                int iRow = directoryList.Rows.Add();
                directoryList.Rows[iRow].Cells[0].Value = drecord.get_StringData(1);// directory
                directoryList.Rows[iRow].Cells[1].Value = drecord.get_StringData(2);// directory_parent
                directoryList.Rows[iRow].Cells[2].Value = drecord.get_StringData(3);// defaultdir
                drecord = DirView.Fetch();
            }
            // close the database
            DirView.Close();
            // query the database
            WindowsInstaller.View CompView = instDb.OpenView
                ("Select `Component`,`ComponentId`,`Directory_`,`Attributes`,`Condition`,`KeyPath` FROM `Component`");
            CompView.Execute(null);
            //fetch each record...
            Record crecord = CompView.Fetch();
            while (crecord != null)
            {
                int iRow = componentList.Rows.Add();
                componentList.Rows[iRow].Cells[0].Value = crecord.get_StringData(1);
                componentList.Rows[iRow].Cells[1].Value = crecord.get_StringData(2);
                componentList.Rows[iRow].Cells[2].Value = crecord.get_StringData(3);
                componentList.Rows[iRow].Cells[3].Value = crecord.get_StringData(4);
                componentList.Rows[iRow].Cells[4].Value = crecord.get_StringData(5);
                componentList.Rows[iRow].Cells[5].Value = crecord.get_StringData(6);
                crecord = CompView.Fetch();
            }
            // close the database
            CompView.Close();
            // query the database
            try
            {
                WindowsInstaller.View actView = instDb.OpenView
                    ("Select `Action`,`Condition`,`Sequence` From `InstallExecuteSequence`");
                actView.Execute(null);
                //fetch each record...
                Record mrecord = actView.Fetch();
                while (mrecord != null)
                {
                    int iRow = actionList.Rows.Add();
                    actionList.Rows[iRow].Cells[0].Value = "Normal";
                    actionList.Rows[iRow].Cells[1].Value = mrecord.get_StringData(1);
                    actionList.Rows[iRow].Cells[2].Value = mrecord.get_StringData(2);
                    actionList.Rows[iRow].Cells[3].Value = mrecord.get_StringData(3);
                    mrecord = actView.Fetch();
                }
                // load the admin
                actView = instDb.OpenView
                    ("Select `Action`,`Condition`,`Sequence` From `AdminExecuteSequence`");
                actView.Execute(null);
                //fetch each record...
                Record arecord = actView.Fetch();
                while (mrecord != null)
                {
                    int iRow = actionList.Rows.Add();
                    actionList.Rows[iRow].Cells[0].Value = "Admin";
                    actionList.Rows[iRow].Cells[1].Value = arecord.get_StringData(1);
                    actionList.Rows[iRow].Cells[2].Value = arecord.get_StringData(2);
                    actionList.Rows[iRow].Cells[3].Value = arecord.get_StringData(3);
                    arecord = actView.Fetch();
                }
                actView.Close();
            }
            catch
            {
                String tables = "";
                WindowsInstaller.View mView = instDb.OpenView
                    ("Select `Name` FROM `_Tables`");
                mView.Execute(null);
                Record mrecord = mView.Fetch();
                while (mrecord != null)
                {
                    tables = tables + ";" + mrecord.get_StringData(1);
                    mrecord = mView.Fetch();
                }
                MessageBox.Show("Tables: " + tables);
            }
            // query the database
            try
            {
                WindowsInstaller.View custView = instDb.OpenView
                    ("Select `Action`,`Type`,`Source`,`Target`,`ExtendedType` From `CustomAction`");
                custView.Execute(null);
                //fetch each record...
                Record mrecord = custView.Fetch();
                while (mrecord != null)
                {
                    int iRow = custactList.Rows.Add();
                    custactList.Rows[iRow].Cells[0].Value = mrecord.get_StringData(1);
                    custactList.Rows[iRow].Cells[1].Value = mrecord.get_StringData(2);
                    custactList.Rows[iRow].Cells[2].Value = mrecord.get_StringData(3);
                    custactList.Rows[iRow].Cells[3].Value = mrecord.get_StringData(4);
                    custactList.Rows[iRow].Cells[4].Value = mrecord.get_StringData(5);
                    mrecord = custView.Fetch();
                }
                // close the database
                custView.Close();
            }
            catch
            {
                String tables = "";
                WindowsInstaller.View mView = instDb.OpenView
                    ("Select `Name` FROM `_Tables`");
                mView.Execute(null);
                Record mrecord = mView.Fetch();
                while (mrecord != null)
                {
                    tables = tables + ";" + mrecord.get_StringData(1);
                    mrecord = mView.Fetch();
                }
                //{
                //    // have a table, list the columns
                //    String columns = "";
                //    WindowsInstaller.View colView = instDb.OpenView
                //        ("Select `Table`,`Number`,`Name` FROM `_Columns` WHERE `Table`==`MoveFile`");
                //    colView.Execute(null);
                //    Record colrecord = colView.Fetch();
                //    while (colrecord != null)
                //    {
                //        columns = columns + "," + colrecord.get_StringData(3);
                //    }
                //    MessageBox.Show("Columns: " + columns);
                //}
            }
            

            List<string> Conflicts = new List<string>();
            foreach (DictionaryEntry de in Tables)
            {
                string TableName = de.Key.ToString();
                List<string> Columns = (List<string>)de.Value;
                if (cbxExcludeUI.Checked.Equals(true))
                {
                    if (TableName.Contains("UI") || UITables.Contains(TableName))
                    {
                        continue;
                    }
                }
                
                if (TableName.Equals("Properties") || TableName.Equals("AdminExecuteSequence") || TableName.Equals("InstallExecuteSequence") || 
                    TableName.Equals("Components") || TableName.Equals("CustomAction") || TableName.Equals("Directory") ||
                    TableName.StartsWith("_"))
                {
                    // don't re-report
                    continue;
                }
                
                TabPage added = new TabPage(de.Key.ToString());
                DataGridView addeddg = new DataGridView();
                added.Size = new System.Drawing.Size(667, 400);
                added.Margin = new System.Windows.Forms.Padding(5);
                added.Padding = new System.Windows.Forms.Padding(5);
                added.AutoScroll = true;
                added.Location = new System.Drawing.Point(0, 0);
                added.Padding = new System.Windows.Forms.Padding(5);
                addeddg.Size = new System.Drawing.Size(667, 400);
                addeddg.Dock = DockStyle.Fill;
                addeddg.Margin = new System.Windows.Forms.Padding(5);
                addeddg.AllowUserToAddRows = false;
                addeddg.AllowUserToDeleteRows = false;
                addeddg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
                addeddg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                addeddg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                addeddg.Location = new System.Drawing.Point(0, 0);
                addeddg.ReadOnly = true;
                addeddg.TabIndex = 0; 
                foreach (string columnname in Columns)
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = columnname;
                    col.Name = TableName + "." + columnname;
                    addeddg.Columns.Add(col);
                }
                addeddg.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(this.sequenceColumnHeaderClick);
                List<string> quoted = new List<string>();
                foreach (string unpretty in Columns)
                {
                    quoted.Add(String.Format("`{0}`", unpretty));
                }
                
                string QueryText = String.Format("Select {0} FROM `{1}`", string.Join(",", quoted), TableName);
                // now created the tab, load the data
                try
                {
                    WindowsInstaller.View tView = instDb.OpenView
                        (QueryText);
                    tView.Execute(null);
                    Record trecord = tView.Fetch();
                    while (trecord != null)
                    {
                        int iRow = addeddg.Rows.Add();
                        foreach (string columnname in Columns)
                        {
                            addeddg[TableName + "." + columnname, iRow].Value = trecord.get_StringData(Columns.IndexOf(columnname)+1);
                        }
                        trecord = tView.Fetch();
                    }
                    tView.Close();
                }
                catch (COMException)
                {
                    Conflicts.Add(TableName);
                    continue;
                }
                // Add the controls
                added.Controls.Add(addeddg);
                tbList.Controls.Add(added);

            }
            // Write out conflists
            if (Conflicts.Count() != 0)
            {
                string dumpfile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "dump.csv");
                System.IO.StreamWriter sw = new StreamWriter(dumpfile);
                sw.WriteLine("Conflicts,Table,Columns");
                foreach (DictionaryEntry de in Tables)
                {
                    if (Conflicts.IndexOf(de.Key.ToString()) != -1)
                    {
                        sw.WriteLine
                            (String.Format("Y,{0},{1}", de.Key.ToString(), String.Join(",", (List<string>)de.Value)));
                    }
                    else
                    {
                        sw.WriteLine
                            (String.Format("N,{0},{1}", de.Key.ToString(), String.Join(",", (List<string>)de.Value)));
                    }
                }
                sw.Close();

            }
            btnExportAll.Enabled = true;
            btnExportTable.Enabled = true;

        }

       

        private void sequenceColumnHeaderClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgView = (DataGridView)sender;
            DataGridViewColumn newColumn = dgView.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dgView.SortedColumn;
            ListSortDirection direction;

            // If oldColumn is null, then the DataGridView is not sorted.
            if (oldColumn != null)
            {
                // Sort the same column again, reversing the SortOrder.
                if (oldColumn == newColumn &&
                    actionList.SortOrder == SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    // Sort a new column and remove the old SortGlyph.
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }

            // Sort the selected column.
            dgView.Sort(new ColumnSort(direction, e.ColumnIndex));

            newColumn.HeaderCell.SortGlyphDirection =
                direction == ListSortDirection.Ascending ?
                SortOrder.Ascending : SortOrder.Descending;
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            string targetFile = "";
            string SourceFile = tbxFilePath.Text;
            // Suggest MSI filename with xlsx
            saveFileSelector.FileName = System.IO.Path.ChangeExtension(SourceFile, ".xlsx");
            if (saveFileSelector.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                targetFile = saveFileSelector.FileName;
            }
            else
            {
                // do nothing, not OK response
                return;
            }
            
            // TODO: Implement this
            Excel.Application xlApp;
            Excel.Workbook xlBook;
            Excel.Worksheet xlSheet;
            try
            {
                xlApp = new Excel.Application();
                // Create a workbook
                xlBook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                // Iterate over the tables, one per Tab
                // Write the tables first
                xlSheet = xlBook.ActiveSheet;
                xlSheet.Name = "Tables";
                xlSheet.Cells[1, 1] = "Table";
                xlSheet.Cells[1, 2] = "Columns";
                xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 2]].Font.Bold = true;
                // TODO: Finish Me - put out all tables in the Tab "Tables"
                ICollection _Tables = Tables.Keys;

                foreach (DictionaryEntry de in Tables)
                {
                    string TableName = de.Key.ToString();
                    List<string> Columns = (List<string>)de.Value;
                    if (cbxExcludeUI.Checked.Equals(true))
                    {
                        if (TableName.Contains("UI") || UITables.Contains(TableName))
                        {
                            continue;
                        }
                    }
                    // Add a Sheet
                    xlSheet = xlBook.Sheets.Add();
                    // Set the Tab Name
                    xlSheet.Name = TableName;
                    // Add the columns
                    for (int colidx = 0; colidx < Columns.Count; colidx++)
                    {
                        xlSheet.Cells[1, colidx + 1] = Columns[colidx];
                    }
                    
                    xlSheet.Range[xlSheet.Cells[1,1],xlSheet.Cells[1, Columns.Count]].Font.Bold = true;

                    List<string> quoted = new List<string>();
                    foreach (string unpretty in Columns)
                    {
                        quoted.Add(String.Format("`{0}`", unpretty));
                    }

                    string QueryText = String.Format("Select {0} FROM `{1}`", string.Join(",", quoted), TableName);
                    // now created the tab, load the data
                    try
                    {
                        // Sure this could be done better, but hey
                        int currentRow = 2;
                        WindowsInstaller.View tView = instDb.OpenView
                            (QueryText);
                        tView.Execute(null);
                        Record trecord = tView.Fetch();
                        while (trecord != null)
                        {
                            for (int colidx=0; colidx < Columns.Count; colidx++)
                            {
                                xlSheet.Cells[currentRow, colidx + 1].NumberFormat = "@";
                                xlSheet.Cells[currentRow, colidx + 1] = trecord.get_StringData(colidx + 1);
                            }
                            trecord = tView.Fetch();
                            currentRow += 1;
                        }
                        tView.Close();
                    }
                    catch (Exception theException)
                    {
                        String errorMessage;
                        errorMessage = "Error: ";
                        errorMessage = String.Concat(errorMessage, theException.Message);
                        errorMessage = String.Concat(errorMessage, " Line: ");
                        errorMessage = String.Concat(errorMessage, theException.Source);
                        errorMessage = String.Concat(errorMessage, "TableName: " + TableName);
                        MessageBox.Show(errorMessage, "Error"); 
                    }
                }

                // TODO: Sort the Tabs
                xlBook.SaveAs(targetFile);
                xlBook.Close();
            }
            catch ( Exception theException )
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
            
        }

        private void btnExportTable_Click(object sender, EventArgs e)
        {
            // TODO: Implement this
        }

        
       
    }

    class ColumnSort : IComparer
    {
        private static int sortOrderModifier = 1;
        private static int columnNumber = 1;

        public ColumnSort(SortOrder sortOrder, int ColumnNumber)
        {
            columnNumber = ColumnNumber;
            if (sortOrder == SortOrder.Descending)
            {
                sortOrderModifier = -1;
            }
            else if (sortOrder == SortOrder.Ascending)
            {
                sortOrderModifier = 1;
            }
        }

        public ColumnSort(ListSortDirection sortOrder, int ColumnNumber)
        {
            columnNumber = ColumnNumber;
            if (sortOrder == ListSortDirection.Descending)
            {
                sortOrderModifier = -1;
            }
            else if (sortOrder == ListSortDirection.Ascending)
            {
                sortOrderModifier = 1;
            }
        }

        public int Compare(object a, object b)
        {
            DataGridViewRow DataGridViewRow1 = (DataGridViewRow)a;
            DataGridViewRow DataGridViewRow2 = (DataGridViewRow)b;
            try
            {
                string _c_a = DataGridViewRow1.Cells[columnNumber].Value.ToString();
                string _c_b = DataGridViewRow2.Cells[columnNumber].Value.ToString();
                int _a = Convert.ToInt16(_c_a);
                int _b = Convert.ToInt16(_c_b);
                return _a.CompareTo(_b);
            }
            catch (System.FormatException)
            {
                // Assume conversion to Int failed
                return System.String.Compare(DataGridViewRow1.Cells[0].ToString(),
                                            DataGridViewRow2.Cells[1].ToString());
            }
        }
    }

}
