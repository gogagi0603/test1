﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ManualResetEventSlim EndEvent = new(false);
EndEvent.Wait();