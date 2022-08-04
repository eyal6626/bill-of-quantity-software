using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;
using Xceed.Document.NET;
using System.Diagnostics;
using WindowsFormsApp2.Properties;
using System.Windows.Forms;
using BorderStyle = Xceed.Document.NET.BorderStyle;

namespace WindowsFormsApp2
{
    class File
    {
        private string fileName;
        public File(string name)
        {
            //Get the path to the desktop
            this.fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + name;
        }
        public string getFileName()
        {
            return this.fileName;
        }
        public void createFile(string fileTitle,int numberOfRows, List<Tuple<string, string, string>> selectedWorkList,int totalProjectAmount)
        {
            //Create a new file
            var doc = DocX.Create(this.fileName);
            //Add the title to the file
            if (Settings.Default["designOption"].Equals(1))
                firstDesign(fileTitle, doc);
            else
                secondDesign(fileTitle, doc);
            createTable(numberOfRows,doc,selectedWorkList);

            if(Settings.Default["showTotalAmount"].Equals(true) || Settings.Default["showTotalAmountAfterTax"].Equals(true))
                addTheTotalAmountOfTheProject(doc,totalProjectAmount);
            
            if(Settings.Default["ShowLastPar"].Equals(true))
                addBottomParagraph(doc);
            
            doc.Save();
            if(Settings.Default["openTheFileAtTheEnd"].Equals(true))
                Process.Start("WINWORD.EXE", this.fileName);
            else
                MessageBox.Show("הקובץ נוצר בהצלחה, הוא נמצא בשולחן העבודה", "הודעת הצלחה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addBottomParagraph(DocX doc)
        {
            //Formatting Title  
            Formatting textFormat = new Formatting();
            //Specify font family  
            textFormat.FontFamily = new Font("Arial");
            //Specify font size  
            textFormat.Size = 12;
            textFormat.FontColor = System.Drawing.Color.Black;
            textFormat.Bold = true;
            //Insert the title
            string text = "מחירים כוללים: עבודה וחומרים, טעינה ופריקה של החומרים, פינוי הפסולת, כל הכלים וכלי עזר הדרושים לצורך ביצוע העבודות.\nמחירים אינם כוללים: הקמת פיגומים לצורך ביצוע העבודות במידת הצורך, הזמנת מנוף, תוספות וחריגים.";
            Paragraph titlePar = doc.InsertParagraph("\n"+text, false, textFormat);
            titlePar.Alignment = Alignment.right;
        }

        private void addTheTotalAmountOfTheProject(DocX doc, int totalProjectAmount)
        {
            //Create the table  
            Table table = doc.AddTable(1, 2);
            table.Alignment = Alignment.center;
            Border b = new Border(BorderStyle.Tcbs_none, BorderSize.one, 1, System.Drawing.Color.White);
            table.SetBorder(TableBorderType.Bottom, b);
            table.SetBorder(TableBorderType.Left, b);
            table.SetBorder(TableBorderType.Right, b);
            table.SetBorder(TableBorderType.Top, b);
            table.SetBorder(TableBorderType.InsideH, b);
            table.SetBorder(TableBorderType.InsideV, b);
            //Calc and build the string
            string theAmountAfter = "₪" + ((((totalProjectAmount * 17) / 100) + totalProjectAmount)).ToString();
            string theAmountBefore = "₪" + totalProjectAmount.ToString();
            theAmountBefore = "סכום לפני מע\"מ" + ": " + theAmountBefore;
            theAmountAfter = "סכום אחרי מע\"מ" + ": " + theAmountAfter;

            //Add text 
            if (Settings.Default["showTotalAmountAfterTax"].Equals(true))
                table.Rows[0].Cells[0].Paragraphs.First().Append("\n"+theAmountAfter).FontSize(14).Bold(true);
            if (Settings.Default["showTotalAmount"].Equals(true))
                table.Rows[0].Cells[1].Paragraphs.First().Append("\n" + theAmountBefore).FontSize(14).Bold(true);

            //Change the side of the text
            Paragraph curText = table.Paragraphs[0];
            curText.Alignment = Alignment.left;
            curText = table.Paragraphs[1];
            curText.Alignment = Alignment.right;

            doc.InsertTable(table);
        }

        private void createFirstDesignTitle(string title,DocX doc)
        {
            //Formatting Title  
            Formatting titleFormat = new Formatting();
            //Specify font family  
            titleFormat.FontFamily = new Font("Arial");
            //Specify font size  
            titleFormat.Size = 22;
            titleFormat.FontColor = System.Drawing.Color.Black;
            titleFormat.UnderlineColor = System.Drawing.Color.Black;
            titleFormat.Bold = true;
            //Insert the title
            Paragraph titlePar = doc.InsertParagraph(title+"\n\n", false, titleFormat);
            titlePar.Alignment = Alignment.center;

        }

        private void createSecondDesignTitle(string title, DocX doc)
        {
            //Formatting Title  
            Formatting titleFormat = new Formatting();
            //Specify font family  
            titleFormat.FontFamily = new Font("Arial");
            //Specify font size  
            titleFormat.Size = 22;
            titleFormat.FontColor = System.Drawing.Color.Black;
            titleFormat.UnderlineColor = System.Drawing.Color.Black;
            titleFormat.Bold = true;
            //Insert the title
            Paragraph titlePar = doc.InsertParagraph("הצעת מחיר לעבודת שיפוץ" + "\n", false, titleFormat);
            titlePar.Alignment = Alignment.center;
            addDateAndCompanyName(doc);
            titleFormat.Size = 14;
            titleFormat.Bold = true;
            titleFormat.UnderlineColor = System.Drawing.Color.White;
            Paragraph address = doc.InsertParagraph("כתובת" + ": "+ title + "\n", false, titleFormat);
            address.Alignment = Alignment.right;
            
        }

        private void createTable(int row,DocX doc, List<Tuple<string, string, string>> selectedWorkList)
        {
            //Create the table  
            Table table = doc.AddTable(row, 3);
            table.Alignment = Alignment.center;
            table.Design = TableDesign.TableGrid;
            //Set the table cells titles to the center
            Paragraph curText = table.Paragraphs[0];
            curText.Alignment = Alignment.center;
            curText = table.Paragraphs[1];
            curText.Alignment = Alignment.center;
            curText = table.Paragraphs[2];
            curText.Alignment = Alignment.center;
            //Fill cells by adding text.  
            table.Rows[0].Cells[2].Paragraphs.First().Append("תיאור העבודה").FontSize(16).Bold(true);
            table.Rows[0].Cells[1].Paragraphs.First().Append("יחידה").FontSize(16).Bold(true);
            table.Rows[0].Cells[0].Paragraphs.First().Append("מחיר").FontSize(16).Bold(true);
            //table.Rows[0].Cells[0].Paragraphs.First().Append("תאריך").FontSize(16).Bold(true);
            addDataToTable(table, row, selectedWorkList);
            table.SetColumnWidth(2, 290,true);
            table.SetColumnWidth(1, 80);
            table.SetColumnWidth(0, 80);
            //add the table to the file
            doc.InsertTable(table);
        }

        private void addDataToTable(Table table,int row,List<Tuple<string, string, string>> selectedWorkList)
        {
            int counter = 0;
            Paragraph curText;
            string data = "";

            for (int i = 0; i < row-1; i++)
            {
                counter += 3;
                for (int j = 0; j < 3; j++)
                {
                    //If the text is price or a unit center the text
                    if (j == 1 || j == 0)
                    {
                        curText = table.Paragraphs[counter+j];
                        curText.Alignment = Alignment.center;
                    }
                    //If the text is work description align the text the right
                    else
                    {
                        curText = table.Paragraphs[counter+j];
                        curText.Alignment = Alignment.right;
                    }
                    //Add the price to the table
                    if (j == 0)
                        data = "₪" + selectedWorkList[i].Item3.ToString();
                    //Add the unit to the table
                    else if (j == 1)
                        data = selectedWorkList[i].Item2.ToString();
                    //Add the work description to the table
                    else if (j == 2)
                        data = selectedWorkList[i].Item1;
                    table.Rows[i+1].Cells[j].Paragraphs.First().Append(data).FontSize(12).Bold(true);
                }
            }
        }
        
        private void addDateAndCompanyName(DocX doc)
        {
            //Create the table  
            Table table = doc.AddTable(1, 2);
            table.Alignment = Alignment.center;
            Border b = new Border(BorderStyle.Tcbs_none,BorderSize.one,1,System.Drawing.Color.White);
            //Create the border of the table white not including the bottom border
            table.SetBorder(TableBorderType.Left, b);
            table.SetBorder(TableBorderType.Right, b);
            table.SetBorder(TableBorderType.Top, b);
            table.SetBorder(TableBorderType.InsideH, b);
            table.SetBorder(TableBorderType.InsideV, b);

            //Text design
            string date = DateTime.UtcNow.ToString("dd/MM/yyyy");

           //Add text 
            table.Rows[0].Cells[0].Paragraphs.First().Append(date).FontSize(14).Bold(true);
            //Add the company name
            if (Settings.Default["showCompanyName"].Equals(true))
                table.Rows[0].Cells[1].Paragraphs.First().Append(Settings.Default["companyName"].ToString()).FontSize(14).Bold(true);

            //Change the side of the text
            Paragraph curText = table.Paragraphs[0];
            curText.Alignment = Alignment.left;
            curText = table.Paragraphs[1];
            curText.Alignment = Alignment.right;
            table.SetColumnWidth(0, 100);
            table.SetColumnWidth(1, 360);
            //Add the table to the document
            doc.InsertTable(table);

            //Create a spece between the table and the next paragraph
            Paragraph titlePar = doc.InsertParagraph("\n\n");
            titlePar.Alignment = Alignment.center;

        }
    
        private void firstDesign(string title, DocX doc)
        {
            createFirstDesignTitle("הצעת מחיר לעבודת שיפוץ" + ": " + title, doc);
            addDateAndCompanyName(doc);
        }
    
        private void secondDesign(string title, DocX doc)
        {
            createSecondDesignTitle(title, doc);
        }
    }
}
