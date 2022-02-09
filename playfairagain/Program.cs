using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace playfairagain
{
    class Program
    {
        class PlayFairKodolo
        {
            public List<string> lista { get; private set; }
            public PlayFairKodolo(string asd)
            {
                lista = new List<string>();
                foreach (var item in File.ReadAllLines(asd))
                {
                    lista.Add(item);
                }
            }
            public int SorIndex(char karakter)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    for (int j = 0; j < lista[i].Length; j++)
                    {
                        if (lista[i][j]==karakter)
                        {
                            return i;
                        }
                    }
                }
                return -1;
            }
            public int OszlopIndex(char karakter)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    for (int j = 0; j < lista[i].Length; j++)
                    {
                        if (lista[i][j]==karakter)
                        {
                            return j;
                        }
                    }
                }
                return -1;
            }
            public string KodolBetupar(string ketbetu)
            {
                char elsokarakter = ketbetu[0];
                char masodikkarakter = ketbetu[1];
                if (SorIndex(elsokarakter) == SorIndex(masodikkarakter))
                {
                    
                    if (OszlopIndex(elsokarakter) == 4 || OszlopIndex(masodikkarakter) == 4)
                    {
                        if (OszlopIndex(elsokarakter)==4)
                        {
                            
                            
                            return lista[SorIndex(elsokarakter)][0].ToString() + lista[SorIndex(masodikkarakter)][OszlopIndex(masodikkarakter) + 1].ToString();
                        }
                        else
                        {
                            return lista[SorIndex(elsokarakter)][OszlopIndex(elsokarakter) + 1].ToString() + lista[SorIndex(masodikkarakter)][0].ToString();
                        }
                    }
                    return lista[SorIndex(elsokarakter)][OszlopIndex(elsokarakter) + 1].ToString() + lista[SorIndex(masodikkarakter)][OszlopIndex(masodikkarakter) + 1].ToString();
                }
                else if (OszlopIndex(elsokarakter) == OszlopIndex(masodikkarakter))
                {

                    if (SorIndex(elsokarakter) == 4 || SorIndex(masodikkarakter) == 4)
                    {
                        if (SorIndex(elsokarakter) == 4)
                        {

                            return lista[SorIndex(elsokarakter)][0].ToString() + lista[SorIndex(masodikkarakter)+1][OszlopIndex(masodikkarakter)].ToString();
                        }
                        else
                        {
                            return lista[SorIndex(elsokarakter)+1][OszlopIndex(elsokarakter)].ToString() + lista[SorIndex(masodikkarakter)][0].ToString();
                        }
                    }
                    return lista[SorIndex(elsokarakter)+1][OszlopIndex(elsokarakter)].ToString() + lista[SorIndex(masodikkarakter)+1][OszlopIndex(masodikkarakter)].ToString();
                }
                else
                {
                    return lista[SorIndex(elsokarakter)][OszlopIndex(masodikkarakter)].ToString() + lista[SorIndex(masodikkarakter)][OszlopIndex(elsokarakter)].ToString();
                }
            }
        }
        static void Main(string[] args)
        {
            PlayFairKodolo asd = new PlayFairKodolo("kulcstabla.txt");
            Console.WriteLine("Írjon be egy karaktert");
            string karakter = Console.ReadLine();
            Console.WriteLine($"A sor indexe:{asd.SorIndex(Convert.ToChar(karakter))}");
            Console.WriteLine($"Az oszlop indexe:{asd.OszlopIndex(Convert.ToChar(karakter))}");
            string ketbetu = Console.ReadLine();
            Console.WriteLine($"{asd.KodolBetupar(ketbetu)}");
            Console.ReadKey();
        }
    }
}
