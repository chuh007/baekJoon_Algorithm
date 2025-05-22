#include <iostream>
#include<algorithm>
#include<map>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    map<string, int> password;
	string s;
    int a;
    cin >> a;
    for (int i = 0;i < a;i++)
    {
		cin >> s;
		password[s]++;
        reverse(s.begin(), s.end());
        password[s]++;
    }
	for (auto it = password.begin(); it != password.end(); it++)
	{
		if (it->second >= 2)
		{
			cout << it->first.size() << " ";
			cout << it->first[it->first.size()/2] << "\n";
			return 0;
		}
	}
}