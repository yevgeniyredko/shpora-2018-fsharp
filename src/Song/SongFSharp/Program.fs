open Song

[<EntryPoint>]
let main argv =
    
    let song1 = { Author="Queen"; Name="Bohemian Rhapsody" }
    printfn "%A" song1

    let song2 = { Author="Queen"; Name="Bohemian Rhapsody" }
    printfn "%b" (song1=song2)

    let song3 = { song2 with Name="We Are the Champions" }
    printfn "%A" song3

    let { Name=name } = song3
    printfn "%s" name

    0 
