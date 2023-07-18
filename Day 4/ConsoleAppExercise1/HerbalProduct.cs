using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppExercise1
{
    internal class HerbalProduct:Product
    {
        string herbsUsed;
        DateTime mfDate;
        DateTime expDate;

        public HerbalProduct(int id, string name, double price, string herbsUsed, DateTime mfDate, DateTime expDate) : base(id, name, price)
        {
            this.herbsUsed = herbsUsed;
            this.mfDate = mfDate;   
            this.expDate = expDate;
        }


        public void SetInfo(int id, string name, double price, string herbsUsed, DateTime mfDate, DateTime expDate)
        {
            base.SetInfo(id , name, price);
            this.herbsUsed = herbsUsed;
            this.mfDate = mfDate;
            this.expDate = expDate;

        }


        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Herbs Used: {herbsUsed}\t mDate : {mfDate}\t ExpDate :{expDate}");
        }

    
    }
}
