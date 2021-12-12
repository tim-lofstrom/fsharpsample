open CustomLibrary

type Tester (a : string) =
    let b = "asd"

[<EntryPoint>]
let main argv =
    Say.hello("Tim")
    let v1 = CustomLibrary.Vector2D(1,2)
    let c = Tester("HEJ")
    printfn "%A" Say.inSquareTester
    printfn "%s" <| Say.convertToJson "Hello"
    0