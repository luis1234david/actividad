Console.WriteLine("Dame la hora");
		int hora=Convert.ToInt32(Console.ReadLine());
		if
			(hora<=24)
				Console.WriteLine("La hora es "+hora);
			
			else
			{
				Console.WriteLine("No es posible favor de darme otra hora");
			}
		
		Console.WriteLine ("Los minutos");
		int minutos=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Los segundos");
		int segundos=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Su hora es "+ hora  + minutos + segundos);