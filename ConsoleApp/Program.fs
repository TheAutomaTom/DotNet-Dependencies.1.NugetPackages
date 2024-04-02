open System
open ClassLibrary

printfn "Question: What is six times seven?"

let a: string = QuestionResolver.Answer

printfn $"Answer: {a}";

ignore (Console.ReadKey());
