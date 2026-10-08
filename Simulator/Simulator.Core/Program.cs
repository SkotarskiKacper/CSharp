using Simulator.Core;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Konstruktor z dwoma argumentami.
Creature shrek = new("Shrek", 7);
shrek.SayHi();

// Drugi argument ma wartość domyślną.
Creature donkey = new("Donkey");
donkey.SayHi();

// Konstruktor bezparametrowy – obiekt powstaje bez żadnych danych.
Creature nobody = new();
nobody.SayHi();

// Pola są publiczne, więc każdy może zrobić z obiektem, co zechce.
shrek.Name = "Fiona";
shrek.Level = -300;
shrek.SayHi();