module Assignment

// Problem 1
let rec prod (lst:int list) =
    // write your solution here
   if List.isEmpty lst
    then 1
    else List.head lst * prod (List.tail lst)

// Problem 2
let rec map f (lst:int list) =
    // write your solution here
    []
    

// Problem 3

let rec odd (lst:int list) =
    // write your solution here
     lst=[0;3;5];;
    
    
// Problem 4
let rec filter f lst =
    // write your solution here
    lst
