#include <iostream>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    int n, arrmin = 1000000000, ansmax = 0;
    cin >> n;
    int* arr = new int[n];
    int* ans = new int[n];
    for (int i = 0;i < n;i++)
    {
		cin >> arr[i];
		if (arr[i] < arrmin)
			arrmin = arr[i];
		ansmax = arr[i] - arrmin > ansmax ? arr[i] - arrmin : ansmax;
		ans[i] = ansmax;
    }
    for (int i = 0;i < n; i++)
    {
		cout << ans[i] << " ";
    }
}