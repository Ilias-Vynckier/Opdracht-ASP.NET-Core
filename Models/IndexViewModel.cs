using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Opdracht_ASP.NET_Core.Models
{
    public class IndexViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);


        public List dink = new List();
        public List dinkArray;

        public void OnPost()
        {
            dinkArray.Append();
        }

    }
}