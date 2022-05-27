using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP.Models
{
    internal class PDF : PdfPageEventHelper
    {

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            base.OnOpenDocument(writer, document);
            PdfPTable tabFot = new PdfPTable(new float[] { 1F });
            Font Segoe = FontFactory.GetFont("Segoe UI", 10, BaseColor.BLACK);
            tabFot.SpacingAfter = 10F;
            PdfPCell cell;
            tabFot.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            cell = new PdfPCell(new Phrase(DateTime.Now.ToString("dd/MM/yyyy"), Segoe));
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            cell.Border = 0;
            tabFot.AddCell(cell);
            tabFot.WriteSelectedRows(0, -1, document.RightMargin, writer.PageSize.GetTop(document.TopMargin), writer.DirectContent);
        }

        //Write on start of each page
        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);
        }

        //Write on end of each page
        public override void OnEndPage(PdfWriter writer, Document document)
        {

            base.OnEndPage(writer, document);
            Font Segoe = FontFactory.GetFont("Segoe UI", 8, BaseColor.BLACK);
            PdfPTable tabFot = new PdfPTable(new float[] { 1F });
            tabFot.SpacingAfter = 10F;
            PdfPCell cell;
            tabFot.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            cell = new PdfPCell(new Phrase("Preço total: " + ViewClient.ProductFilters.PrecoTotal.ToString() + "€", Segoe));
            cell.Border = 0;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            tabFot.AddCell(cell);
            tabFot.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin) - 5, writer.DirectContent);
        }

        //Write on close of document
        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
        }




    }
}
