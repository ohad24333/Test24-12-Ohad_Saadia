             Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 8; i++)
            {
                int j = 0;
                for( j=0;j<i;j++)
                {
                    Console.Write(j + 1);
                }
                for(j=j;j<num;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
