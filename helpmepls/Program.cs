using System;
using System.IO;
namespace helpmepls
{
    class Program
    {


        static void Main(string[] args)
        {
            string err = "****";
            string path = @"C:\Users\andre\Downloads\spells (1).2da";
            double i = 1;
            using (FileStream fstream = File.OpenRead($"{path}"))
            {
                string[] spells = File.ReadAllLines(path);
                string[] good = File.ReadAllLines(path);
                foreach (string s in spells)
                {
                    
                    i++;
                    if (i == 56)
                    {
                        i = 0;
                        s.Split();
                    }
                }
                foreach (string s in good)
                {

                    i++;
                    if (i == 56)
                    {
                        i = 0;
                        s.Split();
                    }
                }
                
                
                Console.WriteLine("Lable:  ");              
                for (int g = 3; g < 839; g++)
                {
                    string dd;
                    dd = spells[g].Remove(0, 160);
                    dd = dd.Split()[0];

                    if (err != dd)
                    {
                       
                        
                        dd = spells[g].Remove(0, 6);
                        dd = dd.Split()[0];
                        Console.WriteLine(dd);
                    }
                }
                Console.WriteLine("======================================================");
                Console.WriteLine("======================================================");
               
                
                Console.WriteLine("ImpactScript:  ");               
                for (int g = 3; g < 839; g++)
                {
                    string dd;
                    dd = spells[g].Remove(0, 160);
                    dd = dd.Split()[0];

                    if (err != dd)
                    {


                        dd = spells[g].Remove(0, 117);
                        dd = dd.Split()[0];
                        Console.WriteLine(dd);
                    }
                }
                Console.WriteLine("======================================================");
                Console.WriteLine("======================================================");


                using (FileStream fstreamm = new FileStream(@"C:\Users\andre\Downloads\spells (2).2da", FileMode.OpenOrCreate))
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[k] + Environment.NewLine);
                        fstreamm.Write(array, 0, array.Length);
                        Console.WriteLine(spells[k]);
                    }
                    for (int g = 3; g < 838; g++)
                    {
                        string mm;
                        mm = "acid";
                        string dd;
                        dd = spells[g];
                        dd = spells[g].Remove(0, 517);

                        string label1 = dd.Split()[0];
                        if (label1 == mm)
                        {
                            byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[g] + Environment.NewLine);
                            fstreamm.Write(array, 0, array.Length);
                            Console.WriteLine(label1);
                        }
                    }
                }
                using (FileStream fstreamm = new FileStream(@"C:\Users\andre\Downloads\bard.2da", FileMode.OpenOrCreate))
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[k] + Environment.NewLine);
                        fstreamm.Write(array, 0, array.Length);
                        Console.WriteLine(spells[k]);
                    }
                    string bb = "****";
                    for (int g = 3; g < 839; g++)
                    {

                        string mm;
                        string dd;
                        dd = spells[g];
                        dd = spells[g].Remove(0, 136);

                        string label1 = dd.Split()[0];
                        if (bb != label1)
                        {
                            byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[g] + Environment.NewLine);
                            fstreamm.Write(array, 0, array.Length);
                            Console.WriteLine(label1);
                        }
                    }

                }
                using (FileStream fstreamm = new FileStream(@"C:\Users\andre\Downloads\druid.2da", FileMode.OpenOrCreate))
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[k] + Environment.NewLine);
                        fstreamm.Write(array, 0, array.Length);
                        Console.WriteLine(spells[k]);
                    }
                    string bb = "****";
                    for (int g = 3; g < 839; g++)
                    {

                        string mm;
                        string dd;
                        dd = spells[g];
                        dd = spells[g].Remove(0, 152);

                        string label1 = dd.Split()[0];
                        if (bb != label1)
                        {
                            byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[g] + Environment.NewLine);
                            fstreamm.Write(array, 0, array.Length);
                            Console.WriteLine(label1);
                        }
                    }
                }
                using (FileStream fstreamm = new FileStream(@"C:\Users\andre\Downloads\cleric.2da", FileMode.OpenOrCreate))
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[k] + Environment.NewLine);
                        fstreamm.Write(array, 0, array.Length);
                        Console.WriteLine(spells[k]);
                    }
                    string bb = "****";
                    for (int g = 3; g < 839; g++)
                    {

                        string mm;
                        string dd;
                        dd = spells[g];
                        dd = spells[g].Remove(0, 143);

                        string label1 = dd.Split()[0];
                        if (bb != label1)
                        {
                            byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[g] + Environment.NewLine);
                            fstreamm.Write(array, 0, array.Length);
                            Console.WriteLine(label1);
                        }
                    }
                }
                using (FileStream fstreamm = new FileStream(@"C:\Users\andre\Downloads\paladin.2da", FileMode.OpenOrCreate))
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[k] + Environment.NewLine);
                        fstreamm.Write(array, 0, array.Length);
                        Console.WriteLine(spells[k]);
                    }
                    string bb = "****";
                    for (int g = 3; g < 839; g++)
                    {

                        string mm;
                        string dd;
                        dd = spells[g];
                        dd = spells[g].Remove(0, 160);

                        string label1 = dd.Split()[0];
                        if (bb != label1)
                        {
                            byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[g] + Environment.NewLine);
                            fstreamm.Write(array, 0, array.Length);
                            Console.WriteLine(label1);
                        }
                    }

                }
                using (FileStream fstreamm = new FileStream(@"C:\Users\andre\Downloads\ranger.2da", FileMode.OpenOrCreate))
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[k] + Environment.NewLine);
                        fstreamm.Write(array, 0, array.Length);
                        Console.WriteLine(spells[k]);
                    }
                    string bb = "****";
                    for (int g = 3; g < 839; g++)
                    {

                        string mm;
                        string dd;
                        dd = spells[g];
                        dd = spells[g].Remove(0, 170);

                        string label1 = dd.Split()[0];
                        if (bb != label1)
                        {
                            byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[g] + Environment.NewLine);
                            fstreamm.Write(array, 0, array.Length);
                            Console.WriteLine(label1);
                        }
                    }

                }
                using (FileStream fstreamm = new FileStream(@"C:\Users\andre\Downloads\Wiz_Sorc.2da", FileMode.OpenOrCreate))
                {
                    for (int k = 0; k < 3; k++)
                    {
                        byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[k] + Environment.NewLine);
                        fstreamm.Write(array, 0, array.Length);
                        Console.WriteLine(spells[k]);
                    }
                    string bb = "****";
                    for (int g = 3; g < 839; g++)
                    {

                        string mm;
                        string dd;
                        dd = spells[g];
                        dd = spells[g].Remove(0, 179);

                        string label1 = dd.Split()[0];
                        if (bb != label1)
                        {
                            byte[] array = System.Text.UTF8Encoding.Default.GetBytes(spells[g] + Environment.NewLine);
                            fstreamm.Write(array, 0, array.Length);
                            Console.WriteLine(label1);
                        }
                    }

                }
                Console.ReadLine();
            }

        }
           
        
    }
}
