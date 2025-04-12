#include<iostream>
#include<string>
using namespace std;

int main()
{
    int a, b;

    cin >> a >> b;

    int p = b;
    while (p != 0)
    {
        int r = p % 10;
        cout << a * r << endl;
        p /= 10;
    }
    cout << a * b;
}