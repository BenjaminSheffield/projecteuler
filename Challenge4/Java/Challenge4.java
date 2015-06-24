public class Challenge4
{   
        public static void main(String[] args){
            System.out.println(Palindromic());
        }

        public static int Palindromic()
        {
            int highestPalindromic = 0;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    int totalNumber = i * j;
                    char[] totalChar = ("" + totalNumber).toCharArray();
                    char[] charReversed = new StringBuilder(new String(totalChar)).reverse().toString().toCharArray();
											
					int reversedNumber = Integer.parseInt(new String(charReversed));

                    if (totalNumber == reversedNumber && highestPalindromic < totalNumber)
                    {
                        highestPalindromic = totalNumber;
                    }
                }
            }
            return highestPalindromic;
        }    
}
