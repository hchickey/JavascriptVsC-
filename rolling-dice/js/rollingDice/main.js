// Put your code here

console.log("Let's roll some dice, baby!")
console.log("---------------------------")

// Roll Die
const rollDice = () => {
    let value = Math.floor(Math.random() * 6) + 1
    return value
}

for (let i = 0; i < 10; i++) {
    let die1 = rollDice();
    let die2 = rollDice();
    let total = die1 + die2

    switch (die1) {

        case 1:
            die1 = "one";
            break;
        case 2:
            die1 = "two";
            break;
        case 3:
            die1 = "three";
            break;
        case 4:
            die1 = "four";
            break;
        case 5:
            die1 = "five";
            break;
        case 6:
            die1 = "six";
            break;
    }

    switch (die2) {

        case 1:
            die2 = "one";
            break;
        case 2:
            die2 = "two";
            break;
        case 3:
            die2 = "three";
            break;
        case 4:
            die2 = "four";
            break;
        case 5:
            die2 = "five";
            break;
        case 6:
            die2 = "six";
            break;
    }

    let message = `${die1} + ${die2} === ${total}`
    if (die1 === die2) {
        message += " DOUBLES!";
    }

    console.log(message)
}
