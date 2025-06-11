using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSolucao.PDF;
public class GeradorPDF
{
    public string pageOrientation { get; set; }
    public string unit { get; set; }
    public int pageSizeX { get; set; }
    public int pageSizeY { get; set; }
    public int marginTop { get; set; }
    public int marginRight { get; set; }
    public int marginBottom { get; set; }
    public int marginLeft { get; set; }
    public bool hasHeader { get; set; }
    public int headerHeight { get; set; }
    public bool hasFooter { get; set; }
    public int footerHeight { get; set; }
    public string pageColor { get; set; }
    public string encode { get; set; }

    public override string ToString()
    {
        return $"PageOrientation = {pageOrientation}\n" +
               $"Unit = {unit}\n" +
               $"PageSizeX = {pageSizeX}\n" +
               $"PageSizeY = {pageSizeY}\n" +
               $"MarginTop = {marginTop}\n" +
               $"MarginRight = {marginRight}\n" +
               $"MarginBottom = {marginBottom}\n" +
               $"MarginLeft = {marginLeft}\n" +
               $"HasHeader = {hasHeader}\n" +
               $"HeaderHeight = {headerHeight}\n" +
               $"HasFooter = {hasFooter}\n" +
               $"FooterHeight = {footerHeight}\n" +
               $"PageColor = {pageColor}\n" +
               $"Encode = {encode}";
    }
}
