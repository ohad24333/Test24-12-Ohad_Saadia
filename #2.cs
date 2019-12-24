            Console.WriteLine("enter second total");
            long SecondTotal = Convert.ToInt64(Console.ReadLine());
            long min = 0;
            long hour = 0;
            long days = 0;
            if (SecondTotal >= 0)
            {
                min = SecondTotal / 60;
                SecondTotal = SecondTotal % 60;
                hour = min / 60;
                min = min % 60;
                days = hour / 24;
                hour = hour % 24;
                Console.WriteLine($"{days} Days, {hour} Hour, {min} minutes, {SecondTotal} seconds");

            }
            else
            {
                Console.WriteLine("error");

            }
            Console.ReadLine();
