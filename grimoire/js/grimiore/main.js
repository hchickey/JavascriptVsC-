// Put your code here

console.log("Do you believe in magic?");
console.log("------------------------");


const allSpells = [
    {
        Name: "Turn enemy into a newt",
        IsEvil: true,
        EnergyReqired: 5.1
    },
    {
        Name: "Conjure some gold for a local charity",
        IsEvil: false,
        EnergyReqired: 2.99
    },
    {
        Name: "Give a deaf person the ability to heal",
        IsEvil: false,
        EnergyReqired: 12.2
    },
    {
        Name: "Make yourself emperor of the universe",
        IsEvil: true,
        EnergyReqired: 100.0
    },
    {
        Name: "Convince your relatives your political views are correct",
        IsEvil: false,
        EnergyReqired: 2921.5
    }

]





const goodSpellBook = (spells) => {
    let goodBook = []


    for (const spell of spells) {
        if (spell.IsEvil === false) {
            goodBook.push(spell.Name)
        }
    }

    return goodBook;
}

const evilSpellBook = (spells) => {
    let evilBook = []


    for (const spell of spells) {
        if (spell.IsEvil === true) {
            evilBook.push(spell.Name)
        }
    }

    return evilBook;
}



console.log("Good Book")
console.log(goodSpellBook(allSpells));
console.log("Evil Book")
console.log(evilSpellBook(allSpells));
