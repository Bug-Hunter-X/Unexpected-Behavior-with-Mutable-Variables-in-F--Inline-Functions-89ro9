let mutable x = 10
let mutable y = 20

let add x y =  x + y

let inline mutableAdd x y = 
    x <- x + y
    y <- y + x
    x + y

printf "%A" (add x y)
printf "%A" (mutableAdd &x &y)