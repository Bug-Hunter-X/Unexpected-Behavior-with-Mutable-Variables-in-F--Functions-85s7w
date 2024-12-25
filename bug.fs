let mutable x = 10
let mutable y = 20

let add x y =  x + y

printf "%d" (add x y) //expect 30

let add2 x y = 
    x <- x + 1 //modify the value of x 
    y <- y + 1 //modify the value of y
    x + y

printf "%d" (add2 x y) //expect 34 but print 32

let add3 x y = 
    let mutable x1 = x
    let mutable y1 = y
    x1 <- x1 + 1
    y1 <- y1 + 1
    x1 + y1
printf "%d" (add3 x y) //expect 34, and print 34
