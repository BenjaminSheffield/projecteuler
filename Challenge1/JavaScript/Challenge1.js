function MultipleSums(firstNumber, secondNumber, total) {
    var totalNumber = 0;
    for (i = 0; i < total; i++) {
        if (i % firstNumber == 0) {
            totalNumber += i;
        }
        if (i % secondNumber == 0 && i % firstNumber != 0) {
            totalNumber += i;
        }
    }
    return totalNumber;
}

console.log(MultipleSums(3, 5, 1000));
