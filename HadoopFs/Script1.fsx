
open System

let testString = "hello hello there"

//id is a FSharp operator ->
//it is the same as writing 
//Seq.countBy(fun s -> s)

let result = testString.Split([| ' ' |], StringSplitOptions.RemoveEmptyEntries) |> Seq.countBy id
result


//Tightrope SRV

open System.IO

[<Literal>]
let path = "../Data/Build_Keynote2014.txt"

let buildKeynote =  File.ReadAllText(path)
