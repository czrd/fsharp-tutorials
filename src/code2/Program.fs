let drive distance petrol =
    let d =
        match distance with
        | "far" -> 50.
        | "medium" -> 25.
        | "short" -> 10.
        | _ -> 1.

    petrol - d

let add n x = x + n
let times n x = x * n
let add1Times2 = add 1 >> times 2
let add5Times3 = add 5 >> times 3

let driveShortAndPrint =
    drive "short" >> fun p -> printfn "%.2f" p

[<EntryPoint>]
let main _ =
    let startPetrol = 100.0

    let remains =
        startPetrol
        |> drive "far"
        |> drive "medium"
        |> drive "short"
        |> drive "somewhere"

    printfn "%.2f" remains

    driveShortAndPrint 100.
    0 // return an integer exit code
