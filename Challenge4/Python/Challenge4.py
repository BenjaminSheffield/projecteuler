def palindromic():	
	highestPalindromic = 0
	for x in range(0,1000):
		for y in range(1,1000):
			totalNumber = x*y
			totalNumberReversed = int(str(totalNumber)[::-1])
			if totalNumber == totalNumberReversed and highestPalindromic < totalNumber:
							highestPalindromic = totalNumber		
	return highestPalindromic
print (palindromic())