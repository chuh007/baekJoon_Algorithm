#include <iostream>
#include <vector>
#include <unordered_map>
using namespace std;

int main()
{
	int n, a, maxcnt = 0, idx1 = 0, idx2 = 0;
	unordered_map<int, int> fruitcnt;
	cin >> n;
	int* arr = new int[n];
	for (int i = 0; i < n; i++)
	{
		cin >> a;
		arr[i] = a;
	}
	for (int i = 0; i < n; i++)
	{
		idx2++;
		fruitcnt[arr[i]]++;
		while (fruitcnt.size() > 2)
		{
			fruitcnt[arr[idx1]]--;
			if (fruitcnt[arr[idx1]] == 0) fruitcnt.erase(arr[idx1]);
			idx1++;
		}
		maxcnt = idx2 - idx1 > maxcnt ? idx2 - idx1 : maxcnt;
	}
	cout << maxcnt;
	return 0;
}