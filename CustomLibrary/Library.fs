namespace CustomLibrary
open Newtonsoft.Json

module Say =

    let test = 
        printfn "Test"

    let hello name =
        printfn "Hello %s" name

    let convertToJson str =
        JsonConvert.SerializeObject str

    let add x y = x + y

    let square x = x * x

    let mutExample =
        let mutable x = 5
        x <- 6
        x

    let listExample =
        let listTest = [1;2;3]
        listTest

    let inc = add 1

    let mapExample =
        listExample |> List.map inc |> List.map square


    let incSquare = (List.map inc) >> (List.map square)

    let inSquareTester =
        incSquare listExample

    let compare a b =
        a > b
