#include <iostream>
using namespace std;

int arr[1000001];

int main()
{
	int t, n;
	arr[1] = 1;
	arr[2] = 2;
	arr[3] = 4;
	for (int i = 4;i < 1000001;i++) {
		arr[i] = ((arr[i - 1] % 1000000009 + arr[i - 2] % 1000000009) % 1000000009 + arr[i - 3] % 1000000009) % 1000000009;
	}
	cin >> t;
	for (int i = 0;i < t; i++) {
		cin >> n;
		cout << arr[n] << '\n';
	}
}
