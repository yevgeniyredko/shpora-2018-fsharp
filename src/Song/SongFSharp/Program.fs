open Song

[<EntryPoint>]
let main argv =
    
    let song1 = { Author="Queen"; Name="Bohemian Rhapsody" }
    printfn "%A" song1 // %A is pretty print

    let song2 = { Author="Queen"; Name="Bohemian Rhapsody" }
    printfn "%b" (song1=song2) // true

    let song3 = { song2 with Name="We Are the Champions" }
    printfn "%A" song3 // { Author="Queen"; Name="We Are the Champions" }

    let { Name=name } = song3 // name = song3.Name
    printfn "%s" name // "We Are the Champions"

    0 
