#include <string>
#include <vector>
#include<iostream>
#include<algorithm>
#include<stack>
using namespace std;

int main()
{
    int t;
    cin >> t;
    int arr[3];
    
    for (int i = 0;i < t;i++) {
        cin >> arr[0] >> arr[1] >> arr[2];
        sort(arr,arr+3);
        cout << arr[0]<<'\n';
    }
    return 0;
}