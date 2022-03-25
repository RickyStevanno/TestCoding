using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace CodingAssesment
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSort_Click(object sender, EventArgs e)
        {
            var FileExtension = FileUpload1.FileName.ToString().Split('.').Last();
            //validate the file here
            if (FileExtension != "txt" || FileExtension == "")
            {
                lblMessage.Text = "File yang di upload harus .txt !";
                return;
            }
            else
            {
                //read the text file
                List<string> TheString = new List<string>();
                FileUpload fu = FileUpload1;
                if (fu.HasFile)
                {
                    StreamReader reader = new StreamReader(fu.FileContent);
                    do
                    {
                        string textLine = reader.ReadLine();
                        TheString.Add(textLine);

                    } while (reader.Peek() != -1);
                    reader.Close();
                }
                if (TheString.Count > 0)
                {
                    try
                    {
                        string[] Stringarray = TheString.ToArray();
                        NameSorter S = new NameSorter();
                        S.DoTheSort(Stringarray);
                        //Show the result to grid
                        DataTable dt = new DataTable();
                        using (System.IO.TextReader tr = File.OpenText((@"D:\\sorted-names-list.txt")))
                        {
                            string line;
                            //add new list of string arrey
                            List<string[]> lststr = new List<string[]>();
                            while ((line = tr.ReadLine()) != null)
                            {

                                string[] items = line.Trim().Split(' ');
                                lststr.Add(items);
                            }
                            int col = lststr.Max(x => x.Length);
                            if (dt.Columns.Count == 0)
                            {
                                // Create the data columns for the data table based on the number of items
                                // on the first line of the file
                                for (int i = 0; i < col; i++)
                                    dt.Columns.Add(new DataColumn("Column" + i, typeof(string)));
                            }
                            // loop the list 
                            foreach (string[] item in lststr)
                            {
                                dt.Rows.Add(item);
                            }


                        }
                        //show it in gridview 
                        gridResult.DataSource = dt;
                        gridResult.DataBind();
                    }
                    catch (Exception ex)
                    {

                        lblMessage.Text = ex.Message.ToString();
                    }
                   
                  
                }
                
            }
           

        }
    }
}