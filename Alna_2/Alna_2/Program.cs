using System;
using System.Collections.Generic;

namespace Alna_2
{
    class Program
    {
        //Saku struktura
        public class Saka
        {
            public int id;
            public List<Saka> sakos;
        }

        //Naujos Sakos sukurymas
        static Saka NaujaSaka(int id)
        {
            Saka nSaka = new Saka();
            nSaka.id = id;
            nSaka.sakos = new List<Saka>();
            return nSaka;
        }

        //Sakos gylio paieska
        static int sakosGylis(Saka sg)
        {
            if (sg == null)
            {
                return 0;
            }

            int gylis = 0;
            foreach (Saka rek in sg.sakos)
            {
                gylis = sakosGylis(rek);
            }
            return gylis + 1;
        }


        public static void Main(String[] args)
        {
            //Medzio duomenys

            Saka saknis = NaujaSaka(1);
            (saknis.sakos).Add(NaujaSaka(2));
            (saknis.sakos).Add(NaujaSaka(3));
            (saknis.sakos[0].sakos).Add(NaujaSaka(4));
            (saknis.sakos[1].sakos).Add(NaujaSaka(5));
            (saknis.sakos[1].sakos).Add(NaujaSaka(6));
            (saknis.sakos[0].sakos[0].sakos).Add(NaujaSaka(7));
            (saknis.sakos[1].sakos[0].sakos).Add(NaujaSaka(8));
            (saknis.sakos[1].sakos[1].sakos).Add(NaujaSaka(9));
            (saknis.sakos[1].sakos[0].sakos[0].sakos).Add(NaujaSaka(10));
            (saknis.sakos[1].sakos[0].sakos[0].sakos).Add(NaujaSaka(11));
            (saknis.sakos[1].sakos[1].sakos[0].sakos).Add(NaujaSaka(12));
            (saknis.sakos[1].sakos[1].sakos[0].sakos).Add(NaujaSaka(13));
            (saknis.sakos[1].sakos[1].sakos[0].sakos).Add(NaujaSaka(14));
            (saknis.sakos[1].sakos[1].sakos[0].sakos[2].sakos).Add(NaujaSaka(14));



            Console.WriteLine($"Medzio gylis yra: {sakosGylis(saknis)}");
        }
    }    

 }
   
