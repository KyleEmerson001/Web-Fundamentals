class Card{
    constructor(name, cost){
        this.name = name
        this.card = card
    }

}


class Unit{
    constructor(name, cost = 0, power = 0, resilience = 0){
    this.name = name;
    this.cost = cost;
    this.power = power;
    this.resilience = resilience;
    }
    showStats(){
        console.log(`Name: ${this.name}, Cost: ${this.cost}, Power: ${this.power}, Resilience: ${this.resilience}`);
    }
}
class RedBeltNinja extends Unit{
    constructor(name, cost = 3, power = 3, resilience = 4){
        super(name, cost, power, resilience);
    }
}

class BlackBeltNinja extends Unit{
    constructor(name, cost = 4, power = 5, resilience = 4){
        super(name, cost, power, resilience);
    }
}

class Effect{
    constructor(name, text, stat, cost = 0,  magnitude = 0){
    this.name = name;
    this.text = text;
    this.stat = stat;
    this.cost = cost;
    this.magnitude = magnitude;
    }

}
const Ninja1 = new RedBeltNinja("Red Belt Ninja");
const Ninja2 = new BlackBeltNinja("Black Belt Ninja");
const effect1 = new Effect("Hard Algorithm", "increase target's resilience by 3", "resilience", 2, 3);
const effect2 = new Effect("Unhandled Promise Rejection", "reduce target's resilience by 2", "resilience", 1, -2);
const effect3 = new Effect("Pair Programming}", "increase target's power by 2", "resilience", 3, 2);
Ninja2.showStats();