#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

int main() {
    int N,M,answer = 0;
    cin >> N;
    int* arr = new int[N];
    cin >> M;
    for (int i = 0;i < N;i++) {
        cin >> arr[i];
    }
    for (int i = 0;i < N;i++) {
        for (int j = 0;j < N;j++) {
            if (i == j) continue;
            if (arr[i] + arr[j] == M) {
                answer++;
                arr[i] = -15001;
                arr[j] = -15001;
            }
        }
    }
    cout << answer;

    return 0;
}
