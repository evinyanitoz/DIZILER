namespace DIZILER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // interpolation < $ > işartei ile parametreye 0 vermek yerine 
            //direk değişkenin adını veriyoruz.

            //  Console.WriteLine($"AD {adana}"); // bu şekilde kullanılır interpolation.

            /*****DİZİLERRRRRRR********
             * 
             * TANIMLAMA: string [] dizi={1,2,,4,5,6}
             * TANIMLAMA 2: string [] dizi =new string[6]; kaç elamanlı oldugunu newin içine yazalım .
             * TANIMLAMA 3:  string [] dizi =new string[]{}; 
             * TANIMLAMA 4: List<string> dizi = new List<string>(); 
            
            */
      
            try
            {

                string[] dizi = new string[] { "1", "2", "3", "4", "5" };
                string[] dizi2 = new string[6];
                List<string> dizi3 = new List<string> { "HIZLI ÖFKELİ ","ARKA SOKAKLAR","MECNUN VE LEYLA "};    /*GENELDE BUNU KULLAN ESAS BUNU KULLANACAĞIZ*/

                dizi2[0] = "ALİ";
                dizi2[1] = "MEHMET";
                dizi2[2] = "DENİZ";
                dizi2[3] = "MERT";
                dizi2[4] = "BUSE";
                dizi2[5] = "CAN";
                

                Console.WriteLine("******İSİMLER************** ");


                foreach (string item in dizi2)
                {
                    Console.WriteLine(item);

                }
                Console.WriteLine("******SAYILAR************** ");

                foreach (string item1 in dizi)
                {
                    Console.WriteLine(item1);

                }
                Console.WriteLine("******DİZİLER************** ");


                foreach (string item2 in dizi3)
                {
                    Console.WriteLine(item2);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("DİZİYİ AŞTINIZ");

            }
        }

    }
}