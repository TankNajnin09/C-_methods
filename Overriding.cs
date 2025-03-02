using System;

class Perent
{
	public void fun(int a)
	{
		Console.WriteLine("Method 1 called... ");
	}	
}

class Child : Perent
{
	public void fun(double a)
	{
		Console.WriteLine("Method 2 called... ");
	}
}

class Overriding
{
		public static void Main()
		{
			Child c1 = new Child();
			c1.fun(10);
		}
}