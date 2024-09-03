#include<iostream>
#include<string>
#include<algorithm>
#include<vector>
using namespace std;


int main()
{
    int N;
    cin >> N;
    int count = 1;
    int wow = 0;
    int a = 2;
    while (true)
    {
        if (N == 1) break;
        if (a > N) break;
        count++;
        a += (wow += 6);
    }
    cout << count;
    return 0;
}