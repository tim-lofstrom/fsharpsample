module CustomLibrary.Tests

open NUnit.Framework

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    CustomLibrary.Say.hello("Tim")
    Assert.Pass()



[<Test>]
let Test2 () =
    CustomLibrary.Say.hello("Tim")
    Assert.Pass()
