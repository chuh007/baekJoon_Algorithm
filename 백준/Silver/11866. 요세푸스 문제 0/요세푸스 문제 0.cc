#include <string>
#include <vector>
#include<iostream>
using namespace std;


int main() {
    int N, K;
    cin >> N >> K;
    vector<int> vector;
    for (int i = 1;i <= N;i++) {
        vector.push_back(i);
    }
    int index = K-1;
    cout << '<';
    while (vector.empty()== false)
    {
        index = index % vector.size();
        cout << vector[index];
        vector.erase(vector.begin()+index);
        if (vector.empty() == false) cout << ", ";
        index += (K - 1);
    }
    cout << '>';
    return 0;
}
