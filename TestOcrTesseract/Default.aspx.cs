using OCR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestOcrTesseract
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            TesseractService service = new TesseractService(@"C:\Program Files\Tesseract-OCR", "tha", @"C:\Program Files\Tesseract-OCR\tessdata");

            // var stream = File.OpenRead(string path);
            // var stream = WebRequest.Create(string url).GetResponse().GetResponseStream();
            // var stream = new MemoryStream(byte[] buffer);
            //var text = service.GetText(stream);

            lblResult.Text = service.GetText(fu.PostedFile.InputStream);
        }
    }
}