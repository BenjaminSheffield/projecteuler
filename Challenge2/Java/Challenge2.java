public class Challenge2 {
	
	public static void main(String[] args){
		System.out.println(Fibonacci());
	}
		
		public static int Fibonacci(){
			int firstNumber = 0;
			int secondNumber = 1;
			int nextNumber = 0;
			int totalNumber = 0;
			
			while (nextNumber < 4000000){
				nextNumber = firstNumber + secondNumber;
				firstNumber = secondNumber;
				secondNumber = nextNumber;
				if	(nextNumber % 2 == 0){
					totalNumber += nextNumber;
				}}
			return totalNumber;
		}
}