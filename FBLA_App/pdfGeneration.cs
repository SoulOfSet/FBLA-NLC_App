using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace FBLA_App
{
    public partial class pdfGeneration
    {
        public void generatePDF(string fullName, string districtNum, string conferenceAttnd, string type, string id)
        {
            //We need to get the workshops the participant has registered for
            var dataInstance = new DataFileLoad();
            dataInstance.loadFiles();
            List<string> wkshpIDs = new List<string>();
            List<string> wkshps = new List<string>();
            //Generate file name from the name of the participant and their district num
            string fileName = fullName + "_" + districtNum + ".pdf";
            //Create the filestream
            FileStream pdfFile = new FileStream(@"SCHEDULES\" + fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            //Document rect
            Rectangle recSchedule = new Rectangle(PageSize.A4);
            //Rect background color
            recSchedule.BackgroundColor = new BaseColor(System.Drawing.Color.WhiteSmoke);
            //Create a doc to write to and pass our rect
            Document docSchedule = new Document(recSchedule);
            //Create a pdf writer
            PdfWriter pdfWriter = PdfWriter.GetInstance(docSchedule, pdfFile);
            //Open our document
            docSchedule.Open();
            //Heading Paragraph
            Paragraph header = new Paragraph("FBLA Conference Schedule\n");
                header.Font.Size = 22;
                header.Font.SetFamily("Courier");
            //Name Paragraph
            Paragraph partInfo = new Paragraph(fullName + "\n" + type + "\n" + "District " + districtNum + "\n" + conferenceAttnd + "\n\n");
                partInfo.Font.Size = 11;
                partInfo.Font.SetFamily("Courier");
                partInfo.Alignment = Element.ALIGN_RIGHT;
            //Conference info paragraphs
            Paragraph confInfoHead = new Paragraph("Events\n__________\n\n");
                confInfoHead.Font.Size = 18;
                confInfoHead.Font.SetFamily("Courier");
                confInfoHead.Alignment = Element.ALIGN_LEFT;
                Paragraph confDayHeader = new Paragraph("Monday\n");
                confDayHeader.Font.Size = 14;
                confDayHeader.Font.SetFamily("Courier");
                confDayHeader.Alignment = Element.ALIGN_LEFT;
            Paragraph confDayHeader2 = new Paragraph("Tuesday\n");
                confDayHeader2.Font.Size = 16;
                confDayHeader2.Font.SetFamily("Courier");
                confDayHeader2.Alignment = Element.ALIGN_LEFT;
            Paragraph confBodyMon = new Paragraph("Opening Ceremonies - 12:30 PM to 1:30 PM\nOpen Events - 2:30 PM to 4:00 PM\nKeynote Speaker - 7:00 PM to 9:00 PM\n");
                confBodyMon.Font.Size = 11;
                confBodyMon.Font.SetFamily("Courier");
                confBodyMon.Alignment = Element.ALIGN_LEFT;
            Paragraph confBodyTues = new Paragraph("Keynote Speaker - 1:00 PM to 2:30 PM\nAwards - 3:30 PM to 4:30 PM\nClosing Ceremonies - 4:45 PM to 6:30 PM\n");
                confBodyTues.Font.Size = 11;
                confBodyTues.Font.SetFamily("Courier");
                confBodyTues.Alignment = Element.ALIGN_LEFT;
            Paragraph confWorkshopHead = new Paragraph("\nWorkshops\n__________\n\n");
                confWorkshopHead.Font.Size = 18;
                confWorkshopHead.Font.SetFamily("Courier");
                confWorkshopHead.Alignment = Element.ALIGN_LEFT;
            //Add our paragraphs to the doc
            docSchedule.Add(header);
            docSchedule.Add(partInfo);
            docSchedule.Add(confInfoHead);
            docSchedule.Add(confDayHeader);
            docSchedule.Add(confBodyMon);
            docSchedule.Add(confDayHeader2);
            docSchedule.Add(confBodyTues);
            docSchedule.Add(confWorkshopHead);
            //Workshop Paragraphs
            //Get workshops ids the individual is registered for
            foreach (string[] e in dataInstance.aWkshpJag)
            {
                if (e[0].ToString() == id)
                {
                    wkshpIDs.Add(e[1].ToString());
                }
            }
            //Add the workshops to the document
            foreach (string[] ex in dataInstance.aWorkJag)
            {
                foreach (string exi in wkshpIDs)
                {
                    if (exi == ex[0].ToString())
                    {
                        string confName = ex[2];
                        string confDesc = ex[3];
                        string confDate = ex[4];
                        string confTime = ex[5];
                        Paragraph confPara1 = new Paragraph(confName + " - " + confDate + " starting at " + confTime + "\n");
                        Paragraph confPara2 = new Paragraph("\t" + confDesc + "\n\n");
                        confPara1.Font.Size = 14;
                        confPara1.Font.SetFamily("Courier");
                        confPara1.Alignment = Element.ALIGN_LEFT;
                        confPara2.Font.Size = 11;
                        confPara2.Font.SetFamily("Courier");
                        confPara2.Alignment = Element.ALIGN_LEFT;
                        docSchedule.Add(confPara1);
                        docSchedule.Add(confPara2);
                    }
                }
            }
            //Close our document
            docSchedule.Close();

        }
    }
}
