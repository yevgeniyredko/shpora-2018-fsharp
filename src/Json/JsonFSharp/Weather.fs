module JsonFSharp

open FSharp.Data

type Weather = JsonProvider<"../weather.json">
