Console.WriteLine("Введите число ");
             string text= Console.ReadLine();
            int n = Convert.ToInt32(text);
            int i=0;
             for(i=0;i <= n;i++)
                {
                  
             Console.Write("{0}", i++);
         }
            Console.ReadKey();