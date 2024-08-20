#include<iostream>
#include<string>
using namespace std;

int main()
{
    long long a;
    cin >> a;
    string s;
    cin >> s;
    long long answer = 0;
    for (int i = 0;i < a;i++) {
        long long x = s[i] - 'a' + 1;
        for (int j = 0;j < i;j++) {
            x = x * 31 % 1234567891;
        }
        answer += x % 1234567891;
    }
    cout << answer % 1234567891;
}