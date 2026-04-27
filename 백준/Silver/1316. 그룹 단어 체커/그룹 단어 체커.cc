#include <iostream>
#include <string>

using namespace std;

int main()
{
	int a, cnt = 0;
	cin >> a;
	string s;
	bool isgroup = true;
	for (int i = 0; i < a; i++)
	{
		bool isUse[26];
		for (int i = 0; i < 26; i++)
		{
			isUse[i] = false;
		}
		cin >> s;
		if (s.size() < 3)
		{
			cnt++;
			continue;
		}
		isgroup = true;
		for (int j = 0; j < s.size() - 1; j++)
		{
			if (s[j] != s[j + 1])
			{
				if (isUse[s[j] - 'a'])
				{
					isgroup = false;
					break;
				}
				else isUse[s[j] - 'a'] = true;
			}
		}
		if (isUse[s[s.size() - 1] - 'a'])isgroup = false;
		if (isgroup) cnt++;
	}
	cout << cnt;
}