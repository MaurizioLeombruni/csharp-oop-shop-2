using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPShop2
{
    public class BottledWater : Product
    {
        private float liters;
        private int ph;
        private string waterSpring;


        private float maxCapacity;
        private bool isCarbonated;
        public BottledWater(string name, string description, float basePrice, float liters, int ph, string waterSpring, bool isCarbonated) : base(name, description, basePrice)
        {
            this.liters = liters;
            this.ph = ph;
            this.waterSpring = waterSpring;
            this.isCarbonated = isCarbonated;

            this.maxCapacity = 1.5f;
        }

        //bevi riempi svuota stampaprodotto

        public float GetLiters()
        {
            return liters;
        }

        public int GetPH()
        {
            return ph;
        }

        public string GetSpring()
        {
            return waterSpring;
        }

        public string GetCarbonated()
        {
            string resultString;

            if (this.isCarbonated)
            {
                resultString = "Yes";
            }
            else
            {
                resultString = "No";
            }

            return resultString;
        }

        public void Drink(float litersToDrink)
        {
            if (liters == 0)
            {
                Console.WriteLine("This bottle's empty!");
            } else
            {
                liters = Math.Max(0, (liters - litersToDrink));
            }
        }

        public void Refill(float litersToRefill)
        {
            if((liters + litersToRefill) >= maxCapacity)
            {
                Console.WriteLine("This bottle's been completely refilled.");
                liters = maxCapacity;
            }
            else
            {
                Console.WriteLine("The bottle has been refilled somewhat.");
                liters += litersToRefill;
            }
        }

        public void Empty()
        {
            Console.WriteLine("Because we really like wasting products, I guess.");
            liters = 0;
        }

        //So che non si dice "deflate" (non è una palla da sgonfiare) ma non so il termine in inglese lel
        public void Deflate()
        {
            if (isCarbonated)
            {
                Console.WriteLine("Not-exactly-natural water has been obtained!");
                isCarbonated = false;
            } else
            {
                Console.WriteLine("The water isn't carbonated to begin with.");
            }
        }

        public override void PrintProductDetails()
        {
            Console.WriteLine("-------DETTAGLI-------");
            Console.WriteLine("Nome prodotto: " + GetProductName());
            Console.WriteLine("Codice prodotto: " + GetProductCode());
            Console.WriteLine("Nome esteso: " + GetExtendedName());
            Console.WriteLine("Codice prodotto compilato: " + GetPaddedCode());
            Console.WriteLine("Descrizione prodotto: " + GetProductDescription());

            Console.WriteLine("Litri in bottiglia: " + GetLiters() + "l");
            Console.WriteLine("pH dell'acqua: " + GetPH());
            Console.WriteLine("Sorgente di provenienza: " + GetSpring());
            Console.WriteLine("Frizzante: " + GetCarbonated());
            PrintBasePrice();
            PrintPriceTotal();
            Console.WriteLine("-----------------------");
        }
    }
}
