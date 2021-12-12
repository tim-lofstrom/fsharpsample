namespace CustomLibrary

[<AbstractClass>]
type IVector () =
    abstract member Calculate : unit -> unit
    default __.Calculate() = ()

type Vector2D (x : int, y : int) =
    inherit IVector()

    member __.asString () =
        $"(%s{string x}, %s{string y})"