function Fibonacci() {
    var firstNumber = 0;
    var secondNumber = 1;
    var totalNumber = 0;
    var result = 0;

    while (result < 4000000) {
        firstNumber = secondNumber;
        secondNumber = result;
        result = firstNumber + secondNumber;
        if (result % 2 == 0) {
            totalNumber += result;
        }
    }
    return totalNumber;
}

console.log(Fibonacci());