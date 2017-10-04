
open System

type  CountNeg (negNums) =
   inherit Exception(sprintf "negatives anre not allowed %A" negNums)  

type SumNum(numbers : string) = 
   let rec Add2 delimiters numbers = 
       match numbers with
       | "" -> 0
       | _ when numbers.StartsWith "//" -> 
            numbers.Substring  ((numbers.IndexOf "\n") + 1 ) |> Add2 [|numbers.[2]|]

       | _ -> 
          let negNums, posNums = 
            [for i in numbers.Split delimiters -> Int32.Parse i] |> List.partition (fun i -> i <0)
          if negNums.Length > 0 then raise (CountNeg negNums)

          posNums |> List.reduce( fun acc elem -> acc + (int elem)) 

   member x.Add numbers =  numbers |> Add2 [| ',' ; '\n'|]  




