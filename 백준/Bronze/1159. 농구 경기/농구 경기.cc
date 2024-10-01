#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;



int main() {
    int N;
    cin >> N;
    string* arr = new string[N];
    int abclist[26] = {};
    for (int i = 0;i < N;i++) {
        cin >> arr[i];
        abclist[arr[i][0]-97]++;
    }
    bool suren = true;
    for (int i = 0;i < 26;i++) {
        if (abclist[i] >= 5) {
            suren = false;
            cout << (char)(i + 97);
        }
    }
    if (suren) cout << "PREDAJA";


    return 0;
}
