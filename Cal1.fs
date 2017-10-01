open System

let Add (numbers : String) :int = 
   match numbers with 
    | " " -> 0
    | _ when numbers.Contains "," -> 
       let n = numbers.Split [|','|]
       (Int32.Parse n.[0]) + (Int32.Parse n.[1])
    | _ -> Int32.Parse numbers

    



