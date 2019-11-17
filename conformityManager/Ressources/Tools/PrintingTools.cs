using conformityManager.Ressources.Structures;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;
using OfficeOpenXml;
using System.IO;

namespace conformityManager.Ressources.Tools
{
    public class PrintingTools
    {

        public static String NewDocXFile(String FileFullName,NcFile ncFile, NcFileDetails ncFileDetails, NcFileFix ncFileFix)
        {            
            try
            {
                DocX templateDocument = DocX.Load(@"NcFileDetail.docx");
                foreach (Paragraph paragraph in templateDocument.Paragraphs)
                {
                    paragraph.ReplaceText("<Titre-NC>", ncFile.case_title);
                    paragraph.ReplaceText("<Createur>", ncFile.nc_user_full_Name);
                    paragraph.ReplaceText("<Structure>", ncFile.structure_name);
                    paragraph.ReplaceText("<Description>", ncFileDetails.description);
                    paragraph.ReplaceText("<N-plan>", ncFileDetails.n_plan);
                    paragraph.ReplaceText("<Ens-Partiel>", ncFileDetails.partial_set);
                    paragraph.ReplaceText("<Source>", ncFile.source? "interne" : "externe");
                    paragraph.ReplaceText("<Date-Creation>", ncFile.creation_date);
                    paragraph.ReplaceText("<Cause>", ncFileFix.cause);
                    paragraph.ReplaceText("<Description-Action>", ncFileFix.action_description);
                    paragraph.ReplaceText("<Type-Action>", ncFileFix.action_type==1? "correction" : "corrective");
                    paragraph.ReplaceText("<Responsable-Action>", ncFileFix.fixer_full_name);
                    paragraph.ReplaceText("<Fonction-Responsable-Action>", ncFileFix.fixer_function);
                    paragraph.ReplaceText("<Structure-Responsable-Action>", ncFileFix.fixer_structure_name);
                    paragraph.ReplaceText("<Temp-Planifie-Debut>", ncFileFix.estimated_start_date);
                    paragraph.ReplaceText("<Temp-Planifie-Fin>", ncFileFix.estimated_end_date);
                }
                templateDocument.SaveAs(FileFullName);
                return "ok";
            }
            catch(Exception e) { return e.Message; }
        }




        public static String NewExcelFile(String FileFullName,List<NcFile> ncFileList)
        {
            try
            {
                ExcelPackage ExcelPkg = new ExcelPackage();
                ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Page1"); // new page

                //int headerIndex = 1;
                int currentRow = 1;

                wsSheet1.Cells[currentRow, 1].Value = "Numero"; //headerIndex++;
                wsSheet1.Cells[currentRow, 2].Value = "Affaire"; //headerIndex++;
                wsSheet1.Cells[currentRow, 3].Value = "Auteur";
                wsSheet1.Cells[currentRow, 4].Value = "Structure";
                wsSheet1.Cells[currentRow, 5].Value = "Date de creation";
                wsSheet1.Cells[currentRow, 6].Value = "Debut delai planifie";
                wsSheet1.Cells[currentRow, 7].Value = "Fin delai planifie";
                wsSheet1.Cells[currentRow, 8].Value = "Etat";
                wsSheet1.Cells[currentRow, 9].Value = "Date de realisation";
                wsSheet1.Cells[currentRow, 10].Value = "Validation R SMI";


                // forLoop here
                foreach (NcFile ncFile in ncFileList)
                {
                    currentRow++;
                    wsSheet1.Cells[currentRow, 1].Value = ncFile.id; //headerIndex++;
                    wsSheet1.Cells[currentRow, 2].Value = ncFile.case_title;
                    wsSheet1.Cells[currentRow, 3].Value = ncFile.nc_user_full_Name;
                    wsSheet1.Cells[currentRow, 4].Value = ncFile.structure_name;
                    wsSheet1.Cells[currentRow, 5].Value = ncFile.creation_date;
                    wsSheet1.Cells[currentRow, 6].Value = ncFile.estimated_start_date;
                    wsSheet1.Cells[currentRow, 7].Value = ncFile.estimated_end_date;

                    wsSheet1.Cells[currentRow, 8].Value = ncFile.state == 0 ? "Non entamée" : ncFile.state == 1 ? "En cours" : "Réalisée";
                    wsSheet1.Cells[currentRow, 8].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    switch (ncFile.state)
                    {
                        case 0: wsSheet1.Cells[currentRow, 8].Style.Fill.BackgroundColor.SetColor(Color.IndianRed); break;
                        case 1: wsSheet1.Cells[currentRow, 8].Style.Fill.BackgroundColor.SetColor(Color.Orange); break;
                        case 2: wsSheet1.Cells[currentRow, 8].Style.Fill.BackgroundColor.SetColor(Color.LightGreen); break;
                    }

                    wsSheet1.Cells[currentRow, 9].Value = ncFile.fix_date;

                    wsSheet1.Cells[currentRow, 10].Value = ncFile.is_valid ? "Valide" : "Non-Valide";
                    wsSheet1.Cells[currentRow, 10].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    if (ncFile.is_valid)
                        wsSheet1.Cells[currentRow, 10].Style.Fill.BackgroundColor.SetColor(Color.LightGreen); 
                    else
                        wsSheet1.Cells[currentRow, 10].Style.Fill.BackgroundColor.SetColor(Color.IndianRed);
                    
                }

                // styling header
                string headerRange = "A1:Z1";
                wsSheet1.Cells[headerRange].Style.Font.Bold = true;
                wsSheet1.Cells[headerRange].Style.Font.Size = 14;
                // set header fill type + fill color
                wsSheet1.Cells[headerRange].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                wsSheet1.Cells[headerRange].Style.Fill.BackgroundColor.SetColor(Color.SlateGray);

                // set columns width : fit to content
                wsSheet1.Cells["A1:Z" + ncFileList.Count].AutoFitColumns();



                wsSheet1.Protection.IsProtected = false;
                wsSheet1.Protection.AllowSelectLockedCells = false;
                ExcelPkg.SaveAs(new FileInfo(FileFullName));



                return "ok";
            }
            catch (Exception e) { return e.Message; }
            
        }
    }


            
    
}
