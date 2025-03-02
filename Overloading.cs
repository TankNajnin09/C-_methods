using System;

class Person
{
	/*public void abc(int a,int b)
	{
		Console.WriteLine("Method 1 called... " + a);
		Console.WriteLine("Method 1 called... " + b);
	}
	
	public void abc(int a,int b,char c)
	{
		Console.WriteLine("Method 2 called... " + a);
		Console.WriteLine("Method 2 called... " + b);
		Console.WriteLine("Method 2 called... " + c);
	}*/
	
	public void fun(int a)
	{
		Console.WriteLine("Method int called... " + a);
	}
	
	public void fun(float b)
	{
		Console.WriteLine("Method float called... " + b);
	}
	
}

class Overloading
{
		public static void Main()
		{
			Person p1 = new Person();
			
			//p1.abc(10,'n','s');
			//p1.abc(43,65);
			
			p1.fun(10);
			p1.fun(20.34);
		}
}