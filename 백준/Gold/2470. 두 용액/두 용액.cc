#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int n, a;
	cin >> n;
	vector<int> arr;
	int idx1 = 0, idx2 = n - 1;
	for (int i = 0; i < n; ++i)
	{
		cin >> a;
		arr.push_back(a);
	}
	sort(arr.begin(), arr.end());
	int answer1 = 0, answer2 = 0, minsum = INT_MAX, sub;
	while (idx1 < idx2)
	{
		int sum = arr[idx1] + arr[idx2];
		int sumabs = abs(sum);
		if (minsum > sumabs) {
			answer1 = arr[idx1];
			answer2 = arr[idx2];
			minsum = sumabs;
		}
		if (sum > 0) idx2--;
		else if (sum < 0) idx1++;
		else break;
	}
	cout << answer1 << ' ' << answer2;
	return 0;
}