function Palindromic() {
    var highestPalindromic = 0;
    for (var i = 0; i < 1000; i++) {
        for (var j = 0; j < 1000;
            j++) {

            var totalNumber = i * j
            var numberReversed = parseInt((("" + totalNumber).split("")).reverse().join(""));

            if (totalNumber == numberReversed && highestPalindromic < numberReversed) {
                highestPalindromic = totalNumber;
            }
        }
    }
    return highestPalindromic
}

console.log(Palindromic());