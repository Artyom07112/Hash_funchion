using System;
using System.Collections;


namespace HASH1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Pow(11,27)%55);
            MyClass myClass = new MyClass();
              Console.WriteLine(myClass.Hash(Console.ReadLine()));
         
        }
    }
    class MyClass
    {
        Random rand = new Random();
        public string alp = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string Hash(string slovo)
        {
            while (slovo.Length % 4 != 0)
            {
                slovo += " " ;
            }

            /*for (int i = 0; i < slovo.Length; i++)
            {
                if (slovo.Length % 4 == 0)
                {
                    break;
                }
                if (slovo.Length % 4 != 0)
                {
                    slovo += " ";
                }
            }*/
            char[] text = slovo.ToCharArray();

            /*int h1 = alp.IndexOf(text[0]),
                h2 = alp.IndexOf(text[1]),
                h3 = alp.IndexOf(text[2]),
                h4 = alp.IndexOf(text[3]);*/
            ArrayList list = new ArrayList();
            for ( int i = 4; i < text.Length; i += 4)
            {
                for (int j = 0; j < 4; j++)
                {
                    text[j] = alp[((alp.IndexOf(text[i]) * alp.IndexOf(text[j])) ^ alp.IndexOf(text[i])) % alp.IndexOf(text[i])];
                }

                /*h1 = ((alp.IndexOf(text[i]) * h1) % alp.Length) ^ alp.IndexOf(text[i]);
                h2 = ((alp.IndexOf(text[i + 1]) * h2) % alp.Length) ^ alp.IndexOf(text[i + 1]);
                h3 = ((alp.IndexOf(text[i + 2]) * h3) % alp.Length) ^ alp.IndexOf(text[i + 2]);
                h4 = ((alp.IndexOf(text[i + 3]) * h4) % alp.Length) ^ alp.IndexOf(text[i + 3]);*/

            }
            // Console.WriteLine(alp[h1 % alp.Length] + " " + alp[h2 % alp.Length] + " " + alp[h3 % alp.Length] + " " + alp[h4 % alp.Length]);
            //var hash = alp[h1 % alp.Length] + alp[h2 % alp.Length] + alp[h3 % alp.Length] + alp[h4 % alp.Length];
            string hs = "";
          /*  list.Add(alp[h1 % alp.Length]);
            list.Add(alp[h2 % alp.Length]);
            list.Add(alp[h3 % alp.Length]);
            list.Add(alp[h4 % alp.Length]);*/
            foreach (var s in text)
            {
                hs += s;
            }
            return hs;
        }
    }
}
