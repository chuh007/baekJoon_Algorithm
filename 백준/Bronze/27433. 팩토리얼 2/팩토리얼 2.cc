#include <iostream>
using namespace std;

long Fack(int n)
{
    if (n <= 1) return 1;
    return n * Fack(n - 1);
}

int main() {
    int n;
    cin >> n;
    cout << Fack(n);
    return 0;
}