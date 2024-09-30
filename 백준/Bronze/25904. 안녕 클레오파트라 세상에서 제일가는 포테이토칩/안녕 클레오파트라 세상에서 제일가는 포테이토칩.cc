#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main() {
    int N, X;
    cin >> N >> X;
    int* arr = new int[N];
    for (int i = 0;i < N;i++) {
        cin >> arr[i];
    }
    int man = 0;
    while (true)
    {
        if (arr[man] < X) {
            cout << man+1;
            break;
        }
        man++;
        if (man >= N) {
            man = 0;
        }
        X++;
    }

    return 0;
}
