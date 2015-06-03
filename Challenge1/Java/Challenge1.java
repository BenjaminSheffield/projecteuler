import java.util.*;
import java.lang.*;
import java.io.*;

public class Challenge1 {
	
	public static void main(String[] args){
		System.out.println(Fibonacci());
	}

	public static int Fibonacci(){
		int firstNumber = 0;
		int secondNumber = 0;
		int result = 0;
		int totalNumber = 0;
		while (result < 4000000){
			firstNumber = secondNumber;
			secondNumber = result;
			result = firstNumber + secondNumber;
			if (result % 2 == 0){
				totalNumber += result;
			}}
		return result;		
		
	}
}