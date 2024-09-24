#include <string>
#include <vector>
#include <iostream>

using namespace std;

int main() {
    int answer = 0;
    int a, b, c;
    cin >> a >> b >> c;
    int ain, aout, bin, bout, cinput, coutput;
    cin >> ain >> aout >> bin >> bout >> cinput >> coutput;
    for (int i = 1;i <= 100;i++) {
        int count = 0;
        if (i<aout && i>=ain) {
            count++;
        }
        if (i<bout && i>=bin) {
            count++;
        }
        if (i<coutput && i>=cinput) {
            count++;
        }
        switch (count)
        {
            case 1:
                answer += a;
                break;
            case 2:
                answer += b*2;
                break;
            case 3:
                answer += c*3;
                break;
        }
    }
    cout << answer;

    return 0;
}
