int m = 5;
int n = 8;
int CalculateSumm(int m, int n)
	{
		int start = m;
		int end = n;
		if(m > n)
		{
			start = n;
			end = m;
		}
		return (end + start)*(end - start + 1)/2;
	}
		
	Console.WriteLine(CalculateSumm(72, 16));
	
