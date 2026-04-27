#include <iostream>
using namespace std;

int main()
{
	int arr[26];
	for (int i = 0; i < 26; i++)
	{
		arr[i] = -1;
	}
	string s;
	cin >> s;
	for (int i = 0; i < s.size(); i++)
	{
		if (arr[s[i] - 'a'] == -1) arr[s[i] - 'a'] = i;
	}
	for (int i = 0; i < 26; i++)
	{
		cout << arr[i] << " ";
	}
}
