#include <iostream>
#include <string>

using namespace std;
int main()
{
	string s;
	getline(cin, s);
	if (s[0] != '"' || s[s.size() - 1] != '"' || (s.size() <= 2 && s[0] == '"')) cout << "CE";
	else
	{
		for (int i = 1; i < s.size() - 1; ++i)
		{
			cout << s[i];
		}
	}
}
