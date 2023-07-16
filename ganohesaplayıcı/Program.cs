using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// mg
namespace ganohesaplayıcı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -- GANO HESAPLAYICI !!!--
            
            Console.Write("Ders sayisini girin: ");
            int derssayisi = Convert.ToInt32(Console.ReadLine());
            string[] dersler=new string[derssayisi];
            int[] kredi=new int[derssayisi];
            int i = 0,kreditoplam=0;
            for(i=0; i<derssayisi; i++)         // dersleri ve kredilerini aldık
            {
                Console.Write("\n{0}.Dersin Adini Girin: ",i+1);
                dersler[i] = Console.ReadLine();
                Console.Write("{0} dersinin kredisini girin: ", dersler[i]);
                kredi[i]=Convert.ToInt32(Console.ReadLine()) ;
                kreditoplam += kredi[i];
            }
            int[] vize=new int[derssayisi];
            int[] final=new int[derssayisi];
            double[] dersort=new double[derssayisi];
            double[] harfnotu = new double[derssayisi];
            double gano = 0, toplam = 0;
            for (i = 0; i < derssayisi; i++)        // her dersin harf notunu ayrı ayrı hesapladık
            {
                Console.Write("\n{0} dersinin vize notunu girin: ", dersler[i]);
                vize[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0} dersinin final notunu girin: ", dersler[i]);
                final[i] = Convert.ToInt32(Console.ReadLine());
                dersort[i] = (double)(vize[i] * (0.4)) + (double)(final[i] * (0.6));
                if (dersort[i] >= 85)
                    harfnotu[i] = 4.00;
                else if (dersort[i] >= 75 && dersort[i] < 85)
                    harfnotu[i] = 3.50;
                else if (dersort[i] >= 65 && dersort[i] < 75)
                    harfnotu[i] = 3.00;
                else if (dersort[i] >= 57 && dersort[i] < 65)
                    harfnotu[i] = 2.50;
                else if (dersort[i] >= 50 && dersort[i] < 57)
                    harfnotu[i] = 2.00;
                else if (dersort[i] >= 40 && dersort[i] < 50)
                    harfnotu[i] = 1.50;
                else if (dersort[i] >= 0 && dersort[i] < 40)
                    harfnotu[i] = 0.50;
            }
            for (i = 0; i < derssayisi; i++)           
                toplam += (harfnotu[i] * kredi[i]);
            gano = toplam / kreditoplam;
            Console.Write("\n\n     Ganonuz: {0}", gano);
 
            Console.ReadKey();
        }
    }
}
