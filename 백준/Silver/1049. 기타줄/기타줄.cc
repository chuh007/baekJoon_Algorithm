
#include <iostream>
#include <string>
#include <algorithm>
using namespace std;
int main()
{
	// 기타줄
	int n, m;
	cin >> n >> m;
	int *mokKm = new int[m];
	int *natgea = new int[m];
	for (int i = 0;i < m;i++) {
		cin >> mokKm[i] >> natgea[i];
	}
	sort(mokKm, (mokKm + m));
	sort(natgea, (natgea + m));
	int answer = 0;
	if (mokKm[0] < natgea[0] * 6) {
		int a = n / 6 * mokKm[0] + n % 6 * natgea[0];
		if ((n / 6 + 1) * mokKm[0] < a) {
			answer = (n / 6 + 1) * mokKm[0];
		}
		else
		{
			answer = a;
		}
	}
	else
	{
		answer = natgea[0] * n;
	}
	cout << answer;
}
