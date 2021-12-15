using System;
using System.Text;
using System.Collections;
namespace AdvancedConcepts
{
    class HashTable
    {
        public void InsertingElemets()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "ameeja");
            ht.Add("2", "reshu");
            ht.Add("3", "rehan");
            ht.Add("4", "raju");
            ht.Add("5", "alekya");
            ht.Add("6", "jaan");
            ICollection c = ht.Keys;
            Console.WriteLine("counting the elements:"+ht.Count);
            foreach(string str in c)
            {
                Console.WriteLine("inserting the elements:\t "+str+" "+ht[str]);
            }
            //remove one elements
            //ht.Remove("2");
            //Console.WriteLine("remove element:"+ht.Count);
            int count = ht.Count;
            for (int i = 1; i < ht.Count; i++)
            {
                if (i < 6)
                {
                    string cha = Convert.ToString(i);
                    ht.Remove(cha);
                    Console.WriteLine("remove the elents:" + i);
                }
            }
            Console.WriteLine("" + ht.Count);
            foreach (string str in c)
            {
                Console.WriteLine(str+""+ht[str]);
            }
        }
        public void sortmethod()
        {
            Hashtable mt = new Hashtable();
            mt.Add("name", "Ameeja");
            mt.Add("state", "Ap");
            mt.Add("country", "India");
            mt.Add("mobile no", "7287047811");
            mt.Add("id", "12345");
            ArrayList al = new ArrayList(mt.Keys);
            al.Sort();
            Console.WriteLine("\n"+al.Count);
            for(int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]+" " + mt[al[i]].ToString());

            }
        }
    }
}
