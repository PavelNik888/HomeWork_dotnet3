﻿
System.Console.WriteLine("Ввод координат точки 1");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());

int [] array1 = new int[] {x1,y1,z1};

System.Console.WriteLine("Ввод координат точки 2");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

int [] array2 = new int[] {x2,y2,z2};



double result = Math.Sqrt(Math.Pow (array1[0] - array2[0],2) + Math.Pow (array1[1] - array2[1],2) + Math.Pow (array1[2] - array2[2],2));

System.Console.WriteLine($"Result is {result}");
