open ResultFSharp

let example1() = 

    let value = Ok 5

    match value with
    | Ok x -> printfn "%d" x

let example2() = 

    ()

let example3() = 

    ()

[<EntryPoint>]
let main argv =
    
    example1()
    example2()
    example3()
    
    0
