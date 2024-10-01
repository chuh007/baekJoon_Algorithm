#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;


int main() {

    string s;
    getline(cin, s);
    for (char c : s) {
        if (c == ' ') cout << " ";
        else if (48 <= c && c <= 57) {
            cout << c;
        }
        else if (65 <= c && c <= 90) {
            if (c + 13 > 90) cout << (char)((c + 13) % 90 + 64);
            else cout << (char)(c + 13);
        }
        else
        {
            if (c + 13 > 122) cout << (char)((c + 13) % 122 + 96);
            else cout << (char)(c + 13);
        }
    }

    return 0;
}

