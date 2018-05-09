module ResultFSharp

type Result<'a> =  
    | Ok of 'a 
    | Fail of string

module Result =
    let from f = try Ok (f()) with e -> Fail e.Message
    let bind f result = match result with Fail s -> Fail s | Ok a -> f a
    let map f result = result |> bind (fun a -> from (fun() -> f a))

type ResultBuilder() =
    member __.Bind(result, binder) = result |> Result.bind binder
    member __.Return(value) = Ok value

let result = ResultBuilder()
