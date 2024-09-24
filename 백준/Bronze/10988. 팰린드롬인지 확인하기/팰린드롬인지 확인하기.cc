#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main() {
    string s;
    cin >> s;
    int answer = 1;
    for (int i = 0;i < s.size() / 2;i++) {
        if (s[i] != s[s.size() - i - 1]) answer = 0;
    }
    cout << answer;
    return 0;
}
