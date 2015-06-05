public class Challenge1{

    public static void main(String[] args){
        System.out.println(MultipleSums(3, 5, 1000));
    }

    public static int MultipleSums(int firstNumber, int secondNumber, int total)
    {
        int totalNumber = 0;
        for (int i = 0; i < total; i++)
        {
            if (i % firstNumber == 0 || i % secondNumber == 0)
            {
                totalNumber += i;
            }
        }
        return totalNumber;
    }
}
