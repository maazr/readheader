using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFILEHEADER
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private List<string> lst = new List<string>();
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReadFile_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
            string filename = openFD.FileName;
            tbSelectedFile.Text = filename;
            readheader(filename);
            loadtotable(listBoxSrc);
            LoadChangeList();
            LoadControlList();

        }
        private void LoadChangeList()
        {
            string sqlstr = "select Id,a.ColumnName,b.Cnt from fileColumns a inner join "
            + "(select ColumnName,count(1) cnt from filecolumns group by ColumnName having count(ColumnName)>1) b "
            + " on a.ColumnName = b.ColumnName order by a.ColumnName "; // this query give us reference id for update
            string connstr = GetConnectionString();
            listBoxChng.Items.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connstr;
                conn.Open();
                var da = new SqlDataAdapter(sqlstr, conn);
                var dt = new DataTable();
                string str;
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    listBoxChng.Items.Add(row["ColumnName"].ToString());
                }
            }
        }
        private void LoadControlList()
        {
            string sqlstr = "select Distinct a.ColumnName from fileColumns a inner join "
            + "(select ColumnName,count(1) cnt from filecolumns group by ColumnName having count(ColumnName)>1) b "
            + " on a.ColumnName = b.ColumnName order by a.ColumnName"; // this query give us reference id for update
            string connstr = GetConnectionString();
            listControl.Items.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connstr;
                conn.Open();
                var da = new SqlDataAdapter(sqlstr, conn);
                var dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    listControl.Items.Add(row["ColumnName"].ToString());

                }
            }
        }

        private void RenameColumn()
        {
            /* here we will number duplicate columns
             * 
             *
             *
            string chkstr;
            string str;
            // have to use Datatable, using reader was not successfull.
            */
            for (int i = 0; i < listControl.Items.Count; i++)
            {

                string sValue = listControl.Items[i].ToString();
                int x = -1;
                for (int j = 0; j < listBoxChng.Items.Count; j++)
                {

                    string chkstr = listBoxChng.Items[j].ToString();
                    if (chkstr.Equals(sValue))
                    {
                        x++;
                        if (x == 0)
                        {
                            listBoxResult.Items.Add(string.Format("{0}", listBoxChng.Items[j].ToString()));
                        }
                        else
                        {
                            listBoxResult.Items.Add(string.Format("{0}_{1}", listBoxChng.Items[j].ToString(), x.ToString()));
                        }
                    }
                }

            }

        }

        private void updateHeader(string p1, string p2)
        {
            string updStr = "update filecolumns set ColumnName='" + p2 + "' where ID=" + Int32.Parse(p1);
            string connstr = GetConnectionString();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connstr;
                conn.Open();
                var cmd = new SqlCommand(updStr, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }

        }

        private void loadtotable(ListBox listBoxSrc)
        {
            /* Here we load data from list to database tables
             * 
             */
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                string sqlTrunc = "TRUNCATE TABLE " + "filecolumns";
                SqlCommand cmd = new SqlCommand(sqlTrunc, connection);
                //string sqldel = "delete from filecolumns";
                //SqlCommand cmd = new SqlCommand(sqldel, connection);
                cmd.ExecuteNonQuery();
                string sqlins = "insert into filecolumns (ColumnName) values(";
                string ins;
                foreach (var SrcItem in listBoxSrc.Items)
                {
                    ins = sqlins + "'" + SrcItem.ToString() + "')";
                    cmd = new SqlCommand(ins, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void readheader(string filename)
        {
            /* this is the key here is Microsoft VB library  
             * 
             * 
             */

            TextFieldParser par = new TextFieldParser(new StreamReader(@filename));
            par.HasFieldsEnclosedInQuotes = true;
            par.SetDelimiters(",");
            string strline = "";
            string[] _values = null;
            int row = 0;
            listBoxSrc.Items.Clear();
            while (!par.EndOfData)
            {

                strline = "";
                _values = par.ReadFields();
                string fldstring;
                if (row == 0)
                {
                    int x = 0;
                    foreach (string field in _values)
                    {
                        x++;
                        if (field.IndexOf("'") > 0) { fldstring = field.Replace("'", "''"); }
                        else { fldstring = field; }
                        if (fldstring == "") { fldstring = string.Format("fld{0}", Convert.ToString(x)); }
                        listBoxSrc.Items.Add(fldstring);
                        //listBoxChng.Items.Add(fldstring);
                        //lst.Add(fldstring);
                        //listBoxChng.DataSource = lst;

                    }
                    string colcount = string.Format("# of column(s) : {0}", Convert.ToString(x));
                    labelcolcount.Text = colcount;
                }
                else
                {
                    break;
                }
                row++;


            }
            par.Close();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            //processlist();
            RenameColumn();
        }

        private void processlist()
        {
            // First try using list by self but did not work

            int x = 0;
            string Item1 = "";
            string Item2 = "";
            string newname = "";
            //foreach (var ItemSrc in listBoxSrc.Items )
            for (int i = 0; i < lst.Count; i++)
            {
                Item1 = lst[i].ToString();
                newname = Item1;
                //MessageBox.Show(newname);
                //Item2 = ItemSrc.ToString();
                x = -1;
                listBoxResult.Items.Add(Item1);
                for (int j = 0; j < listBoxChng.Items.Count; j++)
                {
                    Item2 = listBoxChng.Items[j].ToString();
                    MessageBox.Show(Item1 + " " + Item2);
                    if (Item1.Equals(Item2))
                    {

                        x++;
                        if (x > 1)
                        {

                            listBoxResult.Items.Add(string.Format("{0}_{1}", Item2, x.ToString()));
                        }
                    }
                    //lst.RemoveAt(0);
                }
                //lst.RemoveAt(0);
            }
        }
        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            // your database and connection.
            return "Data Source=LT-MRIZKI;Initial Catalog=UTILS;User Id=nu;password=nu;"; // providerName=System.Data.SqlClient";
        }
    }
}
