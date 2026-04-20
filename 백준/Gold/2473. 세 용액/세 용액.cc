#include <iostream>
#include <climits>
#include <algorithm>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int n, a;
	cin >> n;
	long long* arr = new long long[n];
	int idx1 = 0, idx2 = n - 1, idx3 = 0;
	for (int i = 0; i < n; ++i)
	{
		cin >> arr[i];
	}
	sort(arr, arr + n);
	int answer1 = 0, answer2 = 0, answer3 = 0;
	long long minsum = LLONG_MAX;
	for (; idx3 < n - 2; ++idx3)
	{
		idx1 = idx3 + 1;
		idx2 = n - 1;
		while (idx1 < idx2)
		{
			if (idx1 == idx3) idx1++;
			if (idx2 == idx3) idx2--;
			long long sum = arr[idx1] + arr[idx2] + arr[idx3];
			long long sumabs = abs(sum);
			if (minsum > sumabs)
			{
				answer1 = arr[idx1];
				answer2 = arr[idx2];
				answer3 = arr[idx3];
				minsum = sumabs;
			}
			if (sum > 0) idx2--;
			else if (sum < 0) idx1++;
			else break;
		}
	}
	if (answer2 > answer3)
		swap(answer2, answer3);
	if (answer1 > answer2)
		swap(answer1, answer2);
	if (answer2 > answer3)
		swap(answer2, answer3);
	cout << answer1 << ' ' << answer2 << ' ' << answer3;
	return 0;
}