// Latihan
const animals = [
    { name: "nemo", species: "fish", class: { name: "vertebrata" } },
    { name: "tom", species: "cat", class: { name: "mamalia" } },
    { name: "trex", species: "cat", class: { name: "mamalia" } },
    { name: "dory", species: "fish", class: { name: "vertebrata" } },
    { name: "lutung", species: "cat", class: { name: "mamalia" } }
]

// Case 1
const onlyCat = []

for (let i = 0; i < animals.length; i++) {
    if (animals[i].species == "cat") {
        onlyCat.push(animals[i].species)
        break
    }
}
console.log(onlyCat)


// Case 2
for (let i = 0; i < animals.length; i++) {
    if (animals[i].class.name == "vertebrata") {
        animals[i].class.name = "non-mamalia"
    }
}
console.log(animals)