open ResultFSharp

let example1() = 

    let sevenMillionYearsPassed = false

    let ``The Ultimate Question of Life, the Universe, and Everything``() = 
        if sevenMillionYearsPassed
        then Ok 42
        else Fail "calculating..."
    
    let answer = ``The Ultimate Question of Life, the Universe, and Everything``()

    match answer with
    | Ok x -> printfn "The answer is %d" x
    | Fail message -> printfn "%s" message

let example2() = 

    let readData() = Ok 5
    let writeData x = Result.from(fun() -> printfn "%d" x)

    let r = readData() 
            |> Result.map (fun i -> i + 2) 
            |> Result.bind writeData
    
    printfn "%A" r

let example3() = 

    let readFromDb x = 
        if x < 8
        then Ok (x + 2)
        else Fail (sprintf "Value %d is not available" x)

    let calculate() = result {
        let x = 3
        let! y = readFromDb x
        let! z = readFromDb (x + y)
        return x + y + z
    }

    let result = calculate()

    match result with
    | Ok x -> printfn "%d" x
    | Fail e -> printfn "Error: %s" e

[<EntryPoint>]
let main argv =
    
    //example1()
    //example2()
    //example3()
    
    0
