open JsonFSharp

[<EntryPoint>]
let main argv =

    let sample = Weather.GetSample()

    sample.Query.Results.Channel.Item.Forecast
    |> Array.iter (fun f -> printfn "%A %d %d" f.Date f.Low f.High)

    0 
