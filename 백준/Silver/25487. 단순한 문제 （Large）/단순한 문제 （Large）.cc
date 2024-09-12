#include<iostream>
using namespace std;
int main()
{
    ios::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);
    int t;
    cin >> t;
    int a,b,c;
    for (int i = 0;i < t;i++) {
        cin >> a >> b >> c;
        a = min(a, min(b, c));
        cout << a <<'\n';
    }
    return 0;
}