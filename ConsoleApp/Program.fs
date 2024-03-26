// For more information see https://aka.ms/fsharp-console-apps
open System
open ClassLibrary

printfn "Zoltar says ''Make your wish!''"
let yourWish = System.Console.ReadLine()

printfn $"{DeepThinker.TheAnswer}";

