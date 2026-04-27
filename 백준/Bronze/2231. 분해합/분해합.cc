#include<iostream>
#include<string>
#include<algorithm>
#include<vector>
using namespace std;


int main()
{
    int N;
    cin >> N;
    bool find = false;
    for (int i = 1;i < N;i++) {
        string s = to_string(i);
        int M = i;
        for (auto a : s) {
            M += a - 48;
        }
        if (N == M) {
            cout << i;
            find = true;
            break;
        }
    }
    if (find == false) cout << 0;

    return 0;
}