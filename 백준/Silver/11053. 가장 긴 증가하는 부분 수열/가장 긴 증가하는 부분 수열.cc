#include<iostream>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	int arr[1000];
	int input[1000];
	int a;
	cin >> a;
	arr[0] = 1;
	for (int i = 0;i < a;i++)
	{
		cin >> input[i];
	}
	int max;
	for (int i = 0;i < a;i++)
	{
		max = 1;
		for (int j = 0; j < i; j++)
		{
			if (input[j] < input[i])
			{
				max = max > arr[j] ? max : arr[j] + 1;
			}
		}
		arr[i] = max;
	}
	for (int i = 0;i < a;i++)
	{
		max = max > arr[i] ? max : arr[i];
	}
	cout << max;
}