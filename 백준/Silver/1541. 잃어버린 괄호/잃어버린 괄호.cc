#include <iostream>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    string s;
	cin >> s;
	bool isminus = false;
    int answer = 0, nownum = 0;
    for(char c : s)
	{
        if (c >= '0' && c <= '9')
        {
			nownum = nownum * 10 + (c - '0');
        }
        else
        {
            if (c == '+')
            {
				if (isminus)
				{
					answer -= nownum;
				}
				else
				{
					answer += nownum;
				}
            }
            else
            {
				if (!isminus) answer += nownum;
				else answer -= nownum;
				isminus = true;
            }
            nownum = 0;
        }
	}
	if (isminus) answer -= nownum;
	else answer += nownum;
    cout << answer;
}