using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;

namespace QRCodeGenerator
{

    class Program
    {
        static void Main(string[] args)
        {

            GeneratedBarcode Qrcode = IronBarCode.QRCodeWriter.CreateQrCode("https://www.facebook.com/wayne.mcpherson.7777");
            Qrcode.SaveAsPng("QrCode.png");
        }
    }
}