open System

  let Add (numbers : String)=
  
  let sumArr = Array.fold (fun acc elem -> acc + (int elem))  0
  
  match numbers with
    | "" -> 0
    | _ when numbers.Length=1 -> Int32.Parse numbers
    | _ ->        
        numbers.Split [|',' ; '\n'|] |> sumArr


Add " 1\n2,3\n4"

