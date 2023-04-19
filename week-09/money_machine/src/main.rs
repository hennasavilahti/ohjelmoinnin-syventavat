use std::fmt;

/// Represents a monetary amount in euros and cents.
#[derive(Debug)]
struct Amount {
    euros: u32,
    cents: u32,
}

struct Machine {
    name: String,
    weight: f32,
    coins: Vec<Coin>
}

// Custom Display trait implementation for Amount
impl fmt::Display for Amount {
    fn fmt(&self, f: &mut fmt::Formatter) -> fmt::Result {
        write!(f, "{}.{:02} \u{20AC}", self.euros, self.cents)
    }
}

impl Amount {
    /// Makes a new amount from cents
    fn new(cents: u32) -> Self {
        Amount {
            euros: cents / 100,
            cents: cents % 100
        }
    }

    /// Gets the amount as cents
    fn as_cents(&self) -> u32 {
        self.euros * 100 + self.cents
    }
}

/// Euro coins
enum Coin {
    Cent1,
    Cent2,
    Cent5,
    Cent10,
    Cent20,
    Cent50,
    Eur1,
    Eur2,
}

impl Coin {
    /// Gets the monetary value of this coin in cents.
    fn value_in_cents(&self) -> u32 {
        match self {
            Coin::Cent1 => 1,
            Coin::Cent2 => 2,
            Coin::Cent5 => 5,
            Coin::Cent10 => 10,
            Coin::Cent20 => 20,
            Coin::Cent50 => 50,
            Coin::Eur1 => 100,
            Coin::Eur2 => 200
        }
    }

    fn weight_in_grams(&self) -> f32 {
        match self {
            Coin::Cent1 => 2.30,
            Coin::Cent2 => 3.06,
            Coin::Cent5 => 3.92,
            Coin::Cent10 => 4.10,
            Coin::Cent20 => 5.74,
            Coin::Cent50 => 7.80,
            Coin::Eur1 => 7.50,
            Coin::Eur2 => 8.50
        }
    }


}

impl Machine {
    fn new(name: &str, weight: f32) -> Self {
        Self {
            name: name.into(),
            weight: weight,
            coins: vec![]
        }
    }

    fn insert_coin(&mut self, coin: Coin) {
        self.coins.push(coin);
    }

    fn total_coin_weight(&self) -> f32 {
        let mut sum: f32 = 0.0;
        for coin in self.coins.iter() {
            sum += coin.weight_in_grams();
        }
        sum / 1000.0
    }

    fn total_weight(&self) -> f32 {
        self.weight + self.total_coin_weight()
    }

    fn coin_count(&self) -> usize {
        self.coins.len()
    }

    fn total_amount(&self) -> Amount {
        let mut value_in_cents = 0;
        for coin in self.coins.iter() {
            value_in_cents += coin.value_in_cents();
        }
        Amount::new(value_in_cents)
    }

    fn empty(&mut self) {
        self.coins.clear();
    }

}

fn main() {

    // Make an array of coins
    // let my_coins: [Coin; 3] = [Coin::Cent50, Coin::Cent20, Coin::Eur1];

    // Sum up the weights of the coins
    // let mut sum: f32 = 0.0;
    // for coin in my_coins.iter() {
    //     sum += coin.weight_in_grams();
    // }

    // Print the weight of the coins
    // println!("My coins weigh {} grams", sum);

    // Make a coin machine
    let mut machine = Machine::new("CoinMaster 3000", 274.8);

    // Insert coins to the machine
    machine.insert_coin(Coin::Cent50);
    machine.insert_coin(Coin::Eur1);
    machine.insert_coin(Coin::Eur2);

    println!("Amount of coins in the machine is {}", machine.coin_count());
    println!("Total weigh of the coins is {} kilos", machine.total_coin_weight());
    println!("Total weigh of the machine is {} kilos", machine.total_weight());
    println!("Total value of the coins is {}", machine.total_amount());

    // Empty the machine out of coins
    machine.empty();
    println!("*************************************************");

    // Prints after deleting coins
    println!("Amount of coins in the machine is {}", machine.coin_count());
    println!("Total weigh of the coins is {} kilos", machine.total_coin_weight());
    println!("Total weigh of the machine is {} kilos", machine.total_weight());
    println!("Total value of the coins is {}", machine.total_amount());

}