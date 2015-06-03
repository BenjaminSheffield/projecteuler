firstNumber = 0
secondNumber = 1
result = 0
totalNumber = 0
while result < 4000000
    firstNumber = secondNumber
    secondNumber = result
    result = firstNumber + secondNumber 
    totalNumber = totalNumber + result if (result % 2 == 0)
end
puts totalNumber
