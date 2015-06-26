// Challenge4.cpp : Defines the entry point for the console application.
//

# include "stdafx.h"
# include <iostream>
using  namespace std;

int Palindromic()
{
	int highestPalindromic = 0;
	for (size_t i = 0; i < 100; i++)
	{
		for (size_t j = 0; j < 100; j++)
		{
			int totalNumber = i*j;
			/*char numberChar = totalNumber;*/
			wstring ws = totalNumber.str();
			/*char reverseChar = reverseChar(st);*/
				
		}
	}



	return highestPalindromic;

}

//void reverseChar(char* str)
//{
//	for (i = 0; i<sizeof(str) / 2; i++)
//	{
//		char temp = str[i];
//		str[i] = str[sizeof(str) - i - 1];
//		str[sizeof(str) - i - 1] = temp;
//	}
//}


int _tmain(int argc, _TCHAR* argv[])
{
	cout<<Palindromic();
	std::cin.get();
	return 0;	
	
}

