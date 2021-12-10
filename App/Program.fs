open CustomLibrary

[<EntryPoint>]
let main argv =
    Say.hello("Tim")
    printfn "%A" Say.inSquareTester
    printfn "%s" <| Say.convertToJson "Hello"
    0