function  Fibonacci()
{
    var firstNumber = 0;
    var  secondNumber = 1;
    var  totalNumber = 0;
    for (var i = 0; i < 100; i++)
    {
        var result = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = result;
        if (result > 4000000)
        {
            break;
        }
        if (result % 2 == 0)
        {
            totalNumber += result;
        }
    }
    return totalNumber;
}

console.log(Fibonacci());