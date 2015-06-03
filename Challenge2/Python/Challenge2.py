firstNumber = 0
secondNumber = 1
result = 0
totalNumber = 0
for num in range(0,100):
	if result > 4000000:
		break
	else: 
		firstNumber = secondNumber
		secondNumber = result 
		result = firstNumber + secondNumber
	if result % 2 == 0:
			totalNumber += result 
print (totalNumber)

