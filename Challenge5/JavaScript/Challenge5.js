function largestDivisible(){
	var testNumber = 20;

	while (testNumber % 2 != 0 || testNumber % 3 != 0 || testNumber % 4 != 0 || testNumber % 5 != 0 ||
                     testNumber % 6 != 0 || testNumber % 7 != 0 || testNumber % 8 != 0 || testNumber % 9 != 0 ||
                     testNumber % 10 != 0 || testNumber % 11 != 0 || testNumber % 12 != 0 || testNumber % 13 != 0 ||
                     testNumber % 14 != 0 || testNumber % 15 != 0 || testNumber % 16 != 0 || testNumber % 17 != 0 ||
                     testNumber % 18 != 0 || testNumber % 19 != 0 || testNumber % 20 != 0){
		testNumber += 20;
	}
	return testNumber;
}

console.log(largestDivisible())