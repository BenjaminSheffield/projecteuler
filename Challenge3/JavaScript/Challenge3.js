function PrimeFactors() {
    var totalNumber = 600851475143;

    for (var i = 2; i < totalNumber; i++) {
        if (totalNumber % i == 0) {
            totalNumber = (totalNumber / i);
        }
    }
    return totalNumber;
}

console.log(PrimeFactors());