open System

type Customer = { Name: string; Town: string }

[<EntryPoint>]
let main _argv =
    let numbers = [ 1 .. 10 ]
    let timesTwo n = n * 2

    numbers
    |> List.map timesTwo
    |> List.iter (fun i -> printfn "%d" i)

    let total = numbers |> List.sum
    let max = numbers |> List.max
    let min = numbers |> List.min
    printfn "%d, %d, %d" total max min

    [ DateTime(2010, 5, 1)
      DateTime(2010, 6, 1)
      DateTime(2010, 6, 12)
      DateTime(2010, 7, 3) ]
    |> List.pairwise
    |> List.map (fun (a, b) -> b - a)
    |> List.map (fun time -> time.TotalDays)
    |> List.iter (fun i -> printfn "%.2f" i)

    let customers =
        [ { Name = "Isaac"; Town = "London" }
          { Name = "Sara"; Town = "Brimingham" }
          { Name = "Tim"; Town = "London" }
          { Name = "Michelle"
            Town = "Manchester" } ]

    let groups =
        customers |> List.groupBy (fun c -> c.Town)

    printfn "%A" groups

    let counts =
        customers |> List.countBy (fun c -> c.Town)

    printfn "%A" counts

    let londonCustomers, otherCustomers =
        customers
        |> List.partition (fun c -> c.Town = "London")

    printfn "LondonCustomers: %A" londonCustomers
    printfn "OtherCustomers: %A" otherCustomers

    0 // return an integer exit code
