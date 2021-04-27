function pizzaOven(crust, sauce, [cheese], [toppings]) {
    var pizza = {};
     pizza.crustType = crust;
     pizza.sauceType = sauce;
     pizza.cheese = [cheese];
     pizza.toppings = [toppings];
     return pizza;
}
var p1 = pizzaOven("deep dish", "traditional", ["mozzarella"], ["pepperoni", "sausage"]);
console.log(p1);
var p2= pizzaOven("hand tossed", "marinara", ["mozzarella", "feta"], ["mushrooms", "olives", "onions"]);
console.log(p2)
var p3= pizzaOven("thin and crispy", "barbeque", ["mozzarella"], ["bacon", "ham", "pineapple"]);
console.log(p3)
var p4= pizzaOven("hand tossed", "marinara", ["mozzarella", "cheddar"], ["bacon", "pepperoni", "sausage"])
console.log(p4)
