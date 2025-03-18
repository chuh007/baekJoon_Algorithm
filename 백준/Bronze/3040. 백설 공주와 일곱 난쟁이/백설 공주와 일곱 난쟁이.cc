#include <iostream>
using namespace std;



int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int arr[9], sum = 0;
	bool isFind = false;
	for (int i = 0;i < 9;i++)
	{
		cin >> arr[i];
		sum += arr[i];
	}
	for (int i = 0;i < 9;i++)
	{
		for (int j = 0;j < 9;j++)
		{
			if (i == j)
				continue;
			if (sum - arr[i] - arr[j] == 100)
			{
				isFind = true;
				for (int k = 0;k < 9;k++)
				{
					if (k == i || k == j)
						continue;
					cout << arr[k] << '\n';
				}
				break;
			}
		}
		if (isFind)
			break;
	}
}