﻿// See https://aka.ms/new-console-template for more information
int a = 1, b = 2, c = 6, d = 8, e = 4, max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);
