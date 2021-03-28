type Address =
    { Street: string
      City: string
      Town: string }

type Customer =
    { FirstName: string
      LastName: string
      Address: Address
      Email: string }

[<EntryPoint>]
let main _ =
    let customer =
        { FirstName = "John"
          LastName = "Doe"
          Address =
              { Street = "street"
                City = "city"
                Town = "town" }
          Email = "john.doe@email.com" }

    printfn "customer: %s %s" customer.FirstName customer.LastName
    0 // return an integer exit code

