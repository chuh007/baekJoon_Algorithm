#include<iostream>
#include<string>
using namespace std;

int main()
{
    // 크로아티아 알파벳
    string sArr[8] = { "c=","c-","dz=","d-","lj","nj","s=","z=" };
    string s;
    cin >> s;
    int answer = s.size();

    for (int i = 0; i < 8; i++) {
        size_t pos = s.find(sArr[i]);
        while (pos != string::npos) {
            s.replace(pos, sArr[i].length(), " ");
            if (i == 2) {
                answer -= 2;
            }
            else {
                answer -= 1;
            }
            pos = s.find(sArr[i], pos + 1);
        }
    }
    cout << answer;

    return 0;
}