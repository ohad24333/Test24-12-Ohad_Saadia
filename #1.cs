int i = 0;
            int mone = 0;
            int num = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Enter A Numbre");
                num = Convert.ToInt32(Console.ReadLine());
                mone = 2;
                while (mone < num && num % mone != 0)
                {
                    mone++;
                }
                if (num == mone)
                {
                    Console.WriteLine();
                    Console.WriteLine(num + ": mispar esroni");
                    sum = sum + num;
                    i++;
                }
            }
            while (i < 3 && num == mone);
            if(i==3)
            {
                Console.WriteLine($"The sum of the 3 numbers is :{sum}");
            }
            else
            {
                Console.WriteLine("the number is not esroni");
            }
            Console.ReadLine();
